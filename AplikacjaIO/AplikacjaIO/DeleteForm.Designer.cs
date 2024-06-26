namespace AplikacjaIO
{
    partial class DeleteForm
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
            Erase_comboBox = new ComboBox();
            Erase_lbl = new Label();
            Cancel = new Button();
            Erase_btn = new Button();
            SuspendLayout();
            // 
            // Erase_comboBox
            // 
            Erase_comboBox.FormattingEnabled = true;
            Erase_comboBox.Location = new Point(218, 160);
            Erase_comboBox.Name = "Erase_comboBox";
            Erase_comboBox.Size = new Size(121, 25);
            Erase_comboBox.TabIndex = 0;
            Erase_comboBox.SelectedIndexChanged += Erase_comboBox_SelectedIndexChanged;
            // 
            // Erase_lbl
            // 
            Erase_lbl.AutoSize = true;
            Erase_lbl.Location = new Point(221, 134);
            Erase_lbl.Name = "Erase_lbl";
            Erase_lbl.Size = new Size(105, 17);
            Erase_lbl.TabIndex = 1;
            Erase_lbl.Text = "Wybierz element";
            // 
            // Cancel
            // 
            Cancel.Location = new Point(218, 191);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(57, 23);
            Cancel.TabIndex = 2;
            Cancel.Text = "Anuluj";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Erase_btn
            // 
            Erase_btn.Location = new Point(283, 191);
            Erase_btn.Name = "Erase_btn";
            Erase_btn.Size = new Size(56, 23);
            Erase_btn.TabIndex = 3;
            Erase_btn.Text = "Usuń";
            Erase_btn.UseVisualStyleBackColor = true;
            Erase_btn.Click += Erase_btn_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 331);
            Controls.Add(Erase_btn);
            Controls.Add(Cancel);
            Controls.Add(Erase_lbl);
            Controls.Add(Erase_comboBox);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Erase_comboBox;
        private Label Erase_lbl;
        private Button Cancel;
        private Button Erase_btn;
    }
}