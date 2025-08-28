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
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            registerButton = new Button();
            userTypeComboBox = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
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
            label3.Location = new Point(806, 272);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Palatino Linotype", 15.75F);
            passwordTextBox.Location = new Point(675, 461);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 36);
            passwordTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Palatino Linotype", 15.75F);
            emailTextBox.Location = new Point(806, 303);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 36);
            emailTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 15.75F);
            label6.Location = new Point(282, 433);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 10;
            label6.Text = "User Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 15.75F);
            label7.Location = new Point(675, 433);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 14;
            label7.Text = "Password";
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Palatino Linotype", 12F);
            registerButton.Location = new Point(372, 602);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(371, 64);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            registerButton.MouseEnter += registerButton_MouseEnter;
            registerButton.MouseLeave += registerButton_MouseLeave;
            // 
            // userTypeComboBox
            // 
            userTypeComboBox.Font = new Font("Microsoft Sans Serif", 15.75F);
            userTypeComboBox.FormattingEnabled = true;
            userTypeComboBox.Items.AddRange(new object[] { "Admin", "Doctor", "Patient" });
            userTypeComboBox.Location = new Point(282, 464);
            userTypeComboBox.Name = "userTypeComboBox";
            userTypeComboBox.Size = new Size(198, 33);
            userTypeComboBox.TabIndex = 16;
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
            label4.Location = new Point(470, 272);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 3;
            label4.Text = "Surname";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Palatino Linotype", 15.75F);
            nameTextBox.Location = new Point(102, 303);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(190, 36);
            nameTextBox.TabIndex = 5;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Font = new Font("Palatino Linotype", 15.75F);
            surnameTextBox.Location = new Point(470, 303);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(190, 36);
            surnameTextBox.TabIndex = 7;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(userTypeComboBox);
            Controls.Add(registerButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(emailTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
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
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Label label6;
        private Label label7;
        private Button registerButton;
        private ComboBox userTypeComboBox;
        private Label label2;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
    }
}
