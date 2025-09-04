using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace HospitalAppointmentSystem.Forms
{
    public partial class Form3 : Form
    {
        int patientID;
        private readonly IUnitOfWork _unitOfWork;
        private Form currentForm;
        public Form3(int id)
        {
            patientID = id;
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
            ButtonAnimationHelper.SetupButtonAnimation(button1);
            ButtonAnimationHelper.SetupButtonAnimation(appointButton);
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            var patient = await _unitOfWork.Patients.GetByIdAsync(patientID);
            titleLabel.Text = "Welcome " + patient.Name + " " + patient.Surname + "!";
            
            var allBranches = await _unitOfWork.Branches.GetAllAsync();
            List<string> branchestxt = new List<string>();

            foreach (var branch in allBranches) 
            {
                branchestxt.Add(branch.Name);
            }

            branchesListBox.DataSource = branchestxt;
        }
        private async void brachesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBranch = branchesListBox.SelectedItems[0];
            if (selectedBranch == null) { return; }
            
            var branch = await _unitOfWork.Branches.FindAsync(x => x.Name.Equals(selectedBranch.ToString()));
            var doctors = await _unitOfWork.Doctors.FindAsync(x => x.BranchID == branch.First().ID);
            
            List<string> doctortxt = new List<string>();

            foreach (var doctor in doctors) 
            {
                doctortxt.Add(doctor.Name + " " +  doctor.Surname);
            }

            doctorsListBox.DataSource = doctortxt;
        }
        private async void doctorsTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (branchesListBox.SelectedIndex == -1) { return; }

            var selectedDoctor = doctorsListBox.SelectedItems[0];
            if (selectedDoctor == null) { return; }

            string[] array = selectedDoctor.ToString().Split(' ');
            string name = array[0];
            string surname = array[1];

            var doctor = await _unitOfWork.Doctors.FindAsync(x => (x.Name.Equals(name) && x.Surname.Equals(surname)));
            var WorkingHours = await _unitOfWork.WorkingHours.GetByIdAsync(doctor.First().WorkingHoursID);

            string enteredDate = dateTextBox.Text.Trim();

            if(enteredDate.IsNullOrEmpty() || enteredDate.Contains(' ')) 
            {
                MessageBox.Show("Please enter the date correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] dateArray = enteredDate.Split('.');
            DateOnly date = new DateOnly(Convert.ToInt32(dateArray[2]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[0]));

            var appointmentsOnThatDate = await _unitOfWork.Appointments.FindAsync(x => (x.date.Equals(date) && x.DoctorID == doctor.First().ID));

            List<TimeOnly> apphours = new List<TimeOnly>();
            List<TimeOnly> hours = new List<TimeOnly>();

            foreach (var app in appointmentsOnThatDate) 
            {
                apphours.Add(app.time);
            }

            TimeOnly startTime = WorkingHours.StartTime;

            for(int i = 0; i < 8; i++) 
            {
                TimeOnly hour = new TimeOnly(startTime.Hour + i, 0);
                if(!apphours.Contains(hour)) 
                hours.Add(hour);
            }

            for(int i = 0; i < hours.Count; i++) 
            {
                timeListBox.Items.Add(hours[i].ToShortTimeString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Methods.ShowFormAsPanel(new PatientAppointments(patientID), this, ref currentForm);
        }
        private async void appointButton_Click(object sender, EventArgs e)
        {
            string dateEntered = dateTextBox.Text.Trim();
            if(dateEntered.IsNullOrEmpty() || dateEntered.Contains(' ') || dateEntered.Length < 10) 
            {
                MessageBox.Show("Please enter the date correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (branchesListBox.SelectedIndex == -1 || doctorsListBox.SelectedIndex == -1 || timeListBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select the values from the tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] doctorTextArray = doctorsListBox.SelectedItems[0].ToString().Split(' ');
            string doctorName = doctorTextArray[0];
            string doctorSurname = doctorTextArray[1];

            var doctor = await _unitOfWork.Doctors.FindAsync(x => (x.Name.Equals(doctorName) && x.Surname.Equals(doctorSurname)));
            int doctorID = doctor.First().ID;

            string[] selectedHourArray = timeListBox.SelectedItems[0].ToString().Split(':');
            int selectedHour = Convert.ToInt32(selectedHourArray[0]);
            TimeOnly appointmentHour = new TimeOnly(selectedHour,0);

            string selectedBranch = branchesListBox.SelectedItems[0].ToString();
            var branch = await _unitOfWork.Branches.FindAsync(x => x.Name.Equals(selectedBranch));

            string[] dateArray = dateEntered.Split('.');
            DateOnly date = new DateOnly(Convert.ToInt32(dateArray[2]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[0]));

            Appointments appointment = new Appointments { date = date , DoctorID = doctorID, PatientID = patientID, status = "Active", time = appointmentHour, DoctorNote = "", PatientNote = ""};

            await _unitOfWork.Appointments.AddAsync(appointment);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
