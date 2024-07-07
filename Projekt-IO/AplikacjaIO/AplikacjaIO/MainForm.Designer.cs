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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowaKategoriaToolStripMenuItem = new ToolStripMenuItem();
            KategoriaDodajToolStrip = new ToolStripMenuItem();
            KategorieUsunToolStrip = new ToolStripMenuItem();
            NewProject_menu = new ToolStripMenuItem();
            ProjektDodajToolStrip = new ToolStripMenuItem();
            ProjektUsunToolStrip = new ToolStripMenuItem();
            noweZadanieToolStripMenuItem = new ToolStripMenuItem();
            ZadanieDodajToolStrip = new ToolStripMenuItem();
            ZadanieUsunToolStrip = new ToolStripMenuItem();
            nowaCzynnoscToolStripMenuItem = new ToolStripMenuItem();
            CzynnoscDodajToolStrip = new ToolStripMenuItem();
            CzynnoscUsunToolStrip = new ToolStripMenuItem();
            generujRaportToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            zmieńNazwęToolStripMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            archiwizujToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            pełnyEkranToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            KategorieList = new ListView();
            label2 = new Label();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            ProjektList = new ListView();
            label3 = new Label();
            splitContainer3 = new SplitContainer();
            tableLayoutPanel5 = new TableLayoutPanel();
            ZadanieList = new ListView();
            label4 = new Label();
            splitContainer4 = new SplitContainer();
            tableLayoutPanel6 = new TableLayoutPanel();
            CzynnoscList = new ListView();
            label5 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            Time_txt = new TextBox();
            Przerwa_btn = new Button();
            Stop_btn = new Button();
            Start_btn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox4 = new TextBox();
            listView4 = new ListView();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            listView2 = new ListView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, widokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 4, 0, 4);
            menuStrip1.Size = new Size(867, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowaKategoriaToolStripMenuItem, NewProject_menu, noweZadanieToolStripMenuItem, nowaCzynnoscToolStripMenuItem, generujRaportToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // nowaKategoriaToolStripMenuItem
            // 
            nowaKategoriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { KategoriaDodajToolStrip, KategorieUsunToolStrip });
            nowaKategoriaToolStripMenuItem.Name = "nowaKategoriaToolStripMenuItem";
            nowaKategoriaToolStripMenuItem.Size = new Size(188, 26);
            nowaKategoriaToolStripMenuItem.Text = "Kategorie";
            nowaKategoriaToolStripMenuItem.Click += nowaKategoriaToolStripMenuItem_Click;
            // 
            // KategoriaDodajToolStrip
            // 
            KategoriaDodajToolStrip.Name = "KategoriaDodajToolStrip";
            KategoriaDodajToolStrip.Size = new Size(133, 26);
            KategoriaDodajToolStrip.Text = "Dodaj";
            KategoriaDodajToolStrip.Click += KategoriaDodajToolStrip_Click;
            // 
            // KategorieUsunToolStrip
            // 
            KategorieUsunToolStrip.Name = "KategorieUsunToolStrip";
            KategorieUsunToolStrip.Size = new Size(133, 26);
            KategorieUsunToolStrip.Text = "Usuń";
            KategorieUsunToolStrip.Click += KategorieUsunToolStrip_Click;
            // 
            // NewProject_menu
            // 
            NewProject_menu.DropDownItems.AddRange(new ToolStripItem[] { ProjektDodajToolStrip, ProjektUsunToolStrip });
            NewProject_menu.Name = "NewProject_menu";
            NewProject_menu.Size = new Size(188, 26);
            NewProject_menu.Text = "Projekty";
            NewProject_menu.Click += NewProject_menu_Click;
            // 
            // ProjektDodajToolStrip
            // 
            ProjektDodajToolStrip.Name = "ProjektDodajToolStrip";
            ProjektDodajToolStrip.Size = new Size(133, 26);
            ProjektDodajToolStrip.Text = "Dodaj";
            ProjektDodajToolStrip.Click += ProjektDodajToolStrip_Click;
            // 
            // ProjektUsunToolStrip
            // 
            ProjektUsunToolStrip.Name = "ProjektUsunToolStrip";
            ProjektUsunToolStrip.Size = new Size(133, 26);
            ProjektUsunToolStrip.Text = "Usuń";
            ProjektUsunToolStrip.Click += ProjektUsunToolStrip_Click;
            // 
            // noweZadanieToolStripMenuItem
            // 
            noweZadanieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ZadanieDodajToolStrip, ZadanieUsunToolStrip });
            noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            noweZadanieToolStripMenuItem.Size = new Size(188, 26);
            noweZadanieToolStripMenuItem.Text = "Zadania";
            // 
            // ZadanieDodajToolStrip
            // 
            ZadanieDodajToolStrip.Name = "ZadanieDodajToolStrip";
            ZadanieDodajToolStrip.Size = new Size(133, 26);
            ZadanieDodajToolStrip.Text = "Dodaj";
            ZadanieDodajToolStrip.Click += ZadanieDodajToolStrip_Click;
            // 
            // ZadanieUsunToolStrip
            // 
            ZadanieUsunToolStrip.Name = "ZadanieUsunToolStrip";
            ZadanieUsunToolStrip.Size = new Size(133, 26);
            ZadanieUsunToolStrip.Text = "usuń";
            ZadanieUsunToolStrip.Click += ZadanieUsunToolStrip_Click;
            // 
            // nowaCzynnoscToolStripMenuItem
            // 
            nowaCzynnoscToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CzynnoscDodajToolStrip, CzynnoscUsunToolStrip });
            nowaCzynnoscToolStripMenuItem.Name = "nowaCzynnoscToolStripMenuItem";
            nowaCzynnoscToolStripMenuItem.Size = new Size(188, 26);
            nowaCzynnoscToolStripMenuItem.Text = "Czynności";
            // 
            // CzynnoscDodajToolStrip
            // 
            CzynnoscDodajToolStrip.Name = "CzynnoscDodajToolStrip";
            CzynnoscDodajToolStrip.Size = new Size(133, 26);
            CzynnoscDodajToolStrip.Text = "Dodaj";
            CzynnoscDodajToolStrip.Click += CzynnoscDodajToolStrip_Click;
            // 
            // CzynnoscUsunToolStrip
            // 
            CzynnoscUsunToolStrip.Name = "CzynnoscUsunToolStrip";
            CzynnoscUsunToolStrip.Size = new Size(133, 26);
            CzynnoscUsunToolStrip.Text = "Usuń";
            CzynnoscUsunToolStrip.Click += CzynnoscUsunToolStrip_Click;
            // 
            // generujRaportToolStripMenuItem
            // 
            generujRaportToolStripMenuItem.Name = "generujRaportToolStripMenuItem";
            generujRaportToolStripMenuItem.Size = new Size(188, 26);
            generujRaportToolStripMenuItem.Text = "Generuj raport";
            generujRaportToolStripMenuItem.Click += generujRaportToolStripMenuItem_Click;
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
            zmieńNazwęToolStripMenuItem.Size = new Size(180, 26);
            zmieńNazwęToolStripMenuItem.Text = "Zmień nazwę";
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.Size = new Size(180, 26);
            usuńToolStripMenuItem.Text = "Usuń";
            // 
            // archiwizujToolStripMenuItem
            // 
            archiwizujToolStripMenuItem.Name = "archiwizujToolStripMenuItem";
            archiwizujToolStripMenuItem.Size = new Size(180, 26);
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
            pełnyEkranToolStripMenuItem.Size = new Size(166, 26);
            pełnyEkranToolStripMenuItem.Text = "Pełny ekran";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 32);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(867, 759);
            splitContainer1.SplitterDistance = 162;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(KategorieList, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.660377F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.33963F));
            tableLayoutPanel1.Size = new Size(162, 759);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // KategorieList
            // 
            KategorieList.Dock = DockStyle.Fill;
            KategorieList.Location = new Point(3, 46);
            KategorieList.Margin = new Padding(3, 4, 3, 4);
            KategorieList.Name = "KategorieList";
            KategorieList.Size = new Size(156, 709);
            KategorieList.TabIndex = 1;
            KategorieList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 42);
            label2.TabIndex = 2;
            label2.Text = "Kategorie";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(700, 759);
            splitContainer2.SplitterDistance = 176;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(ProjektList, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.660377F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 94.33963F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.Size = new Size(176, 759);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // ProjektList
            // 
            ProjektList.Dock = DockStyle.Fill;
            ProjektList.Location = new Point(3, 46);
            ProjektList.Margin = new Padding(3, 4, 3, 4);
            ProjektList.Name = "ProjektList";
            ProjektList.Size = new Size(170, 709);
            ProjektList.TabIndex = 1;
            ProjektList.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 42);
            label3.TabIndex = 2;
            label3.Text = "Projekty";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(3, 4, 3, 4);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(tableLayoutPanel5);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(519, 759);
            splitContainer3.SplitterDistance = 171;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(ZadanieList, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 5.660377F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 94.33963F));
            tableLayoutPanel5.Size = new Size(171, 759);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // ZadanieList
            // 
            ZadanieList.Dock = DockStyle.Fill;
            ZadanieList.Location = new Point(3, 46);
            ZadanieList.Margin = new Padding(3, 4, 3, 4);
            ZadanieList.Name = "ZadanieList";
            ZadanieList.Size = new Size(165, 709);
            ZadanieList.TabIndex = 1;
            ZadanieList.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 42);
            label4.TabIndex = 2;
            label4.Text = "Zadania";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(3, 4, 3, 4);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(tableLayoutPanel6);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(tableLayoutPanel7);
            splitContainer4.Size = new Size(343, 759);
            splitContainer4.SplitterDistance = 170;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            splitContainer4.SplitterMoved += splitContainer4_SplitterMoved;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(CzynnoscList, 0, 1);
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 5.660377F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 94.33963F));
            tableLayoutPanel6.Size = new Size(170, 759);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // CzynnoscList
            // 
            CzynnoscList.Dock = DockStyle.Fill;
            CzynnoscList.Location = new Point(3, 46);
            CzynnoscList.Margin = new Padding(3, 4, 3, 4);
            CzynnoscList.Name = "CzynnoscList";
            CzynnoscList.Size = new Size(164, 709);
            CzynnoscList.TabIndex = 1;
            CzynnoscList.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 42);
            label5.TabIndex = 2;
            label5.Text = "Czynności";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Controls.Add(panel1, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 9.189189F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 90.8108139F));
            tableLayoutPanel7.Size = new Size(168, 759);
            tableLayoutPanel7.TabIndex = 0;
            tableLayoutPanel7.Paint += tableLayoutPanel7_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 69);
            label1.TabIndex = 0;
            label1.Text = "Projekt01";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(Time_txt);
            panel1.Controls.Add(Przerwa_btn);
            panel1.Controls.Add(Stop_btn);
            panel1.Controls.Add(Start_btn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 73);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 682);
            panel1.TabIndex = 1;
            // 
            // Time_txt
            // 
            Time_txt.Anchor = AnchorStyles.Top;
            Time_txt.Location = new Point(29, 9);
            Time_txt.Margin = new Padding(3, 4, 3, 4);
            Time_txt.Name = "Time_txt";
            Time_txt.Size = new Size(105, 27);
            Time_txt.TabIndex = 7;
            Time_txt.Text = "1:02:30";
            Time_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Przerwa_btn
            // 
            Przerwa_btn.Anchor = AnchorStyles.Top;
            Przerwa_btn.AutoSize = true;
            Przerwa_btn.Location = new Point(29, 131);
            Przerwa_btn.Margin = new Padding(3, 4, 3, 4);
            Przerwa_btn.Name = "Przerwa_btn";
            Przerwa_btn.Size = new Size(105, 40);
            Przerwa_btn.TabIndex = 6;
            Przerwa_btn.Text = "Przerwa";
            Przerwa_btn.UseVisualStyleBackColor = true;
            // 
            // Stop_btn
            // 
            Stop_btn.Anchor = AnchorStyles.Top;
            Stop_btn.AutoSize = true;
            Stop_btn.Location = new Point(29, 89);
            Stop_btn.Margin = new Padding(3, 4, 3, 4);
            Stop_btn.Name = "Stop_btn";
            Stop_btn.Size = new Size(105, 40);
            Stop_btn.TabIndex = 5;
            Stop_btn.Text = "Stop";
            Stop_btn.UseVisualStyleBackColor = true;
            // 
            // Start_btn
            // 
            Start_btn.Anchor = AnchorStyles.Top;
            Start_btn.AutoSize = true;
            Start_btn.Location = new Point(29, 48);
            Start_btn.Margin = new Padding(3, 4, 3, 4);
            Start_btn.Name = "Start_btn";
            Start_btn.Size = new Size(105, 40);
            Start_btn.TabIndex = 4;
            Start_btn.Text = "Start";
            Start_btn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(textBox4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(3, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 27);
            textBox4.TabIndex = 0;
            // 
            // listView4
            // 
            listView4.Dock = DockStyle.Fill;
            listView4.Location = new Point(3, 32);
            listView4.Name = "listView4";
            listView4.Size = new Size(194, 415);
            listView4.TabIndex = 1;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 0;
            // 
            // listView2
            // 
            listView2.Dock = DockStyle.Fill;
            listView2.Location = new Point(3, 32);
            listView2.Name = "listView2";
            listView2.Size = new Size(194, 415);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 791);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem archiwizujToolStripMenuItem;
        private ToolStripMenuItem NewProject_menu;
        private ToolStripMenuItem noweZadanieToolStripMenuItem;
        private ToolStripMenuItem generujRaportToolStripMenuItem;
        private ToolStripMenuItem pełnyEkranToolStripMenuItem;
        private ToolStripMenuItem nowaCzynnoscToolStripMenuItem;
        private ToolStripMenuItem nowaKategoriaToolStripMenuItem;
        private ToolStripMenuItem KategoriaDodajToolStrip;
        private ToolStripMenuItem KategorieUsunToolStrip;
        private ToolStripMenuItem ProjektDodajToolStrip;
        private ToolStripMenuItem ProjektUsunToolStrip;
        private ToolStripMenuItem ZadanieDodajToolStrip;
        private ToolStripMenuItem ZadanieUsunToolStrip;
        private ToolStripMenuItem CzynnoscDodajToolStrip;
        private ToolStripMenuItem CzynnoscUsunToolStrip;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private ListView KategorieList;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox4;
        private ListView listView4;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private ListView listView2;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView ProjektList;
        private TableLayoutPanel tableLayoutPanel5;
        private ListView ZadanieList;
        private TableLayoutPanel tableLayoutPanel6;
        private ListView CzynnoscList;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private Panel panel1;
        private Button Start_btn;
        private TextBox Time_txt;
        private Button Przerwa_btn;
        private Button Stop_btn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
