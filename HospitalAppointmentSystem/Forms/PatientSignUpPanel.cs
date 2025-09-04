
using HospitalAppointmentSystem.Model_Classes;

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
            ButtonAnimationHelper.SetupButtonAnimation(registerButton);
            ButtonAnimationHelper.SetupButtonAnimation(returnToLoginButton);
        }
        private async void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string passwordAgain = passwordAgainTextBox.Text.Trim();
            string telephone = telephoneTextBox.Text.Trim();
            string birthDate = birthDateTextBox.Text.Trim();
            string ssn = ssnTextBox.Text.Trim();

            if(Methods.LengthOfLongestSubstring(password) < 4) 
            {
                MessageBox.Show("Try a different password with different chars.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            int patientCount = (await _unitOfWork.Patients.GetAllAsync()).Count();

            var newPatient = new Patients 
            { 
                ID = patientCount + 1,
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

            var registiredPatient = await _unitOfWork.Patients.FindAsync(x => x.SSN == ssn);

            var newUser = new Users
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                UserType = "Patient",
                UserTypeID = registiredPatient.First().ID
            };

            await _unitOfWork.Users.AddAsync(newUser);
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
                pictureBox1.Image = Images.images; 
                isPasswordVisible = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
                pictureBox1.Image = Images.imgbin_eye_icon_eye_iCUuFjfMyPy2dJfgGRCGUqRcX;
                isPasswordVisible = true;
            }
        }
    }
}
