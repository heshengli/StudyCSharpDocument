using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppADO
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SqlConnection connection = new SqlConnection(
                "Data Source=.;Initial Catalog=TestDb;Persist Security Info=True;User ID=sa;pwd=123456;App=123;"))
            {
                connection.Open();
                // Pool A is created.
                SqlCommand cmd=new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from Infoes";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            //using (SqlConnection connection = new SqlConnection(
            //    "Data Source=.;Initial Catalog=FutureTender;Persist Security Info=True;User ID=sa;pwd=123456;App=456;"))
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "select * from S_User";
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Connection = connection;
            //    cmd.ExecuteNonQuery();
            //    // Pool B is created because the connection strings differ.
            //}

            using (SqlConnection connection = new SqlConnection(
                "Data Source=.;Initial Catalog=TestDb;Persist Security Info=True;User ID=sa;pwd=123456;App=123;"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from Infoes";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                // The connection string matches pool A.
            }

            Console.WriteLine("结束");
            Console.ReadKey();
        }
    }
}
