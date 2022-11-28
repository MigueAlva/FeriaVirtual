using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP._Repositories;
using CRUDWinFormsMVP.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Presenters
{
    public class ClientPresenter
    {
        //Fields
        private IClientView view;
        private IClientRepository repository;
        private BindingSource clientsBindingSource;
        private IEnumerable<ClientModel> clientList;
        //Constructor
        public ClientPresenter(IClientView view, IClientRepository repository)
        {
            this.clientsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchClient;
            this.view.AddNewEvent += AddNewClient;
            this.view.EditEvent += LoadSelectedClientToEdit;
            this.view.DeleteEvent += DeleteSelectedClient;
            this.view.SaveEvent += SaveClient;
            this.view.CancelEvent += CancelAction;
            this.view.SetClientListBindingSource(clientsBindingSource);
            LoadAllClientList();
            this.view.Show();
        }
        //Methods
        private void LoadAllClientList()
        {
            clientList = repository.GetAll();
            clientsBindingSource.DataSource = clientList;
        }
        private void SearchClient(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                clientList = repository.GetByValue(this.view.SearchValue);
            }
            else if (emptyValue == true)
            {
                LoadAllClientList();
                //clientList = repository.GetAll();
            }
            clientsBindingSource.DataSource = clientList;
        }
        private void AddNewClient(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedClientToEdit(object sender, EventArgs e)
        {
            var client = (ClientModel)clientsBindingSource.Current;
            view.UserID = client.UserID.ToString();
            view.Rut = client.Rut;
            view.ClientName = client.ClientName;
            view.ClientType = client.ClientType;
            if (client.ClientType == "Nacional")
            {
                view.Country = "Chile";
            }
            else if (client.ClientType == "Internacional")
            {
                view.Country = client.Country;
            }
            view.Email = client.Email;
            view.Phone = client.Phone;
            view.BusinessName = client.BusinessName;
            view.Region = client.Region;
            view.Commune = client.Commune;
            view.Street = client.Street;
            view.Url = client.Url;
            view.Observations = client.Observations;
            view.ContractExpiredAt = client.ContractExpiredAt;
            view.IsEdit = true;

        }
        private void SaveClient(object sender, EventArgs e)
        {
            var model = new ClientModel();
            
            model.UserID = Convert.ToInt32(view.UserID);
            model.Rut = view.Rut;
            model.ClientName = view.ClientName;
            model.ClientType = view.ClientType;
            model.Email = view.Email;
            model.Phone = view.Phone;
            model.BusinessName = view.BusinessName;
            model.Country = view.Country;
            model.Region = view.Region;
            model.Commune = view.Commune;
            model.Street = view.Street;
            model.ContractExpiredAt = view.ContractExpiredAt;
            model.Url = view.Url;
            model.Observations = view.Observations;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit user
                {
                    repository.Edit(model);
                }
                else //Add new user
                {
                    repository.Add(model);
                }
                view.IsSuccessful = true;
                LoadAllClientList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                //view.Message = ex.Message;
            }
        }
        private void CleanviewFields()
        {
            view.UserID = "0";
            view.Rut = "";
            view.ClientName = "";
            view.ClientType = "";
            view.Email = "";
            view.Phone = "";
            view.BusinessName = "";
            view.Country = "";
            view.Region = "";
            view.Commune = "";
            view.Street = "";
            view.Url = "";
            view.Observations = "";
            view.ContractExpiredAt = DateTime.Parse("28-11-2022");
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedClient(object sender, EventArgs e)
        {
            try
            {
                var client = (ClientModel)clientsBindingSource.Current;
                repository.Delete(client);
                view.IsSuccessful = true;
                SearchClient(client.Email, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Un error a ocurrido, intente nuevamente \n" + ex;
            }
        }

    }
}
