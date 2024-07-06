using AplikacjaIO.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaIO
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            LoadListValues();
        }

        private void LoadListValues()
        {
            if (GlobalData.ListValues != null)
            {
                Erase_comboBox.Items.AddRange(GlobalData.ListValues.ToArray());
            }
        }
        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }


        private void Erase_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Erase_btn_Click(object sender, EventArgs e)
        {
            string selectedKategoria = Erase_comboBox.SelectedItem.ToString();
            switch (GlobalData.tabela)
            {
                case "Kategoria":   
                    if (Erase_comboBox.SelectedItem != null)
                    {
                     DataBase dataBase = new DataBase();
                     dataBase.KategoriaToArchiwa(selectedKategoria);
                    }
                    else
                    {
                        MessageBox.Show("Proszę wybrać kategorię do usunięcia.");
                    }
                break;
                case "Projekt":
                    if (Erase_comboBox.SelectedItem != null)
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.ProjektToArchiwa(selectedKategoria);
                    }
                    else
                    {
                        MessageBox.Show("Proszę wybrać projekt do usunięcia.");
                    }
                    break;
                case "Zadanie":
                    if (Erase_comboBox.SelectedItem != null)
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.ZadanieToArchiwa(selectedKategoria);
                    }
                    else
                    {
                        MessageBox.Show("Proszę wybrać zadanie do usunięcia.");
                    }
                    break;
                case "Czynnosc":
                    if (Erase_comboBox.SelectedItem != null)
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.CzynnoscToArchiwa(selectedKategoria);
                    }
                    else
                    {
                        MessageBox.Show("Proszę wybrać czynnosc do usunięcia.");
                    }
                    break;
            }
                
         
           }
    }
}
