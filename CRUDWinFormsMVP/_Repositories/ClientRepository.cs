using CRUDWinFormsMVP.Models;
//using Devart.Data.Oracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using BCrypt.Net;

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
            MessageBox.Show(mySalt);

            var myHash = BCrypt.Net.BCrypt.HashPassword(randomNumber.ToString(), mySalt);
            MessageBox.Show(myHash);
            MessageBox.Show(myHash.Length.ToString());


            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand("ADD_USER", connection))
            {              
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;             
                command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
                command.Parameters.Add("p_email", OracleType.VarChar).Value = ClientModel.Email;
                command.Parameters.Add("p_password", OracleType.VarChar).Value = myHash.ToString();
                if (ClientModel.ClientType == "Nacional" || ClientModel.ClientType == "nacional")
                {
                    command.Parameters.Add("p_role_id", OracleType.Number).Value = 2;
                }
                else if (ClientModel.ClientType == "Internacional" || ClientModel.ClientType == "internacional")
                {
                    command.Parameters.Add("p_role_id", OracleType.Number).Value = 3;
                }
                command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
            }
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
                            DateTime fecha = DateTime.Now.AddYears(1);
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = fecha;
                            command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cliente nacional registrado");
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
                            DateTime fecha = DateTime.Now.AddYears(1);
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = fecha;
                            command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cliente internacional registrado");
                        }

                        break;
                    }
            }

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
                if (ClientModel.Status == 0)
                {
                    command.Parameters.Add("p_status", OracleType.Number).Value = 1;
                    MessageBox.Show("Cliente activado exitosamente","Feria virtual", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                else if (ClientModel.Status == 1)
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
            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand("EDIT_USER", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_id", OracleType.Number).Value = ClientModel.UserID;
                command.Parameters.Add("p_name", OracleType.VarChar).Value = ClientModel.ClientName;
                command.Parameters.Add("p_data", OracleType.Cursor).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
            }

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
                            DateTime fecha = DateTime.Now.AddYears(1);
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = fecha;
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
                            DateTime fecha = DateTime.Now.AddYears(1);
                            command.Parameters.Add("p_contract_expired_at", OracleType.DateTime).Value = fecha;
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
                            clientModel.Password = reader[3].ToString();
                            clientModel.ClientType = reader[5].ToString();
                            clientModel.Status = reader.GetInt32(6);
                            clientModel.Rut = reader[11].ToString();
                            clientModel.BusinessName = reader[12].ToString();
                            clientModel.Country = reader[13].ToString();
                            clientModel.Region = reader[14].ToString();
                            clientModel.Commune = reader[15].ToString();
                            clientModel.Street = reader[16].ToString();
                            clientModel.Observations = reader[17].ToString();
                            clientModel.Url = reader[18].ToString();
                            clientModel.Phone = reader[19].ToString();
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
            return clientList;
        }
    }

}
