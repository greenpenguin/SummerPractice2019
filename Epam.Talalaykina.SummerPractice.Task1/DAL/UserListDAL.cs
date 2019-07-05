using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class UserListDAL : BaseDAL, IUserListDAL
    {
        public void Add(UserList value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddUser";
                cmd.Parameters.AddWithValue(@"Login", value.UserLogin);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_User",
                    Direction = ParameterDirection.Output
                };
                
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        
        public UserList GetByID(int ID)
        {
            UserList user = new UserList();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectUserByID";
                cmd.Parameters.AddWithValue(@"ID_User", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.IDUser = (int)reader["ID_User"];
                    user.UserLogin = (string)reader["User_Login"];
                }
            }
            return user;
        }

        public void UpdateByID(int ID, string newLogin)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUserByID";
                cmd.Parameters.AddWithValue(@"ID_User", ID);
                cmd.Parameters.AddWithValue(@"Login", newLogin);
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
                cmd.CommandText = "DeleteUserByID";
                cmd.Parameters.AddWithValue(@"ID_User", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsUserExistsByUsername(string username)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsUserExistsByUsername";
                cmd.Parameters.AddWithValue(@"Username", username);
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
