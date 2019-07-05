using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class StoreListDAL : BaseDAL, IStoreListDAL
    {
        public void Add(StoreList value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddStore";
                cmd.Parameters.AddWithValue(@"Store_Name", value.StoreName);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Store",
                    Direction = ParameterDirection.Output
                };

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public StoreList GetByID(int ID)
        {
            StoreList store = new StoreList();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectStoreByID";
                cmd.Parameters.AddWithValue(@"ID_Store", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    store.IDStore = (int)reader["ID_Store"];
                    store.StoreName = (string)reader["Store_Name"];
                }
            }
            return store;
        }

        public void UpdateByID(int ID, string newName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateStoreByID";
                cmd.Parameters.AddWithValue(@"ID_Store", ID);
                cmd.Parameters.AddWithValue(@"Store_Name", newName);
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
                cmd.CommandText = "DeleteStoreByID";
                cmd.Parameters.AddWithValue(@"ID_Store", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        
        public int IsStoreExistsByStoreName(string storeName)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsStoreExistsByStoreName";
                cmd.Parameters.AddWithValue(@"Store_Name", storeName);
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
