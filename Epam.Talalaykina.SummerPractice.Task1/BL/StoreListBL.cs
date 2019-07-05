using BL.Interface;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StoreListBL : IStoreListBL
    {
        private StoreListDAL storeListDAL = new StoreListDAL();

        public void Add(StoreList value)
        {
            storeListDAL.Add(value);
        }

        public StoreList GetByID(int ID)
        {
            return storeListDAL.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            storeListDAL.RemoveByID(ID);
        }

        public void UpdateByID(int ID, string newName)
        {
            storeListDAL.UpdateByID(ID, newName);
        }
        
        public int IsStoreExistsByStoreName(string storeName)
        {
            return storeListDAL.IsStoreExistsByStoreName(storeName);
        }
    }
}
