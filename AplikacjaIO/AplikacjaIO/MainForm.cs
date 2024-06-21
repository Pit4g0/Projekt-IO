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
            //LoadProjectNames();
        }

        //private void LoadProjectNames()
        //{
        //    DataBase dataBase = new DataBase();
        //    List<string> projectNames = dataBase.GetAllNames();
        //    foreach (string projectName in projectNames)
        //    {
        //        ListViewItem item = new ListViewItem(projectName);
        //        // Jeśli masz inne kolumny do wypełnienia, użyj item.SubItems.Add
        //        ProjectList.Items.Add(item);
        //    }         
        //}

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
            //DataForm dataForm = new DataForm();
            //dataForm.ShowDialog(this);
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
    }
}
