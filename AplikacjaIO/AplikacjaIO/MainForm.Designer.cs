namespace AplikacjaIO
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
            Project_btn = new Button();
            SuspendLayout();
            // 
            // Project_btn
            // 
            Project_btn.Location = new Point(337, 182);
            Project_btn.Name = "Project_btn";
            Project_btn.Size = new Size(122, 32);
            Project_btn.TabIndex = 0;
            Project_btn.Text = "Nowy Projekt";
            Project_btn.UseVisualStyleBackColor = true;
            Project_btn.Click += Project_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Project_btn);
            Name = "MainForm";
            Text = "Aplikacja";
            ResumeLayout(false);
        }

        #endregion

        private Button Project_btn;
    }
}
