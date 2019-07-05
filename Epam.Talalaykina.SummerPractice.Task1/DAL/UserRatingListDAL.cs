using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRatingListDAL : BaseDAL, IUserRatingListDAL
    {
        public void Add(UserRatingList value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddStoreRating";
                cmd.Parameters.AddWithValue(@"ID_User", value.IDUser);
                cmd.Parameters.AddWithValue(@"ID_Store", value.IDStore);
                cmd.Parameters.AddWithValue(@"Assortment_Rating", value.AssortmentRating);
                cmd.Parameters.AddWithValue(@"Price_Level_Rating", value.PriceLevelRating);
                cmd.Parameters.AddWithValue(@"Service_Rating", value.ServiceRating);
                
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public UserRatingList GetByID(int userID, int storeID)
        {
            UserRatingList rating = new UserRatingList();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectStoreRating";
                cmd.Parameters.AddWithValue(@"ID_User", userID);
                cmd.Parameters.AddWithValue(@"ID_Store", storeID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rating.IDUser = (int)reader["ID_User"];
                    rating.IDStore = (int)reader["ID_Store"];
                    rating.AssortmentRating = (int)reader["Assortment_Rating"];
                    rating.PriceLevelRating = (int)reader["Price_Level_Rating"];
                    rating.ServiceRating = (int)reader["Service_Rating"];
                }
            }
            return rating;
        }

        public void UpdateByID(int userID, int storeID, int assortmentRating, int priceLevelRating, int serviceRating)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateStoreRating";
                cmd.Parameters.AddWithValue(@"ID_User", userID);
                cmd.Parameters.AddWithValue(@"ID_Store", storeID);
                cmd.Parameters.AddWithValue(@"Assortment_Rating", assortmentRating);
                cmd.Parameters.AddWithValue(@"Price_Level_Rating", priceLevelRating);
                cmd.Parameters.AddWithValue(@"Service_Rating", serviceRating);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveByID(int userID, int storeID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteStoreRating";
                cmd.Parameters.AddWithValue(@"ID_User", userID);
                cmd.Parameters.AddWithValue(@"ID_Store", storeID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsRatingExistsByID(int idUser, int idStore)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsRatingExistsByID";
                cmd.Parameters.AddWithValue(@"ID_User", idUser);
                cmd.Parameters.AddWithValue(@"ID_Store", idStore);
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

        public IEnumerable<UserRatingList> GetAllByStoreID(int ID)
        {
            //List<UserRatingList> userRatingList = new List<UserRatingList>();
            List<UserRatingList> userRatingList = new List<UserRatingList>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSomeRatingByStoreID";
                cmd.Parameters.AddWithValue(@"ID_Store", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userRatingList.Add(new UserRatingList
                    {
                        AssortmentRating = (Int32)reader["Assortment_Rating"],
                        PriceLevelRating = (Int32)reader["Price_Level_Rating"],
                        ServiceRating = (Int32)reader["Service_Rating"]
                    });
                }
            }
            return userRatingList;
        }

    }
}
