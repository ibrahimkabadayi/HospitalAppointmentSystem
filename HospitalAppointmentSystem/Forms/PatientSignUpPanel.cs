using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAppointmentSystem.Forms
{
    public partial class PatientSignUpPanel : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public PatientSignUpPanel()
        {
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            passwordAgainTextBox.UseSystemPasswordChar = true;

            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string passwordAgain = passwordAgainTextBox.Text.Trim();
            string telephone = telephoneTextBox.Text.Trim();
            string birthDate = birthDateTextBox.Text.Trim();
            string ssn = ssnTextBox.Text.Trim();

            if (name.Length == 0 || surname.Length == 0 || email.Length == 0 ||
                password.Length == 0 || passwordAgain.Length == 0 || 
                telephone.Length == 0 || birthDate.Length == 0 || ssn.Length == 0 ||
                !email.Contains('@') || email.First() == '@' || email.Last() == '@') 
            {
                MessageBox.Show("Check your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!password.Equals(passwordAgain)) 
            {
                MessageBox.Show("Please check your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] array = birthDate.Split('.');

            int day = Convert.ToInt32(array[0]);
            int month = Convert.ToInt32(array[1]);
            int year = Convert.ToInt32(array[2]);

            DateOnly date = new DateOnly(day, month, year);

            var newPatient = new Patients { 
                Name = name,
                BirthDate = date,
                Surname = surname, 
                Email = email, 
                Password = password,
                SSN = ssn, 
                Telephone = telephone 
            };

            await _unitOfWork.Patients.AddAsync(newPatient);
            await _unitOfWork.SaveChangesAsync();
            MessageBox.Show("A new patient has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void returnToLoginButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginPage)
                {
                    LoginPage loginPage = (LoginPage)form;
                    loginPage.ShowMainMenu();
                    break;
                }
            }
        }

        private bool isPasswordVisible = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                passwordTextBox.UseSystemPasswordChar = true;
                pictureBox1.Image = Resource1.images; 
                isPasswordVisible = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
                pictureBox1.Image = Resource1.imgbin_eye_icon_eye_iCUuFjfMyPy2dJfgGRCGUqRcX;
                isPasswordVisible = true;
            }
        }

        private async void registerButton_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                registerButton.BackColor = Color.FromArgb(
                    255,
                    registerButton.BackColor.R + (int)((255 - registerButton.BackColor.R) * 0.1),
                    registerButton.BackColor.G + (int)((200 - registerButton.BackColor.G) * 0.1),
                    registerButton.BackColor.B
                );
                await Task.Delay(15);
            }
        }

        private async void registerButton_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                registerButton.BackColor = Color.FromArgb(
                    255,
                    registerButton.BackColor.R + (int)((240 - registerButton.BackColor.R) * 0.1),
                    registerButton.BackColor.G + (int)((240 - registerButton.BackColor.G) * 0.1),
                    registerButton.BackColor.B + (int)((240 - registerButton.BackColor.B) * 0.1)
                );
                await Task.Delay(15);
            }
        }

        private async void returnToLoginButton_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                registerButton.BackColor = Color.FromArgb(
                    255,
                    registerButton.BackColor.R + (int)((255 - registerButton.BackColor.R) * 0.1),
                    registerButton.BackColor.G + (int)((200 - registerButton.BackColor.G) * 0.1),
                    registerButton.BackColor.B
                );
                await Task.Delay(15);
            }
        }

        private async void returnToLoginButton_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                registerButton.BackColor = Color.FromArgb(
                    255,
                    registerButton.BackColor.R + (int)((240 - registerButton.BackColor.R) * 0.1),
                    registerButton.BackColor.G + (int)((240 - registerButton.BackColor.G) * 0.1),
                    registerButton.BackColor.B + (int)((240 - registerButton.BackColor.B) * 0.1)
                );
                await Task.Delay(15);
            }
        }
    }
}
