using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IRegistrationListBL
    {
        void Add(RegistrationList value);

        RegistrationList GetByID(int ID);

        void UpdateByID(int ID, string newLogin, string newPassword);

        void RemoveByID(int ID);
    }
}
