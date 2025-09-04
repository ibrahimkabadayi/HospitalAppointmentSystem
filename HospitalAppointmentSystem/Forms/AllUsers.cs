using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentSystem.Model_Classes;

namespace HospitalAppointmentSystem.Forms
{
    public partial class AllUsers : Form
    {
        int adminID;
        public AllUsers(int adminID)
        {
            InitializeComponent();
            this.adminID = adminID;
            ButtonAnimationHelper.SetupButtonAnimation(ReturnToAdminPageButton);
            ButtonAnimationHelper.SetupButtonAnimation(ReturnToLoginPageButton);
        }
        private Form currentForm;
        private void ReturnToLoginPageButton_Click_1(object sender, EventArgs e)
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
        private void ReturnToAdminPageButton_Click_1(object sender, EventArgs e)
        {
            Methods.ShowFormAsPanel(new Form5(adminID), this, ref currentForm);
        }
        private async void AllUsers_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new HospitalDbContext()))
            {
                List<Users> users = await uow.Users.GetAllAsync();
                List<string> txtList = new List<string>();

                foreach (Users user in users)
                {
                    string displayText = user.Name + "  " + user.Surname + "  " + user.Email + "  " + user.UserType + "  " + user.UserTypeID;
                    txtList.Add(displayText);
                }

                listBox1.DataSource = txtList;
            }
        }
    }
}
