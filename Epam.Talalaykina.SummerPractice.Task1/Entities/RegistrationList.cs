using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegistrationList
    {
        public int IDRegistrationRecord { get; set; }
        public int IDUser { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public RegistrationList()
        { }

        public RegistrationList(int idUser, string userLogin, string userPassword)
        {
            IDUser = idUser;
            UserLogin = userLogin;
            UserPassword = userPassword;
        }

        public override string ToString()
        {
            return $"Registration ID: {IDRegistrationRecord}. User ID: {IDUser} " +
                $"User Login: {UserLogin}. User Password: {UserPassword}";
        }
    }
}
