using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AplikacjaIO.Klasy
{
    public class DataBase : IDisposable
    {
        private SqlConnection _sqlConnection;
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

        public List<string> GetAllNames()
        {
            List<string> projectNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaProjektu FROM Projekty";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectNames.Add(reader["NazwaProjektu"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }

            return projectNames;
        }

        //konstruktor
        public DataBase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _sqlConnection = new SqlConnection(connectionString);
        }
        //Usuwa obiekty klas kiedy już nie są potrzebne (na razie pusto)
        public void Dispose()
        {
        }

    }
}