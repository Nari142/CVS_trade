using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          string connStr = "server=localhost;user id=root;password=Ab_42211;database=CVS_trade;";
          MySqlConnection conn = new MySqlConnection(connStr);  

          conn.Open();
          Console.WriteLine("Open");
          //Create_tab(conn);
          CVS(conn);
          conn.Close();
          Console.WriteLine("Close");
        }

        public static void Create_tab(MySqlConnection conn){
          string sql = "CREATE TABLE trade( category VARCHAR(250), code VARCHAR(250), name VARCHAR(250), owner VARCHAR(250));";
          MySqlCommand command = new MySqlCommand(sql, conn);
          command.ExecuteNonQuery();
        }

        public static void CVS (MySqlConnection conn){
          string sql = "LOAD DATA INFILE 'data.CSV' INTO TABLE trade FIELDS TERMINATED BY ',' IGNORE 1 ROWS;";
          MySqlCommand command = new MySqlCommand(sql, conn);
          command.ExecuteNonQuery();
        }
    }
}
