using CRUDWinFormsMVP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using BCrypt.Net;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUDWinFormsMVP._Repositories
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        //Constructor
        public ClientRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public void Add(ClientModel ClientModel)
        {
            //ADD_USER
            var randomNumber = new Random().Next(10000000, 99999999);
            var mySalt = BCrypt.Net.BCrypt.GenerateSalt(10);
            var myHash = BCrypt.Net.BCrypt.HashPassword(randomNumber.ToString(), mySalt);

            //using (var connection = new OracleConnection(connectionString))
            //using (var command = new OracleCommand("ADD_USER", connection))
            //{              
            //    connection.Open();
            //    command.CommandType = CommandType.StoredProcedure;             
            //    command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
            //    command.Parameters.Add("p_email", OracleType.VarChar).Value = ClientModel.Email;
            //    command.Parameters.Add("p_password", OracleType.VarChar).Value = myHash.ToString();
                //if (ClientModel.ClientType == "Nacional" || ClientModel.ClientType == "nacional")
                //{
                //    command.Parameters.Add("p_role_id", OracleType.Number).Value = 2;
                //}
                //else if (ClientModel.ClientType == "Internacional" || ClientModel.ClientType == "internacional")
                //{
                //    command.Parameters.Add("p_role_id", OracleType.Number).Value = 3;
                //}
                //command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                //command.ExecuteNonQuery();
            //}
            switch (ClientModel.ClientType) 
            {
                case "Nacional":
                    {
                        //ADD_LOCAL_USER
                        using (var connection = new OracleConnection(connectionString))
                        using (var command = new OracleCommand("ADD_LOCAL_USER", connection))
                        {
                            connection.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
                            command.Parameters.Add("p_email", OracleType.VarChar).Value = ClientModel.Email;
                            command.Parameters.Add("p_password", OracleType.VarChar).Value = myHash;
                            command.Parameters.Add("p_role_id", OracleType.Number).Value = 2;
                            command.Parameters.Add("p_rut", OracleType.VarChar).Value = ClientModel.Rut;
                            command.Parameters.Add("p_business_name", OracleType.VarChar).Value = ClientModel.BusinessName;
                            command.Parameters.Add("p_region", OracleType.VarChar).Value = ClientModel.Region;
                            command.Parameters.Add("p_commune", OracleType.VarChar).Value = ClientModel.Commune;
                            command.Parameters.Add("p_street", OracleType.VarChar).Value = ClientModel.Street;
                            command.Parameters.Add("p_observations", OracleType.VarChar).Value = ClientModel.Observations;
                            command.Parameters.Add("p_direction_url", OracleType.VarChar).Value = ClientModel.Url;
                            command.Parameters.Add("p_phone", OracleType.VarChar).Value = ClientModel.Phone;
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = ClientModel.ContractExpiredAt;
                            command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cliente nacional registrado");
                            SendPassword(ClientModel.Email, ClientModel.ClientName, randomNumber.ToString());
                        }
                        break;
                    }

                default:
                    {
                        //ADD_EXTERNAL_USER

                        using (var connection = new OracleConnection(connectionString))
                        using (var command = new OracleCommand("ADD_EXTERNAL_USER", connection))
                        {
                            connection.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
                            command.Parameters.Add("p_email", OracleType.VarChar).Value = ClientModel.Email;
                            command.Parameters.Add("p_password", OracleType.VarChar).Value = myHash;
                            command.Parameters.Add("p_role_id", OracleType.Number).Value = 3;
                            command.Parameters.Add("p_rut", OracleType.VarChar).Value = ClientModel.Rut;
                            command.Parameters.Add("p_business_name", OracleType.VarChar).Value = ClientModel.BusinessName;
                            command.Parameters.Add("p_country", OracleType.VarChar).Value = ClientModel.Country;
                            command.Parameters.Add("p_region", OracleType.VarChar).Value = ClientModel.Region;
                            command.Parameters.Add("p_commune", OracleType.VarChar).Value = ClientModel.Commune;
                            command.Parameters.Add("p_street", OracleType.VarChar).Value = ClientModel.Street;
                            command.Parameters.Add("p_observations", OracleType.VarChar).Value = ClientModel.Observations;
                            command.Parameters.Add("p_direction_url", OracleType.VarChar).Value = ClientModel.Url;
                            command.Parameters.Add("p_phone", OracleType.VarChar).Value = ClientModel.Phone;
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = ClientModel.ContractExpiredAt;
                            command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cliente internacional registrado");
                            SendPassword(ClientModel.Email, ClientModel.ClientName, randomNumber.ToString());
                        }
                        break;
                    }                  
            }
        }
        public void SendPassword(string email, string user, string password)
        {
            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(email);
            mmsg.Subject = "Envío de contraseña";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = "Estimado "+user+" está es la contraseña generada automáticamente: "+password +" \n " + email;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new MailAddress("feriavirtual.fv@gmail.com");

            SmtpClient client = new SmtpClient();

            client.Credentials = new NetworkCredential("e8ef8dd4ff1d43", "4ea6074d1e94e4");

            client.Port = 2525;
            client.EnableSsl = false;
            client.Host = "smtp.mailtrap.io";
            try
            {
                client.Send(mmsg);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar el correo \n"+ex);
            }                 
        }
        public IEnumerable<ClientModel> GetAll()
        {
            var clientList = new List<ClientModel>();

            ////Get all local user
            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT u.id, u.name, u.email, u.role_id, u.status, lu.rut,lu.business_name, 'Chile' as country, lu.region, lu.commune, lu.street, lu.observations, lu.direction_url, lu.phone, c.expired_at  FROM users u  INNER JOIN roles r ON r.id = u.role_id INNER JOIN local_users lu ON lu.user_id = u.id INNER JOIN contracts c ON c.id = lu.contract_id";
                var reader = command.ExecuteReader();
                try
                {
                    using (reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                ClientModel clientModel = new ClientModel();

                                clientModel.UserID = reader.GetInt32(0);//10
                                clientModel.ClientName = reader[1].ToString();
                                clientModel.Email = reader[2].ToString();
                                var clientType = reader[3].ToString();
                                if (clientType == "2")
                                {
                                    clientModel.ClientType = "Nacional";
                                    
                                }
                                var status = reader.GetInt32(4);
                                if (status == 0)
                                {
                                    clientModel.Status = "Deshabilitado";
                                }
                                else if (status == 1)
                                {
                                    clientModel.Status = "Habilitado";
                                }
                                clientModel.Rut = reader[5].ToString();
                                clientModel.BusinessName = reader[6].ToString();
                                clientModel.Country = reader[7].ToString(); //Chile
                                clientModel.Region = reader[8].ToString();
                                clientModel.Commune = reader[9].ToString();
                                clientModel.Street = reader[10].ToString();
                                clientModel.Observations = reader[11].ToString();
                                clientModel.Url = reader[12].ToString();
                                clientModel.Phone = reader[13].ToString();
                                clientModel.ContractExpiredAt = reader.GetDateTime(14);
                                clientList.Add(clientModel);
                            }
                        }
                        else if (reader == null)
                        {
                            MessageBox.Show("El dato buscado no existe", "Feria Virtual", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contáctese con soporte Feria Virtual ", "Feria Virtual", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }

                //Get all external user
                using (var connection2 = new OracleConnection(connectionString))
                using (var command2 = new OracleCommand())
                {
                    connection2.Open();
                    command2.Connection = connection2;
                    command2.CommandText = "SELECT u.id, u.name, u.email, u.role_id, u.status, eu.rut, eu.business_name, eu.country, eu.region, eu.commune, eu.street, eu.observations, eu.direction_url, eu.phone, c.expired_at FROM users u INNER JOIN roles r ON r.id = u.role_id INNER JOIN external_users eu ON u.id = eu.user_id INNER JOIN contracts c ON eu.contract_id = c.id";
                    var reader2 = command2.ExecuteReader();
                    try
                    {
                        using (reader2 = command2.ExecuteReader())
                        {
                            if (reader2 != null)
                            {
                                while (reader2.Read())
                                {
                                    ClientModel clientModel = new ClientModel();

                                    clientModel.UserID = reader2.GetInt32(0);//10
                                    clientModel.ClientName = reader2[1].ToString();
                                    clientModel.Email = reader2[2].ToString();
                                    var clientType = reader2[3].ToString();
                                    if (clientType == "3")
                                    {
                                        clientModel.ClientType = "Internacional";
                                        
                                    }
                                    var status = reader2.GetInt32(4);
                                    if (status == 0)
                                    {
                                        clientModel.Status = "Deshabilitado";
                                    }
                                    else if (status == 1)
                                    {
                                        clientModel.Status = "Habilitado";
                                    }

                                    clientModel.Rut = reader2[5].ToString();
                                    clientModel.BusinessName = reader2[6].ToString();
                                    clientModel.Country = reader2[7].ToString();
                                    clientModel.Region = reader2[8].ToString();
                                    clientModel.Commune = reader2[9].ToString();
                                    clientModel.Street = reader2[10].ToString();
                                    clientModel.Observations = reader2[11].ToString();
                                    clientModel.Url = reader2[12].ToString();
                                    clientModel.Phone = reader2[13].ToString();
                                    clientModel.ContractExpiredAt = reader2.GetDateTime(14);
                                    clientList.Add(clientModel);
                                }
                            }
                            else if (reader2 == null)
                            {
                                MessageBox.Show("El dato buscado no existe", "Feria Virtual", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Contáctese con soporte Feria Virtual", "Feria Virtual", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    }
                }
            }
            return clientList;         
        }
        public void Delete(ClientModel ClientModel)
        {
            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand("CHANGE_STATUS_USER", connection))
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_id", OracleType.Number).Value = ClientModel.UserID;
                if (ClientModel.Status == "Deshabilitado")
                {
                    command.Parameters.Add("p_status", OracleType.Number).Value = 1;
                    MessageBox.Show("Cliente activado exitosamente","Feria virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                else if (ClientModel.Status == "Habilitado")
                {
                    command.Parameters.Add("p_status", OracleType.Number).Value = 0;
                    MessageBox.Show("Cliente deshabilitado exitosamente","Feria virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
            }
        }
        public void Edit(ClientModel ClientModel)
        {
            //EDIT_USER
            //using (var connection = new OracleConnection(connectionString))
            //using (var command = new OracleCommand("EDIT_USER", connection))
            //{
            //    connection.Open();
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.Add("p_id", OracleType.Number).Value = ClientModel.UserID;
            //    command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
            //    command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
            //    command.ExecuteNonQuery();
            //}

            switch (ClientModel.ClientType)
            {
                case "Nacional":
                    {
                        //EDIT_LOCAL_USER
                        using (var connection = new OracleConnection(connectionString))
                        using (var command = new OracleCommand("EDIT_LOCAL_USER", connection))
                        {
                            connection.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("p_id", OracleType.Number).Value = ClientModel.UserID;
                            command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
                            command.Parameters.Add("p_rut", OracleType.VarChar).Value = ClientModel.Rut;
                            command.Parameters.Add("p_business_name", OracleType.VarChar).Value = ClientModel.BusinessName;
                            command.Parameters.Add("p_region", OracleType.VarChar).Value = ClientModel.Region;
                            command.Parameters.Add("p_commune", OracleType.VarChar).Value = ClientModel.Commune;
                            command.Parameters.Add("p_street", OracleType.VarChar).Value = ClientModel.Street;
                            command.Parameters.Add("p_observations", OracleType.VarChar).Value = ClientModel.Observations;
                            command.Parameters.Add("p_direction_url", OracleType.VarChar).Value = ClientModel.Url;
                            command.Parameters.Add("p_phone", OracleType.VarChar).Value = ClientModel.Phone;
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = ClientModel.ContractExpiredAt;
                            command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cliente nacional modificado exitosamente", "Feria virtual", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        break;
                    }
                default:
                    {
                        //EDIT_EXTERNAL_USER
                        using (var connection = new OracleConnection(connectionString))
                        using (var command = new OracleCommand("EDIT_EXTERNAL_USER", connection))
                        {
                            connection.Open();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("p_id", OracleType.Number).Value = ClientModel.UserID;
                            command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
                            command.Parameters.Add("p_rut", OracleType.VarChar).Value = ClientModel.Rut;
                            command.Parameters.Add("p_business_name", OracleType.VarChar).Value = ClientModel.BusinessName;
                            command.Parameters.Add("p_country", OracleType.VarChar).Value = ClientModel.Country;
                            command.Parameters.Add("p_region", OracleType.VarChar).Value = ClientModel.Region;
                            command.Parameters.Add("p_commune", OracleType.VarChar).Value = ClientModel.Commune;
                            command.Parameters.Add("p_street", OracleType.VarChar).Value = ClientModel.Street;
                            command.Parameters.Add("p_observations", OracleType.VarChar).Value = ClientModel.Observations;
                            command.Parameters.Add("p_direction_url", OracleType.VarChar).Value = ClientModel.Url;
                            command.Parameters.Add("p_phone", OracleType.VarChar).Value = ClientModel.Phone;
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = ClientModel.ContractExpiredAt;
                            command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cliente internacional modificado exitosamente", "Feria virtual", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }
        public IEnumerable<ClientModel> GetByValue(string value)
        {
            var clientList = new List<ClientModel>();
            string email = value;
            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand("GET_USER_BY_EMAIL", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_email", OracleType.VarChar).Value = email;
                command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                ClientModel clientModel = new ClientModel();

                                clientModel.UserID = reader.GetInt32(10);//10
                                clientModel.ClientName = reader[1].ToString();
                                clientModel.Email = email;
                                var clientType = reader[5].ToString();
                                if (clientType == "2")
                                {
                                    clientModel.ClientType = "Nacional";
                                    clientModel.Country = "Chile";
                                    clientModel.Region = reader[13].ToString();
                                    clientModel.Commune = reader[14].ToString();
                                    clientModel.Street = reader[15].ToString();
                                    clientModel.Observations = reader[16].ToString();
                                    clientModel.Url = reader[17].ToString();
                                    clientModel.Phone = reader[18].ToString();
                                    clientModel.ContractExpiredAt = reader.GetDateTime(21);
                                }
                                else if (clientType == "3")
                                {
                                    clientModel.ClientType = "Internacional";
                                    clientModel.Country = reader[13].ToString();
                                    clientModel.Region = reader[14].ToString();
                                    clientModel.Commune = reader[15].ToString();
                                    clientModel.Street = reader[16].ToString();
                                    clientModel.Observations = reader[17].ToString();
                                    clientModel.Url = reader[18].ToString();
                                    clientModel.Phone = reader[19].ToString();
                                    clientModel.ContractExpiredAt = reader.GetDateTime(22);
                                }
                                var status = reader.GetInt32(6);
                                if (status == 0)
                                {
                                    clientModel.Status = "Deshabilitado";
                                }
                                else if (status == 1)
                                {
                                    clientModel.Status = "Habilitado";
                                }

                                clientModel.Rut = reader[11].ToString();
                                clientModel.BusinessName = reader[12].ToString();
                                //clientModel.Country = reader[13].ToString();
                                //clientModel.Region = reader[14].ToString();
                                //clientModel.Commune = reader[15].ToString();
                                //clientModel.Street = reader[16].ToString();
                                //clientModel.Observations = reader[17].ToString();
                                //clientModel.Url = reader[18].ToString();
                                //clientModel.Phone = reader[19].ToString();
                                clientList.Add(clientModel);
                            }
                        }
                        else if (reader == null)
                        {
                            MessageBox.Show("El dato buscado no existe", "Feria Virtual", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception )
                {

                }      
            }
            return clientList;
        }
    }

}
