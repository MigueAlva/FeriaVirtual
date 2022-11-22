using CRUDWinFormsMVP._Repositories;
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
            this.view.ShowMainView += ShowMainView;
            this.view.LoginUser += ShowMainView;
            this.view.Show();
        }

        public LoginPresenter(ILoginView view, string oracleConnectionString)
        {
            this.view = view;
            this.oracleConnectionString = oracleConnectionString;
            this.view.ShowMainView += ShowMainView;
            this.view.LoginUser += ShowMainView;
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


        private void ShowMainView(object sender, EventArgs e)
        {
            var resul = LoginUser(sender, e);
            MessageBox.Show("a "+resul);
            if (resul == true)
            {
                MainView mainView = new MainView();
                mainView.Show();
                
                IMainView mainview = MainView.GetInstace((LoginView)view);
                ////ILoginRepository repository = new UserRepository(oracleConnectionString);
                new MainPresenter(mainview, oracleConnectionString);
            }
            else if (resul == false)
            {
                MessageBox.Show("Usuario o contraseña inválidos", "Atención - Feria Virtual", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }    

            
        }
        //private void ShowMainView(object sender, EventArgs e)
        //{
        //    IMainView mainview = MainView.GetInstace((LoginView)view);
        //    //ILoginRepository repository = new UserRepository(oraConnectionString);
        //    new MainPresenter(mainview, oraConnectionString);
        //}

        private bool LoginUser(object sender, EventArgs e)
        {
            
            if (this.view.User != "USUARIO")
            {
                if (this.view.Pass != "CONTRASEÑA")
                {
                    var usermodel = new UserModel();
                    //new Common.ModelDataValidation().Validate(model);
                    //var pass = this.view.Pass;
                    //var user = this.view.User;
                    var result = usermodel.LoginUser(this.view.User, this.view.Pass);
                    return result;
                    MessageBox.Show("sayonara" + result);
                    if (result == true)
                    {
                        MainView mainView = new MainView();
                        mainView.Show();
                        //MainView mainView = new MainView();
                        //mainView.Show();
                        //    IMainView view = MainView.GetInstace((LoginView)loginView);
                        //    ILoginRepository repository = new UserRepository(oraConnectionString);
                        //    new MainPresenter(view, oraConnectionString);

                    }
                    else return false;//MessageBox.Show("Usuario o contraseña incorrectos, por favor intente nuevamente");

                }
                else return false;//MessageBox.Show("Por favor ingrese su contraseña");
            }
            else return false; //MessageBox.Show("Por favor ingrese su nombre de usuario");

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
}
