using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AplikacjaIO;
using AplikacjaIO.Klasy;

namespace Projekt_IO_3
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer _timer;
        private TimeSpan _elapsedTime;
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
<<<<<<< Updated upstream
            LoadProjectList();
            LoadKategorieList();
            LoadZadanieList();
            LoadCzynnoscList();
        }

        private void LoadProjectList()
        {
            DataBase dataBase = new DataBase();
            List<string> projectNames = dataBase.GetProjekt();
            foreach (string projectName in projectNames)
            {
                ListViewItem item = new ListViewItem(projectName);
                ProjektList.Items.Add(item);
            }
        }
        private void LoadZadanieList()
        {
            DataBase dataBase = new DataBase();
            List<string> zadanieNames = dataBase.GetZadanie();
            foreach (string zadanieName in zadanieNames)
            {
                ListViewItem item = new ListViewItem(zadanieName);
                ZadanieList.Items.Add(item);
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
=======
            LoadKategorieList();
            //LoadZadanieList();
            LoadCzynnoscList();
            this.KategorieList.SelectedIndexChanged += new System.EventHandler(this.KategorieList_SelectedIndexChanged);
            this.ProjektList.SelectedIndexChanged += new System.EventHandler(this.ProjektList_SelectedIndexChanged);
            this.ZadanieList.SelectedIndexChanged += new System.EventHandler(this.ZadanieList_SelectedIndexChanged);
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
>>>>>>> Stashed changes

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

        private void Start_btn_Click_1(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = true;
                _isPaused = false;
                _startTime = DateTime.Now;
                _timer.Start();
            }
            else if (_isPaused)
            {
                _isPaused = false;
                _startTime = DateTime.Now - _elapsedTime;
                _timer.Start();
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = DateTime.Now - _startTime;
            textBox1.Text = _elapsedTime.ToString(@"hh\:mm\:ss");
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


        private void Stop_btn_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _timer.Stop();
                _isRunning = false;
                _isPaused = false; // Zresetowanie flagi pauzy
                _elapsedTime = TimeSpan.Zero;
                textBox1.Text = "00:00:00";
            }
        }

        private void Przerwa_btn_Click(object sender, EventArgs e)
        {
            if (_isRunning && !_isPaused)
            {
                _timer.Stop();
                _isPaused = true;
                _elapsedTime = DateTime.Now - _startTime; // Zapisanie upływającego czasu przy pauzie
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void nowaKategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KategoriaDodajToolStrip_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
          
=======

>>>>>>> Stashed changes
            LoadKategorieList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KategorieUsunToolStrip_Click(object sender, EventArgs e)
        {
            // Przekazywanie wartości z ListView (KategorieList) do GlobalData.ListValues
<<<<<<< Updated upstream
          
=======

>>>>>>> Stashed changes
            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
        }

        private void ProjektUsunToolStrip_Click(object sender, EventArgs e)
        {
            // Przekazywanie wartości z ListView (KategorieList) do GlobalData.ListValues
            DataBase dataBase = new DataBase();
            List<string> projektList = dataBase.GetProjekt();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = projektList;

            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
        }

        private void ZadanieUsunToolStrip_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            List<string> zadanieList = dataBase.GetZadanie();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = zadanieList;

            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);
        }

        private void CzynnoscUsunToolStrip_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            
                DataBase dataBase = new DataBase();
                List<string> czynnosciList = dataBase.GetCzynnosc();

                // Przypisz wartości do GlobalData.ListValues
                GlobalData.ListValues = czynnosciList;


                DeleteForm delete = new DeleteForm();
                delete.ShowDialog(this);
            
        }
        private void ProjektDodajToolStrip_Click(object sender, EventArgs e)
        {
          
            ProjektForm projekt = new ProjektForm();
            projekt.ShowDialog(this);
            LoadProjectList();
=======

            DataBase dataBase = new DataBase();
            List<string> czynnosciList = dataBase.GetCzynnosc();

            // Przypisz wartości do GlobalData.ListValues
            GlobalData.ListValues = czynnosciList;


            DeleteForm delete = new DeleteForm();
            delete.ShowDialog(this);

        }
        private void ProjektDodajToolStrip_Click(object sender, EventArgs e)
        {

            ProjektForm projekt = new ProjektForm();
            projekt.ShowDialog(this);
            //LoadProjectList();
>>>>>>> Stashed changes
        }

        private void ZadanieDodajToolStrip_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
          
            ZadanieForm zadanie = new ZadanieForm();
            zadanie.ShowDialog(this);
            LoadZadanieList();
=======

            ZadanieForm zadanie = new ZadanieForm();
            zadanie.ShowDialog(this);
>>>>>>> Stashed changes
        }

        private void CzynnoscDodajToolStrip_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
          
            CzynnoscForm czynnosc = new CzynnoscForm();
            czynnosc.ShowDialog(this);
           
=======

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
        }

        private void ZadanieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ZadanieList.SelectedItems.Count > 0)
            {
                string selectedTask = ZadanieList.SelectedItems[0].Text;
                LoadCzynnosciByTask(selectedTask);
            }
>>>>>>> Stashed changes
        }
    }
}
