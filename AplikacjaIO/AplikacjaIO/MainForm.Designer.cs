namespace Projekt_IO_3
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            NewProject_menu = new ToolStripMenuItem();
            noweZadanieToolStripMenuItem = new ToolStripMenuItem();
            generujRaportToolStripMenuItem = new ToolStripMenuItem();
            nowyProjektToolStripMenuItem1 = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            zmieńNazwęToolStripMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            archiwizujToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            pełnyEkranToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            timer1 = new System.Windows.Forms.Timer(components);
            ProjectList = new ListView();
            Nazwa = new ColumnHeader();
            Czas = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            Start_btn = new Button();
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
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(794, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewProject_menu, noweZadanieToolStripMenuItem, generujRaportToolStripMenuItem, nowyProjektToolStripMenuItem1 });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(39, 21);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // NewProject_menu
            // 
            NewProject_menu.Name = "NewProject_menu";
            NewProject_menu.Size = new Size(162, 22);
            NewProject_menu.Text = "Nowy projekt";
            NewProject_menu.Click += NewProject_menu_Click;
            // 
            // noweZadanieToolStripMenuItem
            // 
            noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            noweZadanieToolStripMenuItem.Size = new Size(162, 22);
            noweZadanieToolStripMenuItem.Text = "Nowe zadanie";
            // 
            // generujRaportToolStripMenuItem
            // 
            generujRaportToolStripMenuItem.Name = "generujRaportToolStripMenuItem";
            generujRaportToolStripMenuItem.Size = new Size(162, 22);
            generujRaportToolStripMenuItem.Text = "Generuj raport";
            // 
            // nowyProjektToolStripMenuItem1
            // 
            nowyProjektToolStripMenuItem1.Name = "nowyProjektToolStripMenuItem1";
            nowyProjektToolStripMenuItem1.Size = new Size(162, 22);
            nowyProjektToolStripMenuItem1.Text = "Nowy projekt";
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zmieńNazwęToolStripMenuItem, usuńToolStripMenuItem, archiwizujToolStripMenuItem });
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(57, 21);
            edycjaToolStripMenuItem.Text = "Edycja";
            edycjaToolStripMenuItem.Click += edycjaToolStripMenuItem_Click;
            // 
            // zmieńNazwęToolStripMenuItem
            // 
            zmieńNazwęToolStripMenuItem.Name = "zmieńNazwęToolStripMenuItem";
            zmieńNazwęToolStripMenuItem.Size = new Size(151, 22);
            zmieńNazwęToolStripMenuItem.Text = "Zmień nazwę";
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.Size = new Size(151, 22);
            usuńToolStripMenuItem.Text = "Usuń";
            // 
            // archiwizujToolStripMenuItem
            // 
            archiwizujToolStripMenuItem.Name = "archiwizujToolStripMenuItem";
            archiwizujToolStripMenuItem.Size = new Size(151, 22);
            archiwizujToolStripMenuItem.Text = "Archiwizuj";
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pełnyEkranToolStripMenuItem });
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(57, 21);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // pełnyEkranToolStripMenuItem
            // 
            pełnyEkranToolStripMenuItem.Name = "pełnyEkranToolStripMenuItem";
            pełnyEkranToolStripMenuItem.Size = new Size(142, 22);
            pełnyEkranToolStripMenuItem.Text = "Pełny ekran";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 27);
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
            treeView1.Size = new Size(121, 585);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // ProjectList
            // 
            ProjectList.Columns.AddRange(new ColumnHeader[] { Nazwa, Czas });
            ProjectList.Dock = DockStyle.Left;
            ProjectList.Location = new Point(121, 27);
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(207, 585);
            ProjectList.TabIndex = 2;
            ProjectList.UseCompatibleStateImageBehavior = false;
            ProjectList.View = View.Details;
            ProjectList.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
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
            panel1.Controls.Add(Start_btn);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(328, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 585);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 4;
            label1.Text = "Projekt01";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 81);
            button3.Name = "button3";
            button3.Size = new Size(117, 26);
            button3.TabIndex = 3;
            button3.Text = "Przerwa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(140, 81);
            button2.Name = "button2";
            button2.Size = new Size(117, 26);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            // 
            // Start_btn
            // 
            Start_btn.Location = new Point(17, 81);
            Start_btn.Name = "Start_btn";
            Start_btn.Size = new Size(117, 26);
            Start_btn.TabIndex = 1;
            Start_btn.Text = "Start";
            Start_btn.UseVisualStyleBackColor = true;
            Start_btn.Click += Start_btn_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 40);
            textBox1.Margin = new Padding(50, 57, 50, 57);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(366, 25);
            textBox1.TabIndex = 0;
            textBox1.Text = "1:02:30";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 612);
            Controls.Add(panel1);
            Controls.Add(ProjectList);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
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
        private ListView ProjectList;
        private ColumnHeader Nazwa;
        private ColumnHeader Czas;
        private Panel panel1;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button Start_btn;
        private Label label1;
        private ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem archiwizujToolStripMenuItem;
        private ToolStripMenuItem NewProject_menu;
        private ToolStripMenuItem noweZadanieToolStripMenuItem;
        private ToolStripMenuItem generujRaportToolStripMenuItem;
        private ToolStripMenuItem pełnyEkranToolStripMenuItem;
        private ToolStripMenuItem nowyProjektToolStripMenuItem1;
    }
}
