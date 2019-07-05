using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserList
    {
        public int IDUser { get; set; }
        public string UserLogin { get; set; }

        public UserList()
        { }

        public UserList(string login)
        {
            UserLogin = login;
        }

        public override string ToString()
        {
            return $"User ID: {IDUser}. Username: {UserLogin}";
        }
    }
}
