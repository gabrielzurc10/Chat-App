using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat
{
    public class DataAccess
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ChatDb;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";

        public List<string> getLoginAuthentication(string userName, string password)
        {
            string loginId;
            string loginFirstName;
            string loginLastName;
            string loginUserName;
            string loginPassword;
            
            var loginInfo = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command;
            SqlDataReader datareader;

            string sql = "SELECT Id, FirstName, LastName, UserName, Password FROM Account WHERE UserName=\'" + userName +"\' AND Password=\'"+ password +"\';";

            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                loginId = datareader.GetInt32(0).ToString();
                loginFirstName = datareader.GetString(1);
                loginLastName = datareader.GetString(2);
                loginUserName = datareader.GetString(3);
                loginPassword = datareader.GetString(4);

                loginInfo.Add(loginId);
                loginInfo.Add(loginFirstName);
                loginInfo.Add(loginLastName);
                loginInfo.Add(loginUserName);
                loginInfo.Add(loginPassword);
                
            }
            Thread.Sleep(2000);
            datareader.Close();
            connection.Close();

            return loginInfo;
        }

        public void CreateAccount(string firstName, string lastName, string userName, string password, string email, string phoneNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command;
            SqlDataReader datareader;

            string sql = "INSERT INTO Account(FirstName, LastName, UserName, Password, Email, PhoneNumber) VALUES(\'"+firstName+"\', \'"+lastName+"\', \'"+userName+"\', \'"+password+"\', \'"+email+"\', \'"+phoneNumber+"\');";

            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            Thread.Sleep(2000);
            datareader.Close();
            connection.Close();
        }

        public bool IfDataExist(string data)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(connectionString);  
            DataTable dataTable = new DataTable();
            connection.Open();
            if (result == false)
            {
                string sql = "SELECT UserName FROM Account WHERE UserName = \'" + data + "\';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
                {
                    result = true;
                    Console.WriteLine(result.ToString());
                } else
                {
                    result = false;
                    Console.WriteLine(result.ToString());
                }
            } 
            if (result == false)
            {
                string sql = "SELECT Password FROM Account WHERE Password = \'" + data + "\';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            if (result == false)
            {
                string sql = "SELECT Email FROM Account WHERE Email = \'" + data + "\';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            if (result == false)
            {
                string sql = "SELECT PhoneNumber FROM Account WHERE PhoneNumber = \'" + data + "\';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            connection.Close();
            return result;
        } 

    }
}
