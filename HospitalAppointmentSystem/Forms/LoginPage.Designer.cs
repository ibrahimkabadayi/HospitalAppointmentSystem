namespace HospitalAppointmentSystem
{
    partial class LoginPage
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
            label1 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(223, 68);
            label1.Name = "label1";
            label1.Size = new Size(686, 47);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Hospital Appointment System!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 15.75F);
            label3.Location = new Point(675, 433);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Palatino Linotype", 15.75F);
            textBox4.Location = new Point(806, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 36);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Palatino Linotype", 15.75F);
            textBox5.Location = new Point(675, 464);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 36);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 15.75F);
            label6.Location = new Point(470, 272);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 10;
            label6.Text = "User Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 15.75F);
            label7.Location = new Point(806, 272);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 14;
            label7.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 12F);
            button1.Location = new Point(372, 602);
            button1.Name = "button1";
            button1.Size = new Size(371, 64);
            button1.TabIndex = 15;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Doctor", "Patient" });
            comboBox1.Location = new Point(470, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 33);
            comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 15.75F);
            label2.Location = new Point(102, 272);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 15.75F);
            label4.Location = new Point(282, 433);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 3;
            label4.Text = "Surname";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Palatino Linotype", 15.75F);
            textBox1.Location = new Point(102, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 36);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Palatino Linotype", 15.75F);
            textBox3.Location = new Point(282, 464);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 36);
            textBox3.TabIndex = 7;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}
