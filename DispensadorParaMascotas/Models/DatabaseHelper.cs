using System;
using System.Data;
using Microsoft.Data.SqlClient; // Asegúrate de instalar este paquete vía NuGet
using System.Configuration;

public class DatabaseHelper
{
    private string _connectionString = ConfigurationManager.ConnectionStrings["CnnSmartPet"]!.ConnectionString;

    // Método para ejecutar consultas que devuelven datos (SELECT)
    public DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null) command.Parameters.AddRange(parameters);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
        }
    }

    // Método para insertar, actualizar o borrar (INSERT, UPDATE, DELETE)
    public int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null) command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}