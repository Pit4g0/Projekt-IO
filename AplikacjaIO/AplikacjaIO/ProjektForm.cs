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

    public partial class ProjektForm : Form
    {
        public ProjektForm()
        {
            InitializeComponent();
            LoadListValues();
        }

        private void LoadListValues()
        {
            try
            {
                DataBase dataBase = new DataBase();
                List<string> zadaniaList = dataBase.GetKategorie();

                // Wypełnij ComboBox danymi z listy
                KategorieList_comboBox.Items.Clear();
                foreach (string zadanie in zadaniaList)
                {
                    KategorieList_comboBox.Items.Add(zadanie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy zadań: " + ex.Message);
            }
        }
        private void AddData_btn_Click(object sender, EventArgs e)
        {

            string projectName = ProjektNazwa_tb.Text; // Tekst z pola tekstowego
            string categoryName = KategorieList_comboBox.SelectedItem.ToString(); // Wybrana wartość z ComboBox
            string table = "Projekty"; // Nazwa tabeli

            DataBase dataBase = new DataBase();
            dataBase.AddProjekt(projectName, categoryName, table);

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
