using System;
using System.Windows.Forms;
using System.Drawing;
using CRUDWinFormsMVP.Presenters;


namespace CRUDWinFormsMVP.Views
{
    public partial class ClientView : Form, IClientView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public ClientView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents(); 
            tabControl1.TabPages.Remove(tabPageClientDetail);                 
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); }; 
            txtSearch.KeyDown += (s, e) =>  
             {
                 if (e.KeyCode == Keys.Enter)
                     SearchEvent?.Invoke(this, EventArgs.Empty);
             };

            //Add new
            btnAddClient.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageClientList);
                tabControl1.TabPages.Add(tabPageClientDetail);
                tabPageClientDetail.Text = "Agregar cliente";
            };
            //Edit
            btnEdit.Click += delegate
            {
                if (dgvClient.SelectedRows.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageClientList);
                    tabControl1.TabPages.Add(tabPageClientDetail);
                    tabPageClientDetail.Text = "Editar Cliente";

                }
                else if (dgvClient.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Seleccione algún cliente", "Atención - Feria virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageClientDetail);
                    tabControl1.TabPages.Add(tabPageClientList);
                }


            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageClientDetail);
                tabControl1.TabPages.Add(tabPageClientList);
            };
            //Delete
            btnDelete.Click += delegate
            {
                if (dgvClient.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("¿Estás seguro que deseas continuar?", "Atención - Feria Virtual",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                    }
                }
                else if (dgvClient.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Seleccione algún cliente", "Atención - Feria virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        //Properties
        public string UserID
        {
            get { return txtUserID.Text; }
            set { txtUserID.Text = value; }
        }
        public string Rut
        {
            get { return txtRut.Text; }
            set { txtRut.Text = value; }
        }
        public string ClientName
        {
            get { return txtClientName.Text; }
            set { txtClientName.Text = value; }
        }
        public string ClientType
        {
            get { return txtClientType.Text; }
            set { txtClientType.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string BusinessName
        {
            get { return txtBusinessName.Text; }
            set { txtBusinessName.Text = value; }
        }
        public string Country
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }
        public string Region
        {
            get { return txtRegion.Text; }
            set { txtRegion.Text = value; }
        }
        public string Commune
        {
            get { return txtCommune.Text; }
            set { txtCommune.Text = value; }
        }
        public string Street
        {
            get { return txtStreet.Text; }
            set { txtStreet.Text = value; }
        }
        public string Url
        {
            get { return txtURL.Text; }
            set { txtURL.Text = value; }
        }
        public string Observations
        {
            get { return txtObservations.Text; }
            set { txtObservations.Text = value; }
        }
        public DateTime ContractExpiredAt
        {
            get { return dtpContractExpiredAt.Value; }
            set { dtpContractExpiredAt.Value = value; }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetClientListBindingSource(BindingSource clientList)
        {
            dgvClient.DataSource = clientList;
        }
        //Singleton pattern (Open a single form instance)
        private static ClientView instance;
        public static ClientView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ClientView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;             
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

    }
}





