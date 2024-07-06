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
    public partial class CzynnoscForm : Form
    {
        public CzynnoscForm()
        {
            InitializeComponent();
            LoadListValues();
        }

        private void LoadListValues()
        {
            try
            {
                DataBase dataBase = new DataBase();
                List<string> zadaniaList = dataBase.GetZadanie();

                // Wypełnij ComboBox danymi z listy
                zadaniaList_comboBox.Items.Clear();
                foreach (string zadanie in zadaniaList)
                {
                    zadaniaList_comboBox.Items.Add(zadanie);
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

        private void AddZadanie_btn_Click(object sender, EventArgs e)
        {
            string czynnoscName = CzynnoscNazwa.Text; // Tekst z pola tekstowego
            string zadanieName = zadaniaList_comboBox.SelectedItem.ToString(); // Wybrana wartość z ComboBox
            string table = "Czynnosci"; // Nazwa tabeli
            int czas = 0;

            DataBase dataBase = new DataBase();
            dataBase.AddCzynnosc(czynnoscName, zadanieName, czas, table);
        }

        private void zadaniaList_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
