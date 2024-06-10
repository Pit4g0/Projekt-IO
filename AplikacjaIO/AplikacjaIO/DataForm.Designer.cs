namespace AplikacjaIO
{
    partial class DataForm
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
            NewData_tb = new TextBox();
            Cancel_btn = new Button();
            AddData_btn = new Button();
            SuspendLayout();
            // 
            // NewData_tb
            // 
            NewData_tb.Location = new Point(206, 120);
            NewData_tb.Name = "NewData_tb";
            NewData_tb.Size = new Size(154, 25);
            NewData_tb.TabIndex = 0;
            NewData_tb.TextChanged += NewData_tb_TextChanged;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(206, 153);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(60, 23);
            Cancel_btn.TabIndex = 1;
            Cancel_btn.Text = "Anuluj";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // AddData_btn
            // 
            AddData_btn.Location = new Point(284, 153);
            AddData_btn.Name = "AddData_btn";
            AddData_btn.Size = new Size(76, 23);
            AddData_btn.TabIndex = 2;
            AddData_btn.Text = "Zatwierdź";
            AddData_btn.UseVisualStyleBackColor = true;
            AddData_btn.Click += AddData_btn_Click;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 281);
            Controls.Add(AddData_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(NewData_tb);
            Name = "DataForm";
            Text = "DataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewData_tb;
        private Button Cancel_btn;
        private Button AddData_btn;
    }
}