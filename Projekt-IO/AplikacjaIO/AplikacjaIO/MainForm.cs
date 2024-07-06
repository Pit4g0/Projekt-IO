using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using AplikacjaIO;
using AplikacjaIO.Klasy;

namespace Projekt_IO_3
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer _timer;
        private TimeSpan _elapsedTime;
        private TimeSpan _totalElapsedTime;
        private DateTime _startTime;
        private bool _isRunning;
        private bool _isPaused;


        public MainForm()
        {
            InitializeComponent();
            _elapsedTime = TimeSpan.Zero;
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // 1 sekunda
            _timer.Tick += Timer_Tick;
            LoadKategorieList();
            this.KategorieList.SelectedIndexChanged += new System.EventHandler(this.KategorieList_SelectedIndexChanged);
            this.ProjektList.SelectedIndexChanged += new System.EventHandler(this.ProjektList_SelectedIndexChanged);
            this.ZadanieList.SelectedIndexChanged += new System.EventHandler(this.ZadanieList_SelectedIndexChanged);
        }
        private void LoadProjektList()
        {
            DataBase dataBase = new DataBase();
            List<string> ProjektNames = dataBase.GetProjekt();
            foreach (string projektName in ProjektNames)
            {
                ListViewItem item = new ListViewItem(projektName);
                CzynnoscList.Items.Add(item);
            }
        }
        private void LoadZadanieList()
        {
            DataBase dataBase = new DataBase();
            List<string> ZadanieNames = dataBase.GetZadanie();
            foreach (string zadanieName in ZadanieNames)
            {
                ListViewItem item = new ListViewItem(zadanieName);
                CzynnoscList.Items.Add(item);
            }
        }
        private void LoadCzynnoscList()
        {
            DataBase dataBase = new DataBase();
            List<string> czynnoscNames = dataBase.GetCzynnosc();
            foreach (string czynnoscName in czynnoscNames)
            {
                ListViewItem item = new ListViewItem(czynnoscName);
                CzynnoscList.Items.Add(item);
            }
        }
        private void LoadKategorieList()
        {
            using (DataBase dataBase = new DataBase())
            {
                List<string> kategorieList = dataBase.GetKategorie();

                KategorieList.Items.Clear();
                foreach (string kategoria in kategorieList)
                {
                    KategorieList.Items.Add(new ListViewItem(kategoria));
                }
            }
        }
        private void LoadCzynnosciByTask(string taskName)
        {
            DataBase dataBase = new DataBase();
            List<string> czynnosci = dataBase.GetCzynnosciByTask(taskName);

            CzynnoscList.Items.Clear();
            foreach (string czynnosc in czynnosci)
            {
                ListViewItem item = new ListViewItem(czynnosc);
                CzynnoscList.Items.Add(item);
            }
        }

        private void LoadProjektyByKategoria(string category)
        {
            DataBase dataBase = new DataBase();
            List<string> projects = dataBase.GetProjektyByKategoria(category);

            ProjektList.Items.Clear();
            foreach (string project in projects)
            {
                ProjektList.Items.Add(project);
            }
        }
        private void LoadZadaniaByProjekt(string projectName)
        {
            DataBase dataBase = new DataBase();
            List<string> tasks = dataBase.GetZadaniaByProjekt(projectName);

            ZadanieList.Items.Clear();
            foreach (string task in tasks)
            {
                ListViewItem item = new ListViewItem(task);
                ZadanieList.Items.Add(item);
            }
        }
        private void UpdateCzasPracyInDatabase(string czynnoscName, TimeSpan elapsedTime)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    // Pobranie aktualnego czasu pracy
                    string selectQuery = "SELECT CzasPracy FROM Czynnosci WHERE NazwaCzynnosci = @NazwaCzynnosci";
                    TimeSpan currentCzasPracy = TimeSpan.Zero;
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection))
                    {
                        selectCommand.Parameters.AddWithValue("@NazwaCzynnosci", czynnoscName);
                        object result = selectCommand.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            currentCzasPracy = (TimeSpan)result;
                        }
                    }

                    // Aktualizacja czasu pracy
                    TimeSpan newCzasPracy = currentCzasPracy + elapsedTime;
                    string updateQuery = "UPDATE Czynnosci SET CzasPracy = @CzasPracy WHERE NazwaCzynnosci = @NazwaCzynnosci";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection))
                    {
                        updateCommand.Parameters.AddWithValue("@CzasPracy", newCzasPracy);
                        updateCommand.Parameters.AddWithValue("@NazwaCzynnosci", czynnoscName);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = DateTime.Now - _startTime;
            Time_txt.Text = _elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void nowyProjektToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void NewProject_menu_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void nowaKategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KategoriaDodajToolStrip_Click(object sender, EventArgs e)
        {
            AddKategoriaForm kategoria = new AddKategoriaForm();
            kategoria.ShowDialog(this);
            LoadKategorieList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KategorieUsunToolStrip_Click(object sender, EventArgs e)
        {
            // Przekazywanie wartości z ListView (KategorieList) do GlobalData.ListValues
            GlobalData.tabela = "Kategoria";
            DataBase dataBase = new DataBase();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = dataBase.GetKategorie();

            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
            LoadKategorieList();
            ProjektList.Items.Clear();
            ZadanieList.Items.Clear();
            CzynnoscList.Items.Clear();
        }

        private void ProjektUsunToolStrip_Click(object sender, EventArgs e)
        {
            // Przekazywanie wartości z ListView (KategorieList) do GlobalData.ListValues
            GlobalData.tabela = "Projekt";
            DataBase dataBase = new DataBase();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = dataBase.GetProjekt();

            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
            LoadProjektList();
            ZadanieList.Items.Clear();
            CzynnoscList.Items.Clear();
        }

        private void ZadanieUsunToolStrip_Click(object sender, EventArgs e)
        {
            GlobalData.tabela = "Zadanie";
            DataBase dataBase = new DataBase();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = dataBase.GetZadanie();

            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
            LoadZadanieList();
            CzynnoscList.Items.Clear(); // Wyczyść CzynnoscList
        }

        private void CzynnoscUsunToolStrip_Click(object sender, EventArgs e)
        {
            GlobalData.tabela = "Czynnosc";
            DataBase dataBase = new DataBase();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = dataBase.GetCzynnosc();


            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
            LoadCzynnoscList();

        }
        private void ProjektDodajToolStrip_Click(object sender, EventArgs e)
        {

            ProjektForm projekt = new ProjektForm();
            projekt.ShowDialog(this);
            LoadProjektList();
        }

        private void ZadanieDodajToolStrip_Click(object sender, EventArgs e)
        {

            ZadanieForm zadanie = new ZadanieForm();
            zadanie.ShowDialog(this);
            LoadZadanieList();
            CzynnoscList.Items.Clear(); // Wyczyść CzynnoscList
        }

        private void CzynnoscDodajToolStrip_Click(object sender, EventArgs e)
        {

            CzynnoscForm czynnosc = new CzynnoscForm();
            czynnosc.ShowDialog(this);

        }

        private void KategorieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KategorieList.SelectedItems.Count > 0)
            {
                string selectedCategory = KategorieList.SelectedItems[0].Text;
                LoadProjektyByKategoria(selectedCategory);
            }
            else
            {
                ZadanieList.Items.Clear();
                CzynnoscList.Items.Clear();
            }
        }

        private void ProjektList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjektList.SelectedItems.Count > 0)
            {
                string selectedProject = ProjektList.SelectedItems[0].Text;
                LoadZadaniaByProjekt(selectedProject);
            }
            else
            {
                CzynnoscList.Items.Clear(); // Wyczyść CzynnoscList
            }
        }

        private void ZadanieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ZadanieList.SelectedItems.Count > 0)
            {
                string selectedTask = ZadanieList.SelectedItems[0].Text;
                LoadCzynnosciByTask(selectedTask);
            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if (CzynnoscList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać czynność przed rozpoczęciem odliczania czasu.");
                return;
            }

            else if (!_isRunning)
            {
                _isRunning = true;
                _isPaused = false;
                _startTime = DateTime.Now;
                _timer.Start();
                // blokuj zaznaczenie z listy
                KategorieList.Enabled = false;
                ProjektList.Enabled = false;
                ZadanieList.Enabled = false;
                CzynnoscList.Enabled = false;
            }
            else if (_isPaused)
            {
                _isPaused = false;
                _startTime = DateTime.Now - _elapsedTime;
                _timer.Start();
                // blokuj zaznaczenie z listy
                KategorieList.Enabled = false;
                ProjektList.Enabled = false;
                ZadanieList.Enabled = false;
                CzynnoscList.Enabled = false;
            }
        }

        private void Stop_btn_Click_1(object sender, EventArgs e)
        {
            if (CzynnoscList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać czynność przed rozpoczęciem odliczania czasu.");
                return;
            }
            else if (_isRunning)
            {
                _timer.Stop();
                _isRunning = false;
                _isPaused = false; // Zresetowanie flagi pauzy
                TimeSpan sessionTime = DateTime.Now - _startTime;
                _elapsedTime = TimeSpan.Zero;
                Time_txt.Text = "00:00:00";
                // blokuj zaznaczenie z listy
                KategorieList.Enabled = true;
                ProjektList.Enabled = true;
                ZadanieList.Enabled = true;
                CzynnoscList.Enabled = true;

                if (CzynnoscList.SelectedItems.Count > 0)
                {
                    string selectedCzynnosc = CzynnoscList.SelectedItems[0].Text;
                    UpdateCzasPracyInDatabase(selectedCzynnosc, sessionTime);
                }
            }
        }

        private void Przerwa_btn_Click_1(object sender, EventArgs e)
        {
            if (CzynnoscList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać czynność przed rozpoczęciem odliczania czasu.");
                return;
            }

            else if (_isRunning && !_isPaused)
            {
                _timer.Stop();
                _isPaused = true;
                _elapsedTime = DateTime.Now - _startTime; // Zapisanie upływającego czasu przy pauzie
            }
        }

        private void CzynnoscList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generujRaportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportForm raport = new RaportForm();
            raport.ShowDialog(this);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
