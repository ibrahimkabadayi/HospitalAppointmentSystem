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
using Microsoft.VisualBasic.ApplicationServices;

namespace HospitalAppointmentSystem.Forms
{
    public partial class Form5 : Form
    {
        int adminId;
        private readonly int doctorID;
        private readonly IUnitOfWork _unitOfWork;
        private Form currentForm;
        public Form5(int id)
        {
            adminId = id;
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        private async void button1_Click(object sender, EventArgs e) //Register Button
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string email = emailTextBox.Text;
            string branch = branchTextBox.Text;
            string workingHours = timeComboBox.Text;

            if (name.Length == 0 || surname.Length == 0 || branch.Length == 0 || email.Length == 0 || !email.Contains("@"))
            {
                MessageBox.Show("Check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new Users { Name = name, Surname = surname, Email = email, UserType = "Doctor"};

            if (!await _unitOfWork.Users.CheckUserAsync(user)) 
            {
                MessageBox.Show("This doctor already exist in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] hours = workingHours.Split('-');
            string[] startTime = hours[0].Trim().Split(':');
            string[] endTime = hours[1].Trim().Split(':');

            TimeOnly startTimeOb = new TimeOnly(Convert.ToInt32(startTime[0]), Convert.ToInt32(startTime[1]));
            TimeOnly endTimeOb = new TimeOnly(Convert.ToInt32(endTime[0]), Convert.ToInt32(endTime[1]));

            var workingHoursOb = await _unitOfWork.WorkingHours.FindAsync(x => (x.StartTime.Equals(startTimeOb) && x.EndTime.Equals(endTimeOb)));
            var branchOb = await _unitOfWork.Branches.FindAsync(x => x.Name.Equals(branch));

            int branchID;
            int workingHoursID;

            try
            {
                branchID = branchOb.Take(1).FirstOrDefault().ID;
                workingHoursID = workingHoursOb.Take(1).FirstOrDefault().ID;
            } 
            catch (ArgumentNullException ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var doctor = new Doctors { Name = name, Surname = surname, BranchID = branchID, WorkingHoursID = workingHoursID };
            await _unitOfWork.Doctors.AddAsync(doctor);
            await _unitOfWork.SaveChangesAsync();
        }

        private async void button2_Click(object sender, EventArgs e) //Delete Button
        {
            if (doctorsList.SelectedItems.Count == 0 || doctorsList.SelectedItem == null)
            {
                MessageBox.Show("Please Select a doctor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string txt = doctorsList.SelectedItem.ToString();
            string[] array = txt.Split(' ');

            int doctorID = Convert.ToInt32(array[0]);

            await _unitOfWork.Doctors.DeleteAsync(doctorID);
            await _unitOfWork.SaveChangesAsync();

            performLoadForListBox(doctorsList);
        }

        private void button3_Click(object sender, EventArgs e) //See all Appointments Button
        {
            if (doctorsList.SelectedItems.Count == 0 || doctorsList.SelectedItem == null)
            {
                MessageBox.Show("Please Select a doctor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string txt = doctorsList.SelectedItem.ToString();
            string[] array = txt.Split(' ');

            int doctorID = Convert.ToInt32(array[0]);

            ShowFormAsPanel(new Form4(doctorID, adminId));
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            performLoadForListBox(doctorsList);
        }

        private async void performLoadForListBox(ListBox listBox)
        {
            List<Doctors> list = await _unitOfWork.Doctors.GetAllAsync();
            List<String> txtList = new List<String>();

            for (int i = 0; i < list.Count; i++)
            {
                var doctor = list[i];
                string displayText = string.Empty;

                var branch = _unitOfWork.Branches.GetByIdAsync(doctor.BranchID);

                var time = _unitOfWork.WorkingHours.GetByIdAsync(doctor.WorkingHoursID);

                displayText += doctor.ID + " " + doctor.Name + " " + doctor.Surname + " " + branch.Result.Name
                     + time.Result.StartTime.ToString() + "-" + time.Result.EndTime.ToString();

                txtList.Add(displayText);
            }

            listBox.DataSource = txtList;
        }

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

        private void seeAllUsersButton_Click(object sender, EventArgs e)
        {

        }
    }
}
