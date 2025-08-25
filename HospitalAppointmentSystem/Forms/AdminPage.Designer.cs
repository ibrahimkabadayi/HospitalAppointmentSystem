namespace HospitalAppointmentSystem.Forms
{
    partial class Form5
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
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            registerButton = new Button();
            deleteButton = new Button();
            titleLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            seeAllAppointmentsButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 584);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F);
            label1.Location = new Point(21, 139);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Palatino Linotype", 15.75F);
            textBox1.Location = new Point(21, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 36);
            textBox1.TabIndex = 6;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Palatino Linotype", 15.75F);
            registerButton.Location = new Point(21, 593);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(501, 75);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Palatino Linotype", 15.75F);
            deleteButton.Location = new Point(0, 593);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(273, 75);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += button2_Click;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Palatino Linotype", 26.25F);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1112, 100);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Welcome Admin!";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 100);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(registerButton);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 671);
            panel2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Palatino Linotype", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 513);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 36);
            comboBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Palatino Linotype", 15.75F);
            textBox4.Location = new Point(21, 360);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 36);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Palatino Linotype", 15.75F);
            textBox3.Location = new Point(341, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 36);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Palatino Linotype", 15.75F);
            textBox2.Location = new Point(341, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 36);
            textBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.Font = new Font("Palatino Linotype", 15.75F);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(539, 73);
            label6.TabIndex = 6;
            label6.Text = "To register a doctor please fill the form";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 15.75F);
            label5.Location = new Point(21, 329);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 15.75F);
            label4.Location = new Point(341, 329);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 4;
            label4.Text = "Branch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 15.75F);
            label3.Location = new Point(341, 139);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 3;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 15.75F);
            label2.Location = new Point(169, 482);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 2;
            label2.Text = "Working Hours";
            // 
            // panel3
            // 
            panel3.Controls.Add(seeAllAppointmentsButton);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(557, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 671);
            panel3.TabIndex = 16;
            // 
            // seeAllAppointmentsButton
            // 
            seeAllAppointmentsButton.Font = new Font("Palatino Linotype", 15.75F);
            seeAllAppointmentsButton.Location = new Point(279, 593);
            seeAllAppointmentsButton.Name = "seeAllAppointmentsButton";
            seeAllAppointmentsButton.Size = new Size(285, 75);
            seeAllAppointmentsButton.TabIndex = 0;
            seeAllAppointmentsButton.Text = "See All Appointments";
            seeAllAppointmentsButton.UseVisualStyleBackColor = true;
            seeAllAppointmentsButton.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Button registerButton;
        private Button deleteButton;
        private Label titleLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button seeAllAppointmentsButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
    }
}