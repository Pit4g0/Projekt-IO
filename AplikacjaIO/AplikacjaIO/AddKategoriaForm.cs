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
    public partial class AddKategoriaForm : Form
    {
        public AddKategoriaForm()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddKategoria_btn_Click(object sender, EventArgs e)
        {
            string kategoriaName = KategorieName_txt.Text;
            if (!string.IsNullOrWhiteSpace(kategoriaName))
            {
                using (DataBase dataBase = new DataBase())
                {
                    dataBase.AddKategorie(kategoriaName);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Nazwa kategorii nie może być pusta.");
            }

        }
    }
}
