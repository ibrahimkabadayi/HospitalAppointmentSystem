namespace HospitalAppointmentSystem.Forms
{
    partial class PatientAppointments
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
            ReturnToPatientPageButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            ReturnToLoginPageButton.Click += ReturnToLoginPageButton_Click;
            // 
            // ReturnToPatientPageButton
            // 
            ReturnToPatientPageButton.Font = new Font("Palatino Linotype", 15.75F);
            ReturnToPatientPageButton.Location = new Point(12, 736);
            ReturnToPatientPageButton.Name = "ReturnToPatientPageButton";
            ReturnToPatientPageButton.Size = new Size(562, 68);
            ReturnToPatientPageButton.TabIndex = 4;
            ReturnToPatientPageButton.Text = "Return to Patient Page";
            ReturnToPatientPageButton.UseVisualStyleBackColor = true;
            ReturnToPatientPageButton.Click += ReturnToPatientPageButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1112, 712);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // PatientAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(ReturnToLoginPageButton);
            Controls.Add(ReturnToPatientPageButton);
            Controls.Add(flowLayoutPanel1);
            Name = "PatientAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientAppointments";
            Load += PatientAppointments_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnToLoginPageButton;
        private Button ReturnToPatientPageButton;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}