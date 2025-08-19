namespace HospitalAppointmentSystem.Forms
{
    partial class AppointmentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            timeLabel = new Label();
            dateLabel = new Label();
            panel3 = new Panel();
            statusLabel = new Label();
            label11 = new Label();
            gmailLabel = new Label();
            telephoneLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            surnameLabel = new Label();
            label5 = new Label();
            nameLabel = new Label();
            label3 = new Label();
            statusPictureBox = new PictureBox();
            docCommentPictureBox = new PictureBox();
            patientCommentPictureBox = new PictureBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statusPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docCommentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientCommentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(timeLabel);
            panel4.Controls.Add(dateLabel);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 38);
            panel4.TabIndex = 7;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Palatino Linotype", 11.25F);
            timeLabel.Location = new Point(199, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(45, 20);
            timeLabel.TabIndex = 6;
            timeLabel.Text = "12:00";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateLabel.Location = new Point(3, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(81, 20);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "12.07.2025";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(statusLabel);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(gmailLabel);
            panel3.Controls.Add(telephoneLabel);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(surnameLabel);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 169);
            panel3.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 11.25F);
            statusLabel.Location = new Point(127, 76);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(41, 20);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Seen";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(127, 61);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 10;
            label11.Text = "Status:";
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.Font = new Font("Segoe UI", 11.25F);
            gmailLabel.Location = new Point(3, 123);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new Size(228, 20);
            gmailLabel.TabIndex = 8;
            gmailLabel.Text = "ibrahimkabadayi180@gmail.com";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new Font("Segoe UI", 11.25F);
            telephoneLabel.Location = new Point(3, 76);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new Size(101, 20);
            telephoneLabel.TabIndex = 8;
            telephoneLabel.Text = "543 835 41 73";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 108);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 10;
            label8.Text = "Patient Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 61);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 9;
            label7.Text = "Telephone :";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 11.25F);
            surnameLabel.Location = new Point(129, 24);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(79, 20);
            surnameLabel.TabIndex = 8;
            surnameLabel.Text = "KABADAYI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 9);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Patient Surname:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 11.25F);
            nameLabel.Location = new Point(3, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(60, 20);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Ibrahim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Patient Name:";
            // 
            // statusPictureBox
            // 
            statusPictureBox.Image = Resource1.Double_Tick;
            statusPictureBox.Location = new Point(240, 47);
            statusPictureBox.Name = "statusPictureBox";
            statusPictureBox.Size = new Size(27, 19);
            statusPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            statusPictureBox.TabIndex = 8;
            statusPictureBox.TabStop = false;
            statusPictureBox.Click += pictureBox1_Click;
            statusPictureBox.MouseEnter += statusPictureBox_MouseEnter;
            statusPictureBox.MouseLeave += statusPictureBox_MouseLeave;
            // 
            // docCommentPictureBox
            // 
            docCommentPictureBox.Image = Resource1.doc;
            docCommentPictureBox.Location = new Point(240, 143);
            docCommentPictureBox.Name = "docCommentPictureBox";
            docCommentPictureBox.Size = new Size(27, 19);
            docCommentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            docCommentPictureBox.TabIndex = 10;
            docCommentPictureBox.TabStop = false;
            docCommentPictureBox.Click += docCommentPictureBox_Click;
            docCommentPictureBox.MouseEnter += docCommentPictureBox_MouseEnter;
            docCommentPictureBox.MouseLeave += docCommentPictureBox_MouseLeave;
            // 
            // patientCommentPictureBox
            // 
            patientCommentPictureBox.BackColor = SystemColors.ControlLight;
            patientCommentPictureBox.Image = Resource1.Information;
            patientCommentPictureBox.Location = new Point(240, 96);
            patientCommentPictureBox.Name = "patientCommentPictureBox";
            patientCommentPictureBox.Size = new Size(27, 19);
            patientCommentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            patientCommentPictureBox.TabIndex = 9;
            patientCommentPictureBox.TabStop = false;
            patientCommentPictureBox.Click += patientCommentPictureBox_Click;
            patientCommentPictureBox.MouseEnter += patientCommentPictureBox_MouseEnter;
            patientCommentPictureBox.MouseLeave += patientCommentPictureBox_MouseLeave;
            // 
            // AppointmentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(docCommentPictureBox);
            Controls.Add(patientCommentPictureBox);
            Controls.Add(statusPictureBox);
            Name = "AppointmentUC";
            Size = new Size(290, 209);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)statusPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)docCommentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientCommentPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private PictureBox statusPictureBox;
        private PictureBox docCommentPictureBox;
        private PictureBox patientCommentPictureBox;
        public Label timeLabel;
        public Label dateLabel;
        public Label statusLabel;
        public Label gmailLabel;
        public Label telephoneLabel;
        public Label surnameLabel;
        public Label nameLabel;
    }
}
