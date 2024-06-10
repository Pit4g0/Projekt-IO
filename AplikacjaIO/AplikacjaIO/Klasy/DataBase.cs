using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AplikacjaIO.Klasy
{
    public class DataBase
    {
        public void AddToDataBase(string projectName, string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = $"INSERT INTO {table} (NazwaProjektu) VALUES (@NazwaProjektu)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@NazwaProjektu", projectName);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} wiersz(y) zostało wstawionych");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
    }
}