using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRegistrationListDAL
    {
        void Add(RegistrationList value);

        RegistrationList GetByID(int ID);

        void UpdateByID(int ID, string newLogin, string newPassword);

        void RemoveByID(int ID);
    }
}
