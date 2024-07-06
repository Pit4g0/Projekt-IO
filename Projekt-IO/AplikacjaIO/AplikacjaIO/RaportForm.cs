using AplikacjaIO.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplikacjaIO.Klasy.DataBase;

namespace AplikacjaIO
{
    public partial class RaportForm : Form
    {
        public RaportForm()
        {
            InitializeComponent();
            LoadKategorieRaportList();
            LoadProjektyRaportList();
            LoadZadaniaRaportList();
            LoadCzynnosciRaportList();
        }
        private void LoadKategorieRaportList()
        {
            DataBase dataBase = new DataBase();
            List<KategoriaRaport> kategorieRaport = dataBase.GetKategorieRaport();
            foreach (KategoriaRaport raport in kategorieRaport)
            {
                ListViewItem item = new ListViewItem(raport.NazwaKategorii);
                item.SubItems.Add(raport.CzasPracy.ToString());
                KategorieRaportList.Items.Add(item);
            }
        }
        private void LoadProjektyRaportList()
        {
            DataBase dataBase = new DataBase();
            List<ProjektRaport> projektyRaport = dataBase.GetProjektRaport();
            foreach (ProjektRaport raport in projektyRaport)
            {
                ListViewItem item = new ListViewItem(raport.NazwaProjektu);
                item.SubItems.Add(raport.DataUtworzenia.ToString("yyyy-MM-dd"));
                item.SubItems.Add(raport.PrzypisanieDoKategorii);
                item.SubItems.Add(raport.CzasPracy.ToString());
                ProjektyRaportList.Items.Add(item);
            }
        }
        private void LoadZadaniaRaportList()
        {
            DataBase dataBase = new DataBase();
            List<ZadanieRaport> zadaniaRaport = dataBase.GetZadaniaRaport();
            foreach (ZadanieRaport raport in zadaniaRaport)
            {
                ListViewItem item = new ListViewItem(raport.NazwaZadania);
                item.SubItems.Add(raport.DataUtworzenia.ToString("yyyy-MM-dd"));
                item.SubItems.Add(raport.NadrzednyProjekt);
                item.SubItems.Add(raport.CzasPracy.ToString());
                ZadaniaRaportList.Items.Add(item);
            }
        }
        private void LoadCzynnosciRaportList()
        {
            DataBase dataBase = new DataBase();
            List<CzynnoscRaport> czynnosciRaport = dataBase.GetCzynnosciRaport();
            foreach (CzynnoscRaport raport in czynnosciRaport)
            {
                ListViewItem item = new ListViewItem(raport.NazwaCzynnosci);
                item.SubItems.Add(raport.DataUtworzenia.ToString("yyyy-MM-dd"));
                item.SubItems.Add(raport.NadrzedneZadanie);
                item.SubItems.Add(raport.CzasPracy.ToString());
                CzynnosciRaportList.Items.Add(item);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
