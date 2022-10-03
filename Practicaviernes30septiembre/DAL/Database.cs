using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using Practicaviernes30septiembre.Properties;

namespace Practicaviernes30septiembre.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }
        public SqlConnection GetConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }
    }
}
