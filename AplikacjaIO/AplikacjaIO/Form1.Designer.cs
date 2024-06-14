namespace Projekt_IO_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Ostatnie");
            TreeNode treeNode2 = new TreeNode("Projekt01");
            TreeNode treeNode3 = new TreeNode("Projekt02");
            TreeNode treeNode4 = new TreeNode("Praca", new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("PH");
            TreeNode treeNode6 = new TreeNode("Rozrywka", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Archiwum");
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Projekt01", "1:02:30" }, -1, Color.Empty, SystemColors.Window, null);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Projekt02", "3:30:19" }, -1);
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowyProjektToolStripMenuItem = new ToolStripMenuItem();
            noweZadanieToolStripMenuItem = new ToolStripMenuItem();
            generujRaportToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            zmieńNazwęToolStripMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            archiwizujToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            pełnyEkranToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            Nazwa = new ColumnHeader();
            Czas = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, widokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(907, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowyProjektToolStripMenuItem, noweZadanieToolStripMenuItem, generujRaportToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyProjektToolStripMenuItem
            // 
            nowyProjektToolStripMenuItem.Name = "nowyProjektToolStripMenuItem";
            nowyProjektToolStripMenuItem.Size = new Size(224, 26);
            nowyProjektToolStripMenuItem.Text = "Nowy projekt";
            // 
            // noweZadanieToolStripMenuItem
            // 
            noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            noweZadanieToolStripMenuItem.Size = new Size(224, 26);
            noweZadanieToolStripMenuItem.Text = "Nowe zadanie";
            // 
            // generujRaportToolStripMenuItem
            // 
            generujRaportToolStripMenuItem.Name = "generujRaportToolStripMenuItem";
            generujRaportToolStripMenuItem.Size = new Size(224, 26);
            generujRaportToolStripMenuItem.Text = "Generuj raport";
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zmieńNazwęToolStripMenuItem, usuńToolStripMenuItem, archiwizujToolStripMenuItem });
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(66, 24);
            edycjaToolStripMenuItem.Text = "Edycja";
            edycjaToolStripMenuItem.Click += edycjaToolStripMenuItem_Click;
            // 
            // zmieńNazwęToolStripMenuItem
            // 
            zmieńNazwęToolStripMenuItem.Name = "zmieńNazwęToolStripMenuItem";
            zmieńNazwęToolStripMenuItem.Size = new Size(224, 26);
            zmieńNazwęToolStripMenuItem.Text = "Zmień nazwę";
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.Size = new Size(224, 26);
            usuńToolStripMenuItem.Text = "Usuń";
            // 
            // archiwizujToolStripMenuItem
            // 
            archiwizujToolStripMenuItem.Name = "archiwizujToolStripMenuItem";
            archiwizujToolStripMenuItem.Size = new Size(224, 26);
            archiwizujToolStripMenuItem.Text = "Archiwizuj";
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pełnyEkranToolStripMenuItem });
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(66, 24);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // pełnyEkranToolStripMenuItem
            // 
            pełnyEkranToolStripMenuItem.Name = "pełnyEkranToolStripMenuItem";
            pełnyEkranToolStripMenuItem.Size = new Size(224, 26);
            pełnyEkranToolStripMenuItem.Text = "Pełny ekran";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 30);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Węzeł0";
            treeNode1.Text = "Ostatnie";
            treeNode2.Name = "Węzeł4";
            treeNode2.Text = "Projekt01";
            treeNode3.Name = "Węzeł5";
            treeNode3.Text = "Projekt02";
            treeNode4.Name = "Projekt01";
            treeNode4.Text = "Praca";
            treeNode5.Name = "Węzeł6";
            treeNode5.Text = "PH";
            treeNode6.Name = "Węzeł2";
            treeNode6.Text = "Rozrywka";
            treeNode7.Name = "Węzeł3";
            treeNode7.Text = "Archiwum";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode4, treeNode6, treeNode7 });
            treeView1.Size = new Size(138, 690);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Nazwa, Czas });
            listView1.Dock = DockStyle.Left;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(138, 30);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(236, 690);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // Nazwa
            // 
            Nazwa.Text = "Nazwa";
            Nazwa.Width = 100;
            // 
            // Czas
            // 
            Czas.Text = "Czas";
            Czas.Width = 100;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(374, 30);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 690);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "Projekt01";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(304, 95);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(134, 31);
            button3.TabIndex = 3;
            button3.Text = "Przerwa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(160, 95);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(134, 31);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 95);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 31);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 47);
            textBox1.Margin = new Padding(57, 67, 57, 67);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(418, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "1:02:30";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 720);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem widokToolStripMenuItem;
        private TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private ColumnHeader Nazwa;
        private ColumnHeader Czas;
        private Panel panel1;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem archiwizujToolStripMenuItem;
        private ToolStripMenuItem nowyProjektToolStripMenuItem;
        private ToolStripMenuItem noweZadanieToolStripMenuItem;
        private ToolStripMenuItem generujRaportToolStripMenuItem;
        private ToolStripMenuItem pełnyEkranToolStripMenuItem;
    }
}
