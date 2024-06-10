namespace AplikacjaIO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Project_btn_Click(object sender, EventArgs e)
        {
            DataForm dataForm = new DataForm();
            dataForm.ShowDialog();
        }
    }
}
