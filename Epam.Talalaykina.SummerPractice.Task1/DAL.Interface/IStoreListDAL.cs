using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IStoreListDAL
    {
        void Add(StoreList value);

        StoreList GetByID(int ID);

        void UpdateByID(int ID, string newName);

        void RemoveByID(int ID);
        
    }
}
