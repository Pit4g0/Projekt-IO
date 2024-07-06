namespace AplikacjaIO
{
    partial class CzynnoscForm
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
            label2 = new Label();
            label1 = new Label();
            zadaniaList_comboBox = new ComboBox();
            CzynnoscNazwa = new TextBox();
            AddZadanie_btn = new Button();
            Cancel_btn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 171);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 11;
            label2.Text = "Zadanie Nadrzędne";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 118);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 10;
            label1.Text = "Nazwa Czynności";
            // 
            // zadaniaList_comboBox
            // 
            zadaniaList_comboBox.FormattingEnabled = true;
            zadaniaList_comboBox.Location = new Point(226, 191);
            zadaniaList_comboBox.Name = "zadaniaList_comboBox";
            zadaniaList_comboBox.Size = new Size(156, 25);
            zadaniaList_comboBox.TabIndex = 9;
            zadaniaList_comboBox.SelectedIndexChanged += zadaniaList_comboBox_SelectedIndexChanged;
            // 
            // CzynnoscNazwa
            // 
            CzynnoscNazwa.Location = new Point(226, 138);
            CzynnoscNazwa.Name = "CzynnoscNazwa";
            CzynnoscNazwa.Size = new Size(156, 25);
            CzynnoscNazwa.TabIndex = 8;
            // 
            // AddZadanie_btn
            // 
            AddZadanie_btn.Location = new Point(307, 222);
            AddZadanie_btn.Name = "AddZadanie_btn";
            AddZadanie_btn.Size = new Size(75, 23);
            AddZadanie_btn.TabIndex = 7;
            AddZadanie_btn.Text = "Zatwierdź";
            AddZadanie_btn.UseVisualStyleBackColor = true;
            AddZadanie_btn.Click += AddZadanie_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(226, 222);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 23);
            Cancel_btn.TabIndex = 6;
            Cancel_btn.Text = "Anuluj";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // CzynnoscForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 367);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(zadaniaList_comboBox);
            Controls.Add(CzynnoscNazwa);
            Controls.Add(AddZadanie_btn);
            Controls.Add(Cancel_btn);
            Name = "CzynnoscForm";
            Text = "CzynnoscForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox zadaniaList_comboBox;
        private TextBox CzynnoscNazwa;
        private Button AddZadanie_btn;
        private Button Cancel_btn;
    }
}