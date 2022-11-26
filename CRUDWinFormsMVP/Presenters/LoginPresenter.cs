using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;
using System;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Presenters
{
    public class LoginPresenter
    {
        //private ILoginRepository repository;
        private ILoginView view;
        private ILoginRepository repo;
        //private string oracleConnectionString;

        //private string oracleConnectionString;
        private readonly string oracleConnectionString;

        //public LoginPresenter(ILoginView loginView, UserModel userModel)
        //{
        //    this.loginView = loginView;
        //    this.userModel = userModel;
        //    this.loginView.ShowMainView += ShowMainView;
        //}

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
            //this.view.ShowMainView += ShowMainView;
            this.view.LoginUser += btnLogin_Click;
            this.view.Show();
        }

        //public LoginPresenter(ILoginView view, string oraConnectionString)
        //{
        //    this.view = view;
        //    this.oraConnectionString = oraConnectionString;
        //    this.view.ShowMainView += ShowMainView;
        //    this.view.LoginUser += LoginUser;
        //    this.view.Show();
        //}


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var resul = LoginUser(sender, e);
            //MessageBox.Show("a " + resul);
            if (this.view.User != "USUARIO")
            {
                if (this.view.Pass != "CONTRASEÑA")
                {
                    var usermodel = new UserModel();
                    var result = usermodel.LoginUser(this.view.User, this.view.Pass);
                    //return result;
                    if (result == true)
                    {
                        MainView mainView = new MainView();
                        //mainView.Show();
                        IMainView mainview = MainView.GetInstace((LoginView)view);
                        //ILoginRepository repository = new UserRepository(oracleConnectionString);
                        new MainPresenter(mainview, oracleConnectionString);
                        this.view.Hide();
                        
                    }
                    else if (result == false)
                    {
                        MessageBox.Show("Usuario o contraseña inválidos", "Atención - Feria Virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else MessageBox.Show("Por favor ingrese su contraseña","Atención - Feria Virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Por favor ingrese su nombre de usuario", "Atención - Feria Virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

        }
        //private void ShowMainView(object sender, EventArgs e)
        //{
        //    IMainView mainview = MainView.GetInstace((LoginView)view);
        //    //ILoginRepository repository = new UserRepository(oraConnectionString);
        //    new MainPresenter(mainview, oraConnectionString);
        //}


    
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    var userModel = new UserModel();
        //    if (loginView.User != "USUARIO")
        //    {
        //        if (loginView.Pass != "CONTRASEÑA")
        //        {
        //            var resul = repository.LoginUser(loginView.User, loginView.Pass);
        //            if (resul == true)
        //            {
        //               MainView mainView = new MainView();
        //               mainView.Show();

        //            }
        //            else MessageBox.Show("Usuario o contraseña incorrectos, por favor intente nuevamente");

        //            //UserDao user = new UserDao();
        //            //var validLogin = user.LoginUser(loginView.User, loginView.Pass);
        //            //if (validLogin == true)
        //            //{//Aqui agregar pagina de inicio del sistema
        //            //    MainView mainView = new MainView();
        //            //    mainView.Show();
        //            //    //this.Hide();
        //            //}
        //            //else MessageBox.Show("Usuario o contraseña incorrectos, por favor intente nuevamente");

        //            //loginView.User.Clear();
        //            //loginView.Pass.Focus();
        //        }
        //        else MessageBox.Show("Por favor ingrese su contraseña");
        //    }
        //    else MessageBox.Show("Por favor ingrese su nombre de usuario");
        //}

        //UserDao userDao = new UserDao();
        //public bool LoginUser(string user, string pass)
        //{
        //    return userDao.LoginUser(user, pass);
        //}
    }
}
 

