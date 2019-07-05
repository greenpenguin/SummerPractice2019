using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StoreList
    {
        public int IDStore { get; set; }
        public string StoreName { get; set; }

        public StoreList()
        { }

        public StoreList(string storeName)
        {
            StoreName = storeName;
        }

        public override string ToString()
        {
            return $"Store ID: {IDStore}. Store Name: {StoreName}";
        }
    }
}
