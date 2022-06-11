using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using POS_App.General;

namespace POS_App.General
{
    public class App_settings
    { 
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["pos_db"].ConnectionString;
        }
    }
}
