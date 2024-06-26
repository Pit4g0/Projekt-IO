using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//załączanie plików klas
using AplikacjaIO.Klasy;

namespace AplikacjaIO
{

    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            LoadProjectNames();
        }

        private void LoadProjectNames()
        {
            if (GlobalData.ListValues != null)
            {
                Projekty_comboBox.Items.AddRange(GlobalData.ListValues.ToArray());
            }
        }

        private void AddData_btn_Click(object sender, EventArgs e)
        {

            string projectName = NewData_tb.Text;
            string table = "Projekty";

            //"using" tworzy obiekt i usuwa go od razu po wykonaniu klamer
            using (DataBase dataBase = new DataBase())
            {
                dataBase.AddProject(projectName, table);
            }

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewData_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Projekty_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
