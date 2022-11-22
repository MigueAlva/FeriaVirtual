using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Presenters;
using CRUDWinFormsMVP._Repositories;
using CRUDWinFormsMVP.Views;
using System.Configuration;
using System.Data.OracleClient;

namespace CRUDWinFormsMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string oracleConnectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
            //IMainView view = new MainView();           
            ILoginView view = new LoginView();
            new LoginPresenter(view, oracleConnectionString);
            //new MainPresenter(view,oracleConnectionString);
            Application.Run((Form)view);
        }
    }
}
