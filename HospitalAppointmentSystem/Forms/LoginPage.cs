using System.Threading.Tasks;
using HospitalAppointmentSystem.Forms;
using HospitalAppointmentSystem.Model_Classes;

namespace HospitalAppointmentSystem
{
    public partial class LoginPage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public LoginPage()
        {
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        private Form currentForm;
        private void ShowFormAsPanel(Form formToShow)
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                this.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            currentForm = formToShow;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            this.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();

            this.Text = formToShow.Text;
        }
        private async void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string userType = userTypeComboBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

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
                    ShowFormAsPanel(new PatientSignUpPanel());
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
                    ShowFormAsPanel(new Form2(UserInServer.UserTypeID));
                }
                else if (userType.Equals("Admin"))
                {
                    ShowFormAsPanel(new Form5(UserInServer.UserTypeID));
                }
                else
                {
                    ShowFormAsPanel(new Form3(UserInServer.UserTypeID));
                }

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
                await Task.Delay(15); // küçük bekleme ile animasyon efekti
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
    }
}
