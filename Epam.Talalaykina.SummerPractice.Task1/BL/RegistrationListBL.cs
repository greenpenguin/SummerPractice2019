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
    public class RegistrationListBL : IRegistrationListBL
    {
        private RegistrationListDAL registrationListtDAL = new RegistrationListDAL();

        public void Add(RegistrationList value)
        {
            registrationListtDAL.Add(value);
        }

        public RegistrationList GetByID(int ID)
        {
            return registrationListtDAL.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            registrationListtDAL.RemoveByID(ID);
        }

        public void UpdateByID(int ID, string newLogin, string newPassword)
        {
            registrationListtDAL.UpdateByID(ID, newLogin, newPassword);
        }

        public int IsRegistrationRecordExists(int ID)
        {
            return registrationListtDAL.IsRegistrationRecordExists(ID);
        }

        public int IsIRegistrationRecordExistsByLogAndPass(string log, string pass)
        {
            return registrationListtDAL.IsIRegistrationRecordExistsByLogAndPass(log, pass);
        }

        public int IsIRegistrationRecordExistsByLog(string log)
        {
            return registrationListtDAL.IsIRegistrationRecordExistsByLog(log);
        }
    }
}
