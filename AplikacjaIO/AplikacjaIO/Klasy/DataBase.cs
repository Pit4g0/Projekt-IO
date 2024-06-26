using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AplikacjaIO.Klasy
{
    public class DataBase : IDisposable
    {
        private SqlConnection _sqlConnection;


        public void AddProjekt(string projectName, string categoryName, string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = $"INSERT INTO {table} (NazwaProjektu, PrzypisanieDoKategorii, DataUtworzenia) VALUES (@NazwaProjektu, @PrzypisanieDoKategorii, @DataUtworzenia)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@NazwaProjektu", projectName);
                        sqlCommand.Parameters.AddWithValue("@PrzypisanieDoKategorii", categoryName);
                        sqlCommand.Parameters.AddWithValue("@DataUtworzenia", DateTime.Now); // Dodanie bieżącej daty i czasu

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Dane wstawiono poprawnie");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public List<string> GetProjekt()
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
        public void AddZadanie(string zadanieName, string projectName, string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = $"INSERT INTO {table} (NazwaZadania, DataUtworzenia, NadrzednyProjekt) VALUES (@NazwaZadania, @DataUtworzenia, @NadrzednyProjekt)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                       sqlCommand.Parameters.AddWithValue("@NazwaZadania", zadanieName);
                       sqlCommand.Parameters.AddWithValue("@DataUtworzenia", DateTime.Now); // Dodanie bieżącej daty i czasu
                       sqlCommand.Parameters.AddWithValue("@NadrzednyProjekt", projectName);
                        

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Dane wstawiono poprawnie");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public List<string> GetZadanie()
        {
            List<string> zadanieNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaZadania FROM Zadania";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            zadanieNames.Add(reader["NazwaZadania"].ToString());
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
            return zadanieNames;
        }
        public void AddCzynnosc(string czynnoscName, string zadanieName, int czas, string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = $"INSERT INTO {table} (NazwaCzynnosci, DataUtworzenia, NadrzedneZadanie, CzasPracy) " +
                                                $"VALUES (@NazwaCzynnosci, @DataUtworzenia, @NadrzedneZadanie, @CzasPracy)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@NazwaCzynnosci", czynnoscName);
                        sqlCommand.Parameters.AddWithValue("@DataUtworzenia", DateTime.Now); // Dodanie bieżącej daty i czasu
                        sqlCommand.Parameters.AddWithValue("@NadrzedneZadanie", zadanieName);
                        sqlCommand.Parameters.AddWithValue("@CzasPracy", czas);


                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Dane wstawiono poprawnie");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public List<string> GetCzynnosc()
        {
            List<string> czynnoscNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaCzynnosci FROM Czynnosci";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            czynnoscNames.Add(reader["NazwaCzynnosci"].ToString());
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
            return czynnoscNames;
        } 
        public void AddKategorie(string kategoriaName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "INSERT INTO Kategorie (NazwaKategorii) VALUES (@NazwaKategorii)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@NazwaKategorii", kategoriaName);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        MessageBox.Show($"dane wstawiono poprawnie");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public List<string> GetKategorie()
        {
            List<string> kategorieList = new List<string>();
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT NazwaKategorii FROM Kategorie";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kategorieList.Add(reader["NazwaKategorii"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }

            return kategorieList;
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