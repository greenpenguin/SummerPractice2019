using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IUserListDAL
    {
        void Add(UserList value);

        UserList GetByID(int ID);

        void UpdateByID(int ID, string newLogin);

        void RemoveByID(int ID);
    }
}
