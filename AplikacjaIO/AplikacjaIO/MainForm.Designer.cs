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
            TreeNode treeNode2 = new TreeNode("Praca");
            TreeNode treeNode3 = new TreeNode("Rozrywka");
            TreeNode treeNode4 = new TreeNode("Archiwum");
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
            textBox1 = new TextBox();
            Start_btn = new Button();
            Stop_btn = new Button();
            Przerwa_btn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            listView3 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            textBox4 = new TextBox();
            panel3 = new Panel();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            textBox3 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, widokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(940, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewProject_menu, noweZadanieToolStripMenuItem, generujRaportToolStripMenuItem, nowyProjektToolStripMenuItem1 });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 19);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // NewProject_menu
            // 
            NewProject_menu.Name = "NewProject_menu";
            NewProject_menu.Size = new Size(150, 22);
            NewProject_menu.Text = "Nowy projekt";
            NewProject_menu.Click += NewProject_menu_Click;
            // 
            // noweZadanieToolStripMenuItem
            // 
            noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            noweZadanieToolStripMenuItem.Size = new Size(150, 22);
            noweZadanieToolStripMenuItem.Text = "Nowe zadanie";
            // 
            // generujRaportToolStripMenuItem
            // 
            generujRaportToolStripMenuItem.Name = "generujRaportToolStripMenuItem";
            generujRaportToolStripMenuItem.Size = new Size(150, 22);
            generujRaportToolStripMenuItem.Text = "Generuj raport";
            // 
            // nowyProjektToolStripMenuItem1
            // 
            nowyProjektToolStripMenuItem1.Name = "nowyProjektToolStripMenuItem1";
            nowyProjektToolStripMenuItem1.Size = new Size(150, 22);
            nowyProjektToolStripMenuItem1.Text = "Nowy projekt";
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zmieńNazwęToolStripMenuItem, usuńToolStripMenuItem, archiwizujToolStripMenuItem });
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 19);
            edycjaToolStripMenuItem.Text = "Edycja";
            edycjaToolStripMenuItem.Click += edycjaToolStripMenuItem_Click;
            // 
            // zmieńNazwęToolStripMenuItem
            // 
            zmieńNazwęToolStripMenuItem.Name = "zmieńNazwęToolStripMenuItem";
            zmieńNazwęToolStripMenuItem.Size = new Size(144, 22);
            zmieńNazwęToolStripMenuItem.Text = "Zmień nazwę";
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.Size = new Size(144, 22);
            usuńToolStripMenuItem.Text = "Usuń";
            // 
            // archiwizujToolStripMenuItem
            // 
            archiwizujToolStripMenuItem.Name = "archiwizujToolStripMenuItem";
            archiwizujToolStripMenuItem.Size = new Size(144, 22);
            archiwizujToolStripMenuItem.Text = "Archiwizuj";
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pełnyEkranToolStripMenuItem });
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(53, 19);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // pełnyEkranToolStripMenuItem
            // 
            pełnyEkranToolStripMenuItem.Name = "pełnyEkranToolStripMenuItem";
            pełnyEkranToolStripMenuItem.Size = new Size(135, 22);
            pełnyEkranToolStripMenuItem.Text = "Pełny ekran";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 25);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Węzeł0";
            treeNode1.Text = "Ostatnie";
            treeNode2.Name = "Projekt01";
            treeNode2.Text = "Praca";
            treeNode3.Name = "Węzeł2";
            treeNode3.Text = "Rozrywka";
            treeNode4.Name = "Węzeł3";
            treeNode4.Text = "Archiwum";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            treeView1.Size = new Size(121, 577);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(648, 50);
            textBox1.Margin = new Padding(50);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "1:02:30";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Start_btn
            // 
            Start_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Start_btn.Location = new Point(648, 86);
            Start_btn.Name = "Start_btn";
            Start_btn.Size = new Size(117, 23);
            Start_btn.TabIndex = 6;
            Start_btn.Text = "Start";
            Start_btn.UseVisualStyleBackColor = true;
            // 
            // Stop_btn
            // 
            Stop_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Stop_btn.Location = new Point(648, 115);
            Stop_btn.Name = "Stop_btn";
            Stop_btn.Size = new Size(117, 23);
            Stop_btn.TabIndex = 7;
            Stop_btn.Text = "Stop";
            Stop_btn.UseVisualStyleBackColor = true;
            // 
            // Przerwa_btn
            // 
            Przerwa_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Przerwa_btn.Location = new Point(648, 144);
            Przerwa_btn.Name = "Przerwa_btn";
            Przerwa_btn.Size = new Size(117, 23);
            Przerwa_btn.TabIndex = 8;
            Przerwa_btn.Text = "Przerwa";
            Przerwa_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(681, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "Projekt01";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Przerwa_btn);
            panel1.Controls.Add(Stop_btn);
            panel1.Controls.Add(Start_btn);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(121, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 577);
            panel1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(listView3);
            panel4.Controls.Add(textBox4);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(395, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 577);
            panel4.TabIndex = 12;
            // 
            // listView3
            // 
            listView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            listView3.Location = new Point(0, 21);
            listView3.Name = "listView3";
            listView3.Size = new Size(200, 556);
            listView3.TabIndex = 4;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nazwa";
            columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Czas";
            columnHeader6.Width = 95;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Top;
            textBox4.Location = new Point(0, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Czynności";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(listView2);
            panel3.Controls.Add(textBox3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(195, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 577);
            panel3.TabIndex = 11;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listView2.Location = new Point(0, 21);
            listView2.Name = "listView2";
            listView2.Size = new Size(200, 556);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nazwa";
            columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Czas";
            columnHeader4.Width = 95;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Top;
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Zadania";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(listView1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 577);
            panel2.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Projekty";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(0, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(195, 556);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nazwa";
            columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Czas";
            columnHeader2.Width = 95;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 602);
            Controls.Add(panel1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem archiwizujToolStripMenuItem;
        private ToolStripMenuItem NewProject_menu;
        private ToolStripMenuItem noweZadanieToolStripMenuItem;
        private ToolStripMenuItem generujRaportToolStripMenuItem;
        private ToolStripMenuItem pełnyEkranToolStripMenuItem;
        private ToolStripMenuItem nowyProjektToolStripMenuItem1;
        private TextBox textBox1;
        private Button Start_btn;
        private Button Stop_btn;
        private Button Przerwa_btn;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox textBox4;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox textBox3;
    }
}
