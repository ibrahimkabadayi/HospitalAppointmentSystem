namespace HospitalAppointmentSystem.Forms
{
    partial class Form4
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ReturnToAdminPageButton = new Button();
            ReturnToLoginPageButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1112, 712);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ReturnToAdminPageButton
            // 
            ReturnToAdminPageButton.Font = new Font("Palatino Linotype", 15.75F);
            ReturnToAdminPageButton.Location = new Point(12, 730);
            ReturnToAdminPageButton.Name = "ReturnToAdminPageButton";
            ReturnToAdminPageButton.Size = new Size(562, 68);
            ReturnToAdminPageButton.TabIndex = 1;
            ReturnToAdminPageButton.Text = "Return to Admin Page";
            ReturnToAdminPageButton.UseVisualStyleBackColor = true;
            ReturnToAdminPageButton.Click += ReturnToAdminPageButton_Click;
            ReturnToAdminPageButton.MouseEnter += ReturnToAdminPageButton_MouseEnter;
            ReturnToAdminPageButton.MouseLeave += ReturnToAdminPageButton_MouseLeave;
            // 
            // ReturnToLoginPageButton
            // 
            ReturnToLoginPageButton.Font = new Font("Palatino Linotype", 15.75F);
            ReturnToLoginPageButton.Location = new Point(580, 730);
            ReturnToLoginPageButton.Name = "ReturnToLoginPageButton";
            ReturnToLoginPageButton.Size = new Size(544, 68);
            ReturnToLoginPageButton.TabIndex = 2;
            ReturnToLoginPageButton.Text = "Return to Login Page";
            ReturnToLoginPageButton.UseVisualStyleBackColor = true;
            ReturnToLoginPageButton.Click += ReturnToLoginPageButton_Click;
            ReturnToLoginPageButton.MouseEnter += ReturnToLoginPageButton_MouseEnter;
            ReturnToLoginPageButton.MouseLeave += ReturnToLoginPageButton_MouseLeave;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(ReturnToLoginPageButton);
            Controls.Add(ReturnToAdminPageButton);
            Controls.Add(flowLayoutPanel1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button ReturnToAdminPageButton;
        private Button ReturnToLoginPageButton;
    }
}