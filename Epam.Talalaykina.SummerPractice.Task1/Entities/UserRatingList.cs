using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserRatingList
    {
        public int IDUser { get; set; }
        public int IDStore { get; set; }
        public Int32 AssortmentRating { get; set; }
        public Int32 PriceLevelRating { get; set; }
        public Int32 ServiceRating { get; set; }

        public UserRatingList()
        { }

        public UserRatingList(int idUser, int idStore, Int32 assortmentRating, Int32 priceLevelRating, Int32 serviceRating)
        {
            IDUser = idUser;
            IDStore = idStore;
            AssortmentRating = assortmentRating;
            PriceLevelRating = priceLevelRating;
            ServiceRating = serviceRating;
        }   

        public override string ToString()
        {
            return $"User ID: {IDUser} Store ID: {IDStore} Assortment Rating: {AssortmentRating} " +
                $"Price Level Rating: {PriceLevelRating} Service Rating: {ServiceRating}";
        }
    }
}
