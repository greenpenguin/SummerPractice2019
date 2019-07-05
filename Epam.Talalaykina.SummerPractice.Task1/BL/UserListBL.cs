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
    public class UserListBL : IUserListBL
    {
        private UserListDAL userListDAL = new UserListDAL();

        public void Add(UserList value)
        {
            userListDAL.Add(value);
        }

        public UserList GetByID(int ID)
        {
            return userListDAL.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            userListDAL.RemoveByID(ID);
        }

        public void UpdateByID(int ID, string newLogin)
        {
            userListDAL.UpdateByID(ID, newLogin);
        }

        public int IsUserExistsByUsername(string username)
        {
            return userListDAL.IsUserExistsByUsername(username);
        }

    }
}
