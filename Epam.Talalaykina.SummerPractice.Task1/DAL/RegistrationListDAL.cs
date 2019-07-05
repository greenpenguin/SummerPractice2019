using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegistrationListDAL : BaseDAL, IRegistrationListDAL
    {
        public void Add(RegistrationList value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddRegistrationRecord";
                cmd.Parameters.AddWithValue(@"ID_User", value.IDUser);
                cmd.Parameters.AddWithValue(@"User_Login", value.UserLogin);
                cmd.Parameters.AddWithValue(@"User_Password", value.UserPassword);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Registration",
                    Direction = ParameterDirection.Output
                };

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public RegistrationList GetByID(int ID)
        {
            RegistrationList record = new RegistrationList();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectRegistrationRecord";
                cmd.Parameters.AddWithValue(@"ID_Registration", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    record.IDRegistrationRecord = (int)reader["ID_Registration"];
                    record.IDUser = (int)reader["ID_User"];
                    record.UserLogin = (string)reader["User_Login"];
                    record.UserPassword = (string)reader["User_Password"];
                }
            }
            return record;
        }

        public void UpdateByID(int ID, string newLogin, string newPassword)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateRegistrationRecord";
                cmd.Parameters.AddWithValue(@"ID_Registration", ID);
                cmd.Parameters.AddWithValue(@"User_Login", newLogin);
                cmd.Parameters.AddWithValue(@"User_Password", newPassword);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteRegistrationRecordByID";
                cmd.Parameters.AddWithValue(@"ID_Registration", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsRegistrationRecordExists(int ownerID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsIRegistrationRecordByID";
                cmd.Parameters.AddWithValue(@"ID_Registration", ownerID);
                var output = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@result",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (output.Value is int)
                {
                    return result = (int)output.Value;
                }
                else
                {
                    return 0;
                }

            }
        }

        public int IsIRegistrationRecordExistsByLogAndPass(string log, string pass)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsIRegistrationRecordExistsByLogAndPass";
                cmd.Parameters.AddWithValue(@"User_Login", log);
                cmd.Parameters.AddWithValue(@"User_Password", pass);
                var output = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@result",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (output.Value is int)
                {
                    return result = (int)output.Value;
                }
                else
                {
                    return 0;
                }

            }
        }

        public int IsIRegistrationRecordExistsByLog(string log)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsIRegistrationRecordExistsByLog";
                cmd.Parameters.AddWithValue(@"User_Login", log);
                var output = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@result",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (output.Value is int)
                {
                    return result = (int)output.Value;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
