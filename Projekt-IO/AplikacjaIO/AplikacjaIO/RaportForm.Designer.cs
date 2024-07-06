namespace AplikacjaIO
{
    partial class RaportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProjektyRaportList = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            Zadania_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            KategorieRaportList = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            ZadaniaRaportList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            CzynnosciRaportList = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            label3 = new Label();
            SuspendLayout();
            // 
            // ProjektyRaportList
            // 
            ProjektyRaportList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ProjektyRaportList.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader7, columnHeader6 });
            ProjektyRaportList.Location = new Point(12, 23);
            ProjektyRaportList.Name = "ProjektyRaportList";
            ProjektyRaportList.Size = new Size(604, 211);
            ProjektyRaportList.TabIndex = 4;
            ProjektyRaportList.UseCompatibleStateImageBehavior = false;
            ProjektyRaportList.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "nazwa";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Data Utworzenia";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Przynależność";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "czas pracy";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 100;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 883);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 883);
            splitter2.TabIndex = 6;
            splitter2.TabStop = false;
            // 
            // Zadania_lbl
            // 
            Zadania_lbl.AutoSize = true;
            Zadania_lbl.Location = new Point(264, 240);
            Zadania_lbl.Name = "Zadania_lbl";
            Zadania_lbl.Size = new Size(54, 17);
            Zadania_lbl.TabIndex = 9;
            Zadania_lbl.Text = "Zadania";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 10;
            label1.Text = "Projekty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 474);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 11;
            label2.Text = "Czynności";
            label2.Click += label2_Click;
            // 
            // KategorieRaportList
            // 
            KategorieRaportList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            KategorieRaportList.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader17 });
            KategorieRaportList.Location = new Point(704, 29);
            KategorieRaportList.Name = "KategorieRaportList";
            KategorieRaportList.Size = new Size(302, 675);
            KategorieRaportList.TabIndex = 12;
            KategorieRaportList.UseCompatibleStateImageBehavior = false;
            KategorieRaportList.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "nazwa";
            columnHeader13.Width = 200;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "czas pracy";
            columnHeader17.TextAlign = HorizontalAlignment.Center;
            columnHeader17.Width = 100;
            // 
            // ZadaniaRaportList
            // 
            ZadaniaRaportList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ZadaniaRaportList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader8 });
            ZadaniaRaportList.Location = new Point(12, 260);
            ZadaniaRaportList.Name = "ZadaniaRaportList";
            ZadaniaRaportList.Size = new Size(604, 211);
            ZadaniaRaportList.TabIndex = 13;
            ZadaniaRaportList.UseCompatibleStateImageBehavior = false;
            ZadaniaRaportList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "nazwa";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Data Utworzenia";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Przynależność";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "czas pracy";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // CzynnosciRaportList
            // 
            CzynnosciRaportList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CzynnosciRaportList.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            CzynnosciRaportList.Location = new Point(9, 494);
            CzynnosciRaportList.Name = "CzynnosciRaportList";
            CzynnosciRaportList.Size = new Size(604, 211);
            CzynnosciRaportList.TabIndex = 14;
            CzynnosciRaportList.UseCompatibleStateImageBehavior = false;
            CzynnosciRaportList.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "nazwa";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Data Utworzenia";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Przynależność";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "czas pracy";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(833, 9);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 15;
            label3.Text = "Kategorie";
            label3.Click += label3_Click;
            // 
            // RaportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 883);
            Controls.Add(label3);
            Controls.Add(CzynnosciRaportList);
            Controls.Add(ZadaniaRaportList);
            Controls.Add(KategorieRaportList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Zadania_lbl);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(ProjektyRaportList);
            Name = "RaportForm";
            Text = "RaportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ProjektyRaportList;
        private ColumnHeader columnHeader4;
        private Splitter splitter1;
        private Splitter splitter2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader6;
        private Label Zadania_lbl;
        private Label label1;
        private Label label2;
        private ListView KategorieRaportList;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader17;
        private ListView ZadaniaRaportList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader8;
        private ListView CzynnosciRaportList;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label label3;
    }
}