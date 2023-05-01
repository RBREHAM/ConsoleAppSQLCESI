using System.Data.SqlClient;

namespace SQLWork;
class Program
{
    static void Main(string[] args)
    {

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = @"Data Source = ISIITECH69\SQLEXPRESS; Initial Catalog = booksdb; Integrated Security = True";
        connection.Open();

        string query = "Select * FROM Books";
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader["id"] + " " + reader["Title"] + " " + reader["Year"] + " " + reader["Category"]);
        }

        reader.Close();
        connection.Close();
    }

}