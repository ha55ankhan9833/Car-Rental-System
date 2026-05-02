using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    internal class DBConnection
    {
        public static SqlConnection con = new SqlConnection(
            "Data Source=.\\SQLEXPRESS;Initial Catalog=Car_rental_system;Integrated Security=True"
        );
    }
}