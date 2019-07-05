using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IStoreListBL
    {
        void Add(StoreList value);

        StoreList GetByID(int ID);

        void UpdateByID(int ID, string newName);

        void RemoveByID(int ID);
    }
}
