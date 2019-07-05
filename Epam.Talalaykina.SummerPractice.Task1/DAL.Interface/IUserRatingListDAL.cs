using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IUserRatingListDAL
    {
        void Add(UserRatingList value);

        UserRatingList GetByID(int userID, int storeID);

        void UpdateByID(int userID, int storeID, int assortmentRating, int priceLevelRating, int serviceRating);

        void RemoveByID(int userID, int storeID);
    }
}
