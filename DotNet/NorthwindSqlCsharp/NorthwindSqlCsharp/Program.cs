using System.Data.SqlClient;
using System.Security.Cryptography;

string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";

// establish connection to the database
SqlConnection conn = new();
conn.Open();

// SQL command 
string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
SqlCommand cmd = conn.CreateCommand();

SqlDataReader reader = cmd.ExecuteReader();
while  (reader.Read())
{
    // find the compnay name and store it in companyName variable
    // 
    string companyName = reader["CompanyName"].ToString() ?? "";  
    Console.WriteLine(companyName);
}

// closing the connection to the database
conn.Close();