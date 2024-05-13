using UnityEngine;
using TMPro;
using System.Data;
using Mono.Data.Sqlite;

public class DatabaseManager : MonoBehaviour
{
    private string connectionString;
    private IDbConnection dbConnection;

    public TextMeshProUGUI DBText;

    private void Start()
    {
        // Define the connection string to your SQLite database located at D:\Database\DBTest.db
        connectionString = "URI=file:D:/Database/DBTest.db"; // Use forward slashes (/) in the path

        // Create a new database connection
        dbConnection = new SqliteConnection(connectionString);
        dbConnection.Open();

        // Query the database and display data in TextMeshPro
        string query = "SELECT link FROM agency_info WHERE id = 1";
        IDbCommand dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = query;
        IDataReader reader = dbCommand.ExecuteReader();

        if (reader.Read())
        {
            string link = reader.GetString(0); // Assuming 'name' is a column in your table
            DBText.text = "Link: " + link;
        }

        // Close the database connection when you're done
        dbConnection.Close();
    }
}
