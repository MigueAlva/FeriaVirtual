using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDWinFormsMVP.Views;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP._Repositories;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string oraConnectionString;

        public MainPresenter(IMainView mainView, string oraConnectionString)
        {
            this.mainView = mainView;
            this.oraConnectionString = oraConnectionString;
            this.mainView.ShowClientView += ShowClientsView;
            this.mainView.Show();
        }

        private void ShowClientsView(object sender, EventArgs e)
        {
            IClientView view = ClientView.GetInstace((MainView)mainView);
            IClientRepository repository = new ClientRepository(oraConnectionString);
            new ClientPresenter(view, repository);
        }
    }
}
