using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;
using System;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private ILoginRepository repo;
        private readonly string oracleConnectionString;


        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            this.view = view;
            this.repo = repository;
            this.view.ShowMainView += btnLogin_Click;
            this.view.LoginUser += btnLogin_Click;
            this.view.Show();
        }

        public LoginPresenter(ILoginView view, string oracleConnectionString)
        {
            this.view = view;
            this.oracleConnectionString = oracleConnectionString;
            this.view.LoginUser += btnLogin_Click;
            this.view.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.view.User != "USUARIO")
            {
                if (this.view.Pass != "CONTRASEÑA")
                {
                    var usermodel = new UserModel();
                    var result = usermodel.LoginUser(this.view.User, this.view.Pass);
                    if (result == true)
                    {
                        MainView mainView = new MainView();
                        IMainView mainview = MainView.GetInstace((LoginView)view);
                        new MainPresenter(mainview, oracleConnectionString);
                        this.view.Hide();                        
                    }
                    else if (result == false)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta", "Atención - Feria Virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else MessageBox.Show("Por favor ingrese su contraseña","Atención - Feria Virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Por favor ingrese su nombre de usuario", "Atención - Feria Virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
    }
}
 

