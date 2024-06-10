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
        }
       
        private void AddData_btn_Click(object sender, EventArgs e)
        {
           
            string projectName = NewData_tb.Text;
            string table = "Projekty";
            //DataBase dataBase = new DataBase();
            //dataBase.AddToDataBase(projectName, table);

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewData_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
