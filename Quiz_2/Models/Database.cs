using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2.Models
{
    public class Database
    {

        public Books Books { get; set; }
        public Database()
        {
            string connetionString = @"Server=DESKTOP-AHOJPBJ\SQLEXPRESS;Database=model;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connetionString);
            Books = new Books(conn);
        }
    }

}
