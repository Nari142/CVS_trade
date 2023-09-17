using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string args)
        {
          string connStr = "server=localhost;user=root;database=CVS_trade;";
          MySqlConnection conn = new MySqlConnection(connStr);  
          conn.Open();
          Console.WriteLine("Open");
          string sql = "CREATE TABLE trade( category VARCHAR(250), code VARCHAR(250), name VARCHAR(250), owner VARCHAR(250));";
          MySqlCommand command = new MySqlCommand(sql, conn);
          conn.Close();
          Console.WriteLine("Close");
        }
    }
}
