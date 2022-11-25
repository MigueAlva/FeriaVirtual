using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace CRUDWinFormsMVP._Repositories
{
    public class UserRepository : BaseRepository
    {
        //public UserRepository(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        //public bool LoginUser(string value1, string value2)
        //{
        //    using (var connection = new OracleConnection(connectionString))
        //    {
        //        bool resultttt = false;
        //        MessageBox.Show("aaaa " + resultttt);
        //        connection.Open();
        //        resultttt = true;
        //        MessageBox.Show("iiii " + resultttt);
        //        //MessageBox.Show("adios");
        //        using (var command = new OracleCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "SELECT * FROM USERS WHERE email = @user and PASSWORD = @pass";
        //            //command.CommandText = "SELECT * FROM USERS WHERE email = 'miguel@gmail.com' and PASSWORD = '183973'";
        //            //  miguel@gmail.com  183973
        //            command.Parameters.AddWithValue("@user", value1);
        //            command.Parameters.AddWithValue("@pass", value2);
        //            command.CommandType = CommandType.Text;
        //            OracleDataReader reader = command.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                //MessageBox.Show("Inicio de sesión exitoso");
        //                return true;
        //            }
        //            else
        //                return false; //MessageBox.Show("Intente nuevamente");
        //        }
        //    }
        //}
        string oraconnectionString = "Data Source=localhost/orcl;User ID=duoc2;Password=123;Unicode=True";

        public bool LoginUser(string value1, string value2)
        {
            using (var connection = new OracleConnection(oraconnectionString))
            using (var command = new OracleCommand())
            {
                
                string user = value1;
                string password = value2;
                connection.Open();             
                command.Connection = connection;
                //command.Parameters.AddWithValue("user",user);
                //command.Parameters.AddWithValue("pass",password);

                
                //command.Parameters.Add("pass", OracleType.VarChar).Value = password;
                //command.CommandText = "SELECT * FROM USERS WHERE EMAIL='" + user + "' and PASSWORD='" + password +"';";

                //command.CommandText = "SELECT * FROM USERS WHERE email = 'miguel@gmail.com' and PASSWORD = '183973'";
                //MessageBox.Show(user + "\n" + password + "\n" + command.CommandText + "\n" + command.CommandType);

                command.CommandText = "SELECT PASSWORD FROM USERS WHERE EMAIL='"+user+"'";
                //command.Parameters.AddWithValue("user", user);
                //command.Parameters.Add("@user", OracleType.VarChar).Value = user;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var result = BCrypt.Net.BCrypt.Verify(password, reader[0].ToString());
                    return result;
                }              

                //command.CommandType = CommandType.Text;
                
                //return true;
                //using (OracleDataReader reader = command.ExecuteReader())
                //{
                //    //bool validPass = BCrypt.Net.BCrypt.Verify(password, user.Ha);
                //    if (reader.HasRows)
                //    {
                //        if()    
                //        //MessageBox.Show("Inicio de sesión exitoso");
                //        return true;
                //    }
                //    else
                //        return false; //MessageBox.Show("Intente nuevamente");
                //}

                
            }
            return false;
        }
    }
}



