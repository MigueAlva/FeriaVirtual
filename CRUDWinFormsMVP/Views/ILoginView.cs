using System;

namespace CRUDWinFormsMVP.Views
{
    public interface ILoginView
    {
        string User { get; set; }
        string Pass { get; set; }

        event EventHandler ShowMainView;
        event EventHandler ShowOwnerView;
        event EventHandler LoginUser;

        void Show();
        void Hide();
    }


}
