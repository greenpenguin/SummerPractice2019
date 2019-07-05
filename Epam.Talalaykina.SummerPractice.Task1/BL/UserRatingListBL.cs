using BL.Interface;
using Entities;
using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserRatingListBL : IUserRatingListBL
    {
        private UserRatingListDAL userRatingListDAL = new UserRatingListDAL();

        public void Add(UserRatingList value)
        {
            userRatingListDAL.Add(value);
        }

        public UserRatingList GetByID(int userID, int storeID)
        {
            return userRatingListDAL.GetByID(userID, storeID);
        }

        public void RemoveByID(int userID, int storeID)
        {
            userRatingListDAL.RemoveByID(userID, storeID);
        }

        public void UpdateByID(int userID, int storeID, int assortmentRating, int priceLevelRating, int serviceRating)
        {
            userRatingListDAL.UpdateByID(userID, storeID, assortmentRating, priceLevelRating, serviceRating);
        }

        public int IsRatingExistsByID(int userID, int storeID)
        {
            return userRatingListDAL.IsRatingExistsByID(userID, storeID);
        }

        public IEnumerable<UserRatingList> GetAllByStoreID(int ID)
        {
            return userRatingListDAL.GetAllByStoreID(ID);
        }
        
    }
}
