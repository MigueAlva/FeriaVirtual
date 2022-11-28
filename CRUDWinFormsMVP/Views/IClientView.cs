using System;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public interface IClientView
    {
        //Properties - Fields
        string UserID { get; set; }
        //string Password { get; set; }
        string Rut { get; set; }
        string ClientName { get; set; }
        string ClientType { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string BusinessName { get; set; }
        string Country { get; set; }
        string Region { get; set; }
        string Commune { get; set; }
        string Street { get; set; }
        string Url { get; set; }
        string Observations { get; set; }
        DateTime ContractExpiredAt { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetClientListBindingSource(BindingSource ClientList);
        void Show();

    }
}
