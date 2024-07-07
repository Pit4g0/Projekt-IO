namespace AplikacjaIO
{
    partial class ZadanieForm
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
            Cancel_btn = new Button();
            AddZadanie_btn = new Button();
            ZadanieNazwa = new TextBox();
            ProjektList_comboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(221, 221);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 23);
            Cancel_btn.TabIndex = 0;
            Cancel_btn.Text = "Anuluj";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // AddZadanie_btn
            // 
            AddZadanie_btn.Location = new Point(302, 221);
            AddZadanie_btn.Name = "AddZadanie_btn";
            AddZadanie_btn.Size = new Size(75, 23);
            AddZadanie_btn.TabIndex = 1;
            AddZadanie_btn.Text = "Zatwierdź";
            AddZadanie_btn.UseVisualStyleBackColor = true;
            AddZadanie_btn.Click += AddZadanie_btn_Click;
            // 
            // ZadanieNazwa
            // 
            ZadanieNazwa.Location = new Point(221, 137);
            ZadanieNazwa.Name = "ZadanieNazwa";
            ZadanieNazwa.Size = new Size(156, 25);
            ZadanieNazwa.TabIndex = 2;
            // 
            // ProjektList_comboBox
            // 
            ProjektList_comboBox.FormattingEnabled = true;
            ProjektList_comboBox.Location = new Point(221, 190);
            ProjektList_comboBox.Name = "ProjektList_comboBox";
            ProjektList_comboBox.Size = new Size(156, 25);
            ProjektList_comboBox.TabIndex = 3;
            ProjektList_comboBox.SelectedIndexChanged += AddZadanie_comboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 117);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 4;
            label1.Text = "Nazwa Zadania";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 170);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 5;
            label2.Text = "Projekt Nadrzędny";
            // 
            // ZadanieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 351);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProjektList_comboBox);
            Controls.Add(ZadanieNazwa);
            Controls.Add(AddZadanie_btn);
            Controls.Add(Cancel_btn);
            Name = "ZadanieForm";
            Text = "ZadanieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel_btn;
        private Button AddZadanie_btn;
        private TextBox ZadanieNazwa;
        private ComboBox ProjektList_comboBox;
        private Label label1;
        private Label label2;
    }
}