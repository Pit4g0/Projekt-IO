using AplikacjaIO.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaIO
{
    public partial class ZadanieForm : Form
    {
        public ZadanieForm()
        {
            InitializeComponent();
            LoadListValues();
        }
        private void LoadListValues()
        {
            try
            {
                DataBase dataBase = new DataBase();
                List<string> zadaniaList = dataBase.GetProjekt();

                // Wypełnij ComboBox danymi z listy
               ProjektList_comboBox.Items.Clear();
                foreach (string zadanie in zadaniaList)
                {
                    ProjektList_comboBox.Items.Add(zadanie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy zadań: " + ex.Message);
            }
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddZadanie_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddZadanie_btn_Click(object sender, EventArgs e)
        {
            string zadanieName = ZadanieNazwa.Text; // Tekst z pola tekstowego
            string projectName = ProjektList_comboBox.SelectedItem.ToString(); // Wybrana wartość z ComboBox
            string table = "Zadania"; // Nazwa tabeli

            DataBase dataBase = new DataBase();
            dataBase.AddZadanie(zadanieName, projectName, table);
        }
    }
}
