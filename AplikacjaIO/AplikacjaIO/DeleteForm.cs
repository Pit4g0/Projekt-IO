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

        }
    }
}
