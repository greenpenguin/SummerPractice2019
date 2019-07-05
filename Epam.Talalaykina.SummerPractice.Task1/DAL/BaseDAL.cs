using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class BaseDAL
    {
        //protected string _connectionString = ConfigurationManager.ConnectionStrings["STORE_RATING_SYSTEM3ConnectionString"].ConnectionString;
        protected string _connectionString = "Data Source=localhost;Initial Catalog=STORE_RATING_SYSTEM3;Integrated Security=True";
    }
}
