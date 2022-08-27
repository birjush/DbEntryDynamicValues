using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntryStaticValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BIRJU\source\repos\DbEntryStaticValues\DbEntryStaticValues\Database1.mdf;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("connection established successfully!");
                //create crud
                Console.WriteLine("enter name :");
                String userName = Console.ReadLine();
                Console.WriteLine("enter age :");
                String userAge = Console.ReadLine();
                string insertQuery = $"INSERT INTO DETAIL(name,age) VALUES ('{userName}','{userAge}')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection) ;
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("data inserted successfully");
                sqlConnection.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
