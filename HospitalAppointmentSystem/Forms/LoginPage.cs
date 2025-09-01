using System.Threading.Tasks;
using HospitalAppointmentSystem.Forms;
using HospitalAppointmentSystem.Model_Classes;
using Microsoft.IdentityModel.Tokens;

namespace HospitalAppointmentSystem
{
    public partial class LoginPage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private bool isNoPasswordDoctor = false;
        private int doctorIDWithNoPassword = 0;
        public LoginPage()
        {
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
            ButtonAnimationHelper.SetupButtonAnimation(registerButton);
        }

        private Form currentForm;
        public void ShowMainMenu()
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                this.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            this.Text = "LoginPage";

            foreach (Control control in this.Controls)
            {
                if (control is Button || control is Label)
                {
                    control.Visible = true;
                }
            }
        }
        private async void registerButton_Click(object sender, EventArgs e)
        {

            if (isNoPasswordDoctor) 
            {
                string newPassword = passwordTextBox.Text.Trim();

                if (string.IsNullOrEmpty(newPassword) || Methods.LengthOfLongestSubstring(newPassword) < 4)
                {
                    MessageBox.Show("Try a different password with different chars.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var doctor = await _unitOfWork.Doctors.GetByIdAsync(doctorIDWithNoPassword);
                doctor.Password = newPassword;
                await _unitOfWork.Doctors.UpdateAsync(doctor);
                await _unitOfWork.SaveChangesAsync();

                MessageBox.Show("Password is succesfully registired now enter with your new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string userType = userTypeComboBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            
            if(!(name.Length == 0 || surname.Length == 0 || userType.Length == 0 || email.Length == 0 || !email.Contains("@"))
                && (await _unitOfWork.Doctors.FindAsync(x => x.Name.Equals(name) && x.Surname.Equals(surname) && x.Email.Equals(email) && x.Password.IsNullOrEmpty())).Count > 0) 
            {
                DialogResult result = MessageBox.Show("It seems like you have no password registired in the system." +
                    " Would you want to register a password?",
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isNoPasswordDoctor = true;
                    doctorIDWithNoPassword = (await _unitOfWork.Doctors.FindAsync(x => x.Name.Equals(name) && x.Surname.Equals(surname) && x.Email.Equals(email) && x.Password.IsNullOrEmpty())).First().ID;
                    return;
                }
                return;
            }
            else 
            {
                isNoPasswordDoctor = false;
                doctorIDWithNoPassword = 0;
            }

            if (name.Length == 0 || surname.Length == 0 || userType.Length == 0 || password.Length == 0 || email.Length == 0 || !email.Contains("@"))
            {
                MessageBox.Show("Check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new Users { Name = name, Password = password, Email = email };

            if (!await _unitOfWork.Users.CheckUserAsync(user))
            {
                DialogResult result = MessageBox.Show("It seems like you did not registered in the system," +
                    "Would you like to sign up an a patient?",
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Methods.ShowFormAsPanel(new PatientSignUpPanel(), this, ref currentForm);
                    return;
                }
                return;
            }
            else
            {
                var UsersInList = await _unitOfWork.Users.FindAsync(s => s.Name == name &&
                s.Surname == surname &&
                s.Email == email &&
                s.Password == password);

                var UserInServer = UsersInList.FirstOrDefault();

                if (userType.Equals("Doctor"))
                {
                    Methods.ShowFormAsPanel(new Form2(UserInServer.UserTypeID), this, ref currentForm);
                }
                else if (userType.Equals("Admin"))
                {
                    Methods.ShowFormAsPanel(new Form5(UserInServer.UserTypeID), this, ref currentForm);
                }
                else
                {
                    Methods.ShowFormAsPanel(new Form3(UserInServer.UserTypeID), this, ref currentForm);
                }

            }
        }
    }
}
