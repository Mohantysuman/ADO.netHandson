using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BankDBS
{
    
    public class BankDBS
    {
        public static string sqlConnectionStr = @"Data Source=LAPTOP-MIL5M1L9;Initial Catalog=BankDBS;Integrated Security=True";
        public string InsertCustomer()
        {
            Console.Write("Enter Customer PersonID: ");
            int Personid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer LastName: ");
            string LastName = Console.ReadLine();

            Console.Write("Enter Customer FirstName: ");
            int FirstName = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Email: ");
            string Email = Console.ReadLine();

            Console.Write("Enter Customer City: ");
            string City = Console.ReadLine();

            
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Persons(" + Personid + ",'" + LastName + "','" + FirstName + "'," + Email + ",'" + City + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdatePersons()
        {
            return "";
        }
        public string DeletePersons()
        {
            return "";
        }
        public string SelectPersons()
        {
            return "";
        }
        public string SelectPersonsById()
        {
            return "";
        }
    }
}