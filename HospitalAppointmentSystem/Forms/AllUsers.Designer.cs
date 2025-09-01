namespace HospitalAppointmentSystem.Forms
{
    partial class AllUsers
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
            ReturnToLoginPageButton = new Button();
            ReturnToAdminPageButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // ReturnToLoginPageButton
            // 
            ReturnToLoginPageButton.Font = new Font("Palatino Linotype", 15.75F);
            ReturnToLoginPageButton.Location = new Point(580, 736);
            ReturnToLoginPageButton.Name = "ReturnToLoginPageButton";
            ReturnToLoginPageButton.Size = new Size(544, 68);
            ReturnToLoginPageButton.TabIndex = 5;
            ReturnToLoginPageButton.Text = "Return to Login Page";
            ReturnToLoginPageButton.UseVisualStyleBackColor = true;
            ReturnToLoginPageButton.Click += ReturnToLoginPageButton_Click_1;
            // 
            // ReturnToAdminPageButton
            // 
            ReturnToAdminPageButton.Font = new Font("Palatino Linotype", 15.75F);
            ReturnToAdminPageButton.Location = new Point(12, 736);
            ReturnToAdminPageButton.Name = "ReturnToAdminPageButton";
            ReturnToAdminPageButton.Size = new Size(562, 68);
            ReturnToAdminPageButton.TabIndex = 4;
            ReturnToAdminPageButton.Text = "Return to Admin Page";
            ReturnToAdminPageButton.UseVisualStyleBackColor = true;
            ReturnToAdminPageButton.Click += ReturnToAdminPageButton_Click_1;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1112, 697);
            listBox1.TabIndex = 6;
            // 
            // AllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(listBox1);
            Controls.Add(ReturnToLoginPageButton);
            Controls.Add(ReturnToAdminPageButton);
            Name = "AllUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllUsers";
            Load += AllUsers_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnToLoginPageButton;
        private Button ReturnToAdminPageButton;
        private ListBox listBox1;
    }
}