using AplikacjaIO;
using AplikacjaIO.Klasy;

namespace Projekt_IO_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadProjectNames();
        }

        private void LoadProjectNames()
        {
            DataBase dataBase = new DataBase();
            
                List<string> projectNames = dataBase.GetAllNames();

                foreach (string projectName in projectNames)
                {
                    ListViewItem item = new ListViewItem(projectName);
                    // Jeœli masz inne kolumny do wype³nienia, u¿yj item.SubItems.Add
                    ProjectList.Items.Add(item);
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
            DataForm dataForm = new DataForm();
            dataForm.ShowDialog(this);
        }
    }
}
