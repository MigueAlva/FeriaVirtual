using CRUDWinFormsMVP._Repositories;

namespace CRUDWinFormsMVP.Models
{
    public class UserModel
    {
        private string user;
        private string pass;
        UserRepository userepo = new UserRepository();

        public bool LoginUser(string value3, string value4)
        {
            return userepo.LoginUser(value3, value4);
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}

