using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace CRUDWinFormsMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnClients.Click += delegate
            {
                ShowClientView?.Invoke(this, EventArgs.Empty);
                if (panelContenedor.Visible == true)
                {
                    panelContenedor.Visible = false;
                    lblDate.Visible = false;
                    lblTime.Visible = false;
                }
                else if (panelContenedor.Visible == false)
                {
                    panelContenedor.Visible = true;
                    lblDate.Visible = true;
                    lblTime.Visible = true;

                }                 
            };
        }

        public event EventHandler ShowClientView;
        public event EventHandler ShowOwnerView;

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La sesión se ha cerrado exitosamente", "Atención - Feria Virtual", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Application.Exit();
        }
        private static MainView instance;
        public static MainView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainView();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
                instance.panelContenedor.Visible = true;

            }
            return instance;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //public void OpenFormClient(object formClient)
        //{
        //    if (instance.panelContenedor.Controls.Count > 0)
        //        instance.panelContenedor.Controls.RemoveAt(0);
        //    Form fh = formClient as Form;
        //    fh.TopLevel = false;
        //    instance.Dock = DockStyle.Fill;
        //    instance.panelContenedor.Controls.Add(fh);
        //    instance.panelContenedor.Tag = fh;
        //    fh.Show();
        //}

        //public void btnClients_Click(object sender, EventArgs e)
        //{
        //    OpenFormClient(new ClientView());
        //}
    }
}
