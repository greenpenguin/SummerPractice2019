using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IUserListBL
    {
        void Add(UserList value);

        UserList GetByID(int ID);

        void UpdateByID(int ID, string newLogin);

        void RemoveByID(int ID);
    }
}
