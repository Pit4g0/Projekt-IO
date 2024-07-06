namespace AplikacjaIO
{
    partial class AddKategoriaForm
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
            KategorieName_txt = new TextBox();
            label1 = new Label();
            Cancel_btn = new Button();
            AddKategoria_btn = new Button();
            SuspendLayout();
            // 
            // KategorieName_txt
            // 
            KategorieName_txt.Location = new Point(166, 114);
            KategorieName_txt.Name = "KategorieName_txt";
            KategorieName_txt.Size = new Size(142, 25);
            KategorieName_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 94);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 1;
            label1.Text = "Nazwa Kategorii";
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(166, 145);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(63, 23);
            Cancel_btn.TabIndex = 2;
            Cancel_btn.Text = "Anuluj";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // AddKategoria_btn
            // 
            AddKategoria_btn.Location = new Point(235, 145);
            AddKategoria_btn.Name = "AddKategoria_btn";
            AddKategoria_btn.Size = new Size(73, 23);
            AddKategoria_btn.TabIndex = 3;
            AddKategoria_btn.Text = "Zatwierdz";
            AddKategoria_btn.UseVisualStyleBackColor = true;
            AddKategoria_btn.Click += AddKategoria_btn_Click;
            // 
            // AddKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 251);
            Controls.Add(AddKategoria_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(label1);
            Controls.Add(KategorieName_txt);
            Name = "AddKategoriaForm";
            Text = "AddKategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KategorieName_txt;
        private Label label1;
        private Button Cancel_btn;
        private Button AddKategoria_btn;
    }
}