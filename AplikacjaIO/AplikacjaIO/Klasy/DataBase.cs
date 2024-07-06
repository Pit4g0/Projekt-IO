using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AplikacjaIO.Klasy
{
    public class DataBase : IDisposable
    {
        private SqlConnection _sqlConnection;

        public class ProjektRaport
        {
            public string NazwaProjektu { get; set; }
            public DateTime DataUtworzenia { get; set; }
            public string PrzypisanieDoKategorii { get; set; }
            public TimeSpan CzasPracy { get; set; }
        }
        public class ZadanieRaport
        {
            public string NazwaZadania { get; set; }
            public DateTime DataUtworzenia { get; set; }
            public string NadrzednyProjekt { get; set; }
            public TimeSpan CzasPracy { get; set; }
        }
        public class CzynnoscRaport
        {
            public string NazwaCzynnosci { get; set; }
            public DateTime DataUtworzenia { get; set; }
            public string NadrzedneZadanie { get; set; }
            public TimeSpan CzasPracy { get; set; }
        }
        public class KategoriaRaport
        {
            public string NazwaKategorii { get; set; }
            public TimeSpan CzasPracy { get; set; }
        }
        public void AddProjekt(string projectName, string categoryName, string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = $"INSERT INTO {table} (NazwaProjektu, PrzypisanieDoKategorii, DataUtworzenia, CzyArchiwa) VALUES (@NazwaProjektu, @PrzypisanieDoKategorii, @DataUtworzenia, 0)";

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

        public List<ProjektRaport> GetProjektRaport()
        {
            List<ProjektRaport> projektyRaport = new List<ProjektRaport>();

            try
            {
                _sqlConnection.Open();
                string query = @"
            SELECT p.NazwaProjektu, p.DataUtworzenia, p.PrzypisanieDoKategorii, 
                   ISNULL(SUM(DATEDIFF(SECOND, '00:00:00', c.CzasPracy)), 0) AS CzasPracySekundy
            FROM Projekty p
            LEFT JOIN Zadania z ON p.NazwaProjektu = z.NadrzednyProjekt
            LEFT JOIN Czynnosci c ON z.NazwaZadania = c.NadrzedneZadanie
            GROUP BY p.NazwaProjektu, p.DataUtworzenia, p.PrzypisanieDoKategorii";

                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int czasPracySekundy = Convert.ToInt32(reader["CzasPracySekundy"]);
                            projektyRaport.Add(new ProjektRaport
                            {
                                NazwaProjektu = reader["NazwaProjektu"].ToString(),
                                DataUtworzenia = Convert.ToDateTime(reader["DataUtworzenia"]),
                                PrzypisanieDoKategorii = reader["PrzypisanieDoKategorii"].ToString(),
                                CzasPracy = TimeSpan.FromSeconds(czasPracySekundy)
                            });
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

            return projektyRaport;
        }
        public List<string> GetProjekt()
        {
            List<string> projectNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaProjektu FROM Projekty WHERE CzyArchiwa=0";
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
        public List<string> GetProjektyByKategoria(string kategoria)
        {
            List<string> projectNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaProjektu FROM Projekty WHERE PrzypisanieDoKategorii = @Category AND CzyArchiwa = 0";
                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Category", kategoria);

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
                    string query = $"INSERT INTO {table} (NazwaZadania, DataUtworzenia, NadrzednyProjekt, CzyArchiwa) VALUES (@NazwaZadania, @DataUtworzenia, @NadrzednyProjekt, 0)";

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
        public List<ZadanieRaport> GetZadaniaRaport()
        {
            List<ZadanieRaport> zadaniaRaport = new List<ZadanieRaport>();

            try
            {
                _sqlConnection.Open();
                string query = @"
            SELECT z.NazwaZadania, z.DataUtworzenia, z.NadrzednyProjekt, 
                   ISNULL(SUM(DATEDIFF(SECOND, '00:00:00', c.CzasPracy)), 0) AS CzasPracySekundy
            FROM Zadania z
            LEFT JOIN Czynnosci c ON z.NazwaZadania = c.NadrzedneZadanie
            GROUP BY z.NazwaZadania, z.DataUtworzenia, z.NadrzednyProjekt";

                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int czasPracySekundy = Convert.ToInt32(reader["CzasPracySekundy"]);
                            zadaniaRaport.Add(new ZadanieRaport
                            {
                                NazwaZadania = reader["NazwaZadania"].ToString(),
                                DataUtworzenia = Convert.ToDateTime(reader["DataUtworzenia"]),
                                NadrzednyProjekt = reader["NadrzednyProjekt"].ToString(),
                                CzasPracy = TimeSpan.FromSeconds(czasPracySekundy)
                            });
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

            return zadaniaRaport;
        }
        public List<string> GetZadanie()
        {
            List<string> zadanieNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaZadania FROM Zadania WHERE CzyArchiwa=0";
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
        public List<string> GetZadaniaByProjekt(string projectName)
        {
            List<string> tasks = new List<string>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string query = "SELECT NazwaZadania FROM Zadania WHERE NadrzednyProjekt = @Projekt AND CzyArchiwa = 0";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Projekt", projectName);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tasks.Add(reader["NazwaZadania"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }

            return tasks;
        }
        public void AddCzynnosc(string czynnoscName, string zadanieName, int czas, string table)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = $"INSERT INTO {table} (NazwaCzynnosci, DataUtworzenia, NadrzedneZadanie, CzyArchiwa, CzasPracy) " +
                                                $"VALUES (@NazwaCzynnosci, @DataUtworzenia, @NadrzedneZadanie, 0, @CzasPracy)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@NazwaCzynnosci", czynnoscName);
                        sqlCommand.Parameters.AddWithValue("@DataUtworzenia", DateTime.Now); // Dodanie bieżącej daty i czasu
                        sqlCommand.Parameters.AddWithValue("@NadrzedneZadanie", zadanieName);
                        sqlCommand.Parameters.AddWithValue("@CzasPracy", "00:00:00");


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
        public List<CzynnoscRaport> GetCzynnosciRaport()
        {
            List<CzynnoscRaport> czynnosciRaport = new List<CzynnoscRaport>();

            try
            {
                _sqlConnection.Open();
                string query = @"
            SELECT NazwaCzynnosci, DataUtworzenia, NadrzedneZadanie, 
                   ISNULL(DATEDIFF(SECOND, '00:00:00', CzasPracy), 0) AS CzasPracySekundy
            FROM Czynnosci";

                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int czasPracySekundy = Convert.ToInt32(reader["CzasPracySekundy"]);
                            czynnosciRaport.Add(new CzynnoscRaport
                            {
                                NazwaCzynnosci = reader["NazwaCzynnosci"].ToString(),
                                DataUtworzenia = Convert.ToDateTime(reader["DataUtworzenia"]),
                                NadrzedneZadanie = reader["NadrzedneZadanie"].ToString(),
                                CzasPracy = TimeSpan.FromSeconds(czasPracySekundy)
                            });
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

            return czynnosciRaport;
        }
        public List<string> GetCzynnosc()
        {
            List<string> czynnoscNames = new List<string>();

            try
            {
                _sqlConnection.Open();
                string query = "SELECT NazwaCzynnosci FROM Czynnosci WHERE CzyArchiwa=0";
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
        public List<string> GetCzynnosciByTask(string taskName)
        {
            List<string> czynnosci = new List<string>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string query = "SELECT NazwaCzynnosci FROM Czynnosci WHERE NadrzedneZadanie = @Zadanie AND CzyArchiwa = 0";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Zadanie", taskName);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                czynnosci.Add(reader["NazwaCzynnosci"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }

            return czynnosci;
        }
        public void AddKategorie(string kategoriaName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "INSERT INTO Kategorie (NazwaKategorii, CzyArchiwa) VALUES (@NazwaKategorii, 0)";

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
        public List<KategoriaRaport> GetKategorieRaport()
        {
            List<KategoriaRaport> kategorieRaport = new List<KategoriaRaport>();

            try
            {
                _sqlConnection.Open();
                string query = @"
            SELECT K.NazwaKategorii, ISNULL(SUM(DATEDIFF(SECOND, '00:00:00', C.CzasPracy)), 0) AS CzasPracySekundy
            FROM Kategorie K
            LEFT JOIN Projekty P ON K.NazwaKategorii = P.PrzypisanieDoKategorii
            LEFT JOIN Zadania Z ON P.NazwaProjektu = Z.NadrzednyProjekt
            LEFT JOIN Czynnosci C ON Z.NazwaZadania = C.NadrzedneZadanie
            GROUP BY K.NazwaKategorii";

                using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int czasPracySekundy = Convert.ToInt32(reader["CzasPracySekundy"]);
                            kategorieRaport.Add(new KategoriaRaport
                            {
                                NazwaKategorii = reader["NazwaKategorii"].ToString(),
                                CzasPracy = TimeSpan.FromSeconds(czasPracySekundy)
                            });
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

            return kategorieRaport;
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
                    string query = "SELECT NazwaKategorii FROM Kategorie WHERE CzyArchiwa = 0";

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

        //archiwa
        public void KategoriaToArchiwa(string nazwaKategorii)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    // Aktualizacja tabeli Kategorie
                    string queryKategorie = "UPDATE Kategorie SET CzyArchiwa = 1 WHERE NazwaKategorii = @NazwaKategorii";
                    using (SqlCommand sqlCommandKategorie = new SqlCommand(queryKategorie, sqlConnection))
                    {
                        sqlCommandKategorie.Parameters.AddWithValue("@NazwaKategorii", nazwaKategorii);
                        int rowsAffectedKategorie = sqlCommandKategorie.ExecuteNonQuery();

                        if (rowsAffectedKategorie > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Kategorie' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedKategorie}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Kategorie'.");
                        }
                    }

                    // Aktualizacja tabeli Projekty
                    string queryProjekty = "UPDATE Projekty SET CzyArchiwa = 1 WHERE PrzypisanieDoKategorii = @NazwaKategorii";
                    using (SqlCommand sqlCommandProjekty = new SqlCommand(queryProjekty, sqlConnection))
                    {
                        sqlCommandProjekty.Parameters.AddWithValue("@NazwaKategorii", nazwaKategorii);
                        int rowsAffectedProjekty = sqlCommandProjekty.ExecuteNonQuery();

                        if (rowsAffectedProjekty > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Projekty' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedProjekty}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Projekty'.");
                        }
                    }

                    // Aktualizacja tabeli Zadania
                    string queryZadania = "UPDATE Zadania SET CzyArchiwa = 1 WHERE NadrzednyProjekt IN (SELECT NazwaProjektu FROM Projekty WHERE PrzypisanieDoKategorii = @NazwaKategorii)";
                    using (SqlCommand sqlCommandZadania = new SqlCommand(queryZadania, sqlConnection))
                    {
                        sqlCommandZadania.Parameters.AddWithValue("@NazwaKategorii", nazwaKategorii);
                        int rowsAffectedZadania = sqlCommandZadania.ExecuteNonQuery();

                        if (rowsAffectedZadania > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Zadania' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedZadania}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Zadania'.");
                        }
                    }

                    // Aktualizacja tabeli Czynnosci
                    string queryCzynnosci = "UPDATE Czynnosci SET CzyArchiwa = 1 WHERE NadrzedneZadanie IN (SELECT NazwaZadania FROM Zadania WHERE NadrzednyProjekt IN (SELECT NazwaProjektu FROM Projekty WHERE PrzypisanieDoKategorii = @NazwaKategorii))";
                    using (SqlCommand sqlCommandCzynnosci = new SqlCommand(queryCzynnosci, sqlConnection))
                    {
                        sqlCommandCzynnosci.Parameters.AddWithValue("@NazwaKategorii", nazwaKategorii);
                        int rowsAffectedCzynnosci = sqlCommandCzynnosci.ExecuteNonQuery();

                        if (rowsAffectedCzynnosci > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Czynnosci' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedCzynnosci}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Czynnosci'.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public void ProjektToArchiwa(string nazwaProjektu)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    // Aktualizacja tabeli Projekty
                    string queryProjekty = "UPDATE Projekty SET CzyArchiwa = 1 WHERE NazwaProjektu = @NazwaProjektu";
                    using (SqlCommand sqlCommandProjekty = new SqlCommand(queryProjekty, sqlConnection))
                    {
                        sqlCommandProjekty.Parameters.AddWithValue("@NazwaProjektu", nazwaProjektu);
                        int rowsAffectedProjekty = sqlCommandProjekty.ExecuteNonQuery();

                        // Dodaj debugowanie do sprawdzenia, czy zapytanie aktualizuje wiersze
                        if (rowsAffectedProjekty > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Projekty' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedProjekty}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Projekty'.");
                        }
                    }

                    // Aktualizacja tabeli Zadania
                    string queryZadania = "UPDATE Zadania SET CzyArchiwa = 1 WHERE NadrzednyProjekt = @NazwaProjektu";
                    using (SqlCommand sqlCommandZadania = new SqlCommand(queryZadania, sqlConnection))
                    {
                        sqlCommandZadania.Parameters.AddWithValue("@NazwaProjektu", nazwaProjektu);
                        int rowsAffectedZadania = sqlCommandZadania.ExecuteNonQuery();

                        // Dodaj debugowanie do sprawdzenia, czy zapytanie aktualizuje wiersze
                        if (rowsAffectedZadania > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Zadania' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedZadania}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Zadania'.");
                        }
                    }

                    // Aktualizacja tabeli Czynnosci
                    string queryCzynnosci = "UPDATE Czynnosci SET CzyArchiwa = 1 WHERE NadrzedneZadanie IN (SELECT NazwaZadania FROM Zadania WHERE NadrzednyProjekt = @NazwaProjektu)";
                    using (SqlCommand sqlCommandCzynnosci = new SqlCommand(queryCzynnosci, sqlConnection))
                    {
                        sqlCommandCzynnosci.Parameters.AddWithValue("@NazwaProjektu", nazwaProjektu);
                        int rowsAffectedCzynnosci = sqlCommandCzynnosci.ExecuteNonQuery();

                        // Dodaj debugowanie do sprawdzenia, czy zapytanie aktualizuje wiersze
                        if (rowsAffectedCzynnosci > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Czynnosci' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedCzynnosci}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Czynnosci'.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public void ZadanieToArchiwa(string nazwaZadania)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    // Aktualizacja tabeli Zadania
                    string queryZadania = "UPDATE Zadania SET CzyArchiwa = 1 WHERE NazwaZadania = @NazwaZadania";
                    using (SqlCommand sqlCommandZadania = new SqlCommand(queryZadania, sqlConnection))
                    {
                        sqlCommandZadania.Parameters.AddWithValue("@NazwaZadania", nazwaZadania);
                        int rowsAffectedZadania = sqlCommandZadania.ExecuteNonQuery();

                        // Dodaj debugowanie do sprawdzenia, czy zapytanie aktualizuje wiersze
                        if (rowsAffectedZadania > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Zadania' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedZadania}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Zadania'.");
                        }
                    }

                    // Aktualizacja tabeli Czynnosci
                    string queryCzynnosci = "UPDATE Czynnosci SET CzyArchiwa = 1 WHERE NadrzedneZadanie = @NazwaZadania";
                    using (SqlCommand sqlCommandCzynnosci = new SqlCommand(queryCzynnosci, sqlConnection))
                    {
                        sqlCommandCzynnosci.Parameters.AddWithValue("@NazwaZadania", nazwaZadania);
                        int rowsAffectedCzynnosci = sqlCommandCzynnosci.ExecuteNonQuery();

                        // Dodaj debugowanie do sprawdzenia, czy zapytanie aktualizuje wiersze
                        if (rowsAffectedCzynnosci > 0)
                        {
                            MessageBox.Show($"Dane w tabeli 'Czynnosci' zaktualizowano poprawnie, wiersze zmienione: {rowsAffectedCzynnosci}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania w tabeli 'Czynnosci'.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        public void CzynnoscToArchiwa(string nazwaCzynnosci)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "UPDATE Czynnosci SET CzyArchiwa = 1 WHERE NazwaCzynnosci = @NazwaCzynnosci";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@NazwaCzynnosci", nazwaCzynnosci);
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        // Dodaj debugowanie do sprawdzenia, czy zapytanie aktualizuje wiersze
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Dane zaktualizowano poprawnie, wiersze zmienione: {rowsAffected}");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono żadnych wierszy do zaktualizowania.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
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