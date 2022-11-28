using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace CRUDWinFormsMVP._Repositories
{
    public class UserRepository : BaseRepository
    {
        
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
                command.CommandText = "SELECT PASSWORD FROM USERS WHERE EMAIL='"+user+"'";             
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var result = BCrypt.Net.BCrypt.Verify(password, reader[0].ToString());
                    return result;
                }                
            }
            return false;
        }
    }
}



