using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentSystem.Forms.DataTransferObjects;

namespace HospitalAppointmentSystem.Forms
{
    public partial class PatientAppointments : Form
    {
        private int PatientID;
        private readonly IUnitOfWork _unitOfWork;
        private Form currentForm;
        public PatientAppointments(int PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        private async void PatientAppointments_Load(object sender, EventArgs e)
        {
            var PatientAppointments = await _unitOfWork.Appointments.FindAsync(x => x.PatientID == PatientID);

            foreach (var appointment in PatientAppointments) 
            {
                var patient = await _unitOfWork.Patients.GetByIdAsync(PatientID);
                NoteDTO noteDTO = new NoteDTO(appointment.DoctorNote, appointment.PatientNote);
                StatusDTO statusDTO = new StatusDTO(appointment.status);
                AppointmentUC uc = new AppointmentUC(statusDTO, noteDTO, false, false, appointment.ID);
                uc.nameLabel.Text = patient.Name.ToString();
                uc.dateLabel.Text = appointment.date.ToString();
                uc.gmailLabel.Text = patient.Email.ToString();
                uc.statusLabel.Text = appointment.status.ToString();
                uc.telephoneLabel.Text = patient.Telephone.ToString();
                uc.timeLabel.Text = appointment.time.ToString();
                uc.surnameLabel.Text = patient.Surname.ToString();
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void ReturnToPatientPageButton_Click(object sender, EventArgs e)
        {
            ShowFormAsPanel(new Form3(PatientID));
        }

        private void ReturnToLoginPageButton_Click(object sender, EventArgs e)
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

        private void ReturnToPatientPageButton_MouseEnter(object sender, EventArgs e)
        {
            Methods.ButtonMouseEnter(ReturnToPatientPageButton);
        }

        private void ReturnToPatientPageButton_MouseLeave(object sender, EventArgs e)
        {
            Methods.ButtonMouseLeave(ReturnToPatientPageButton);
        }

        private void ReturnToLoginPageButton_MouseEnter(object sender, EventArgs e)
        {
            Methods.ButtonMouseEnter(ReturnToLoginPageButton);
        }

        private void ReturnToLoginPageButton_MouseLeave(object sender, EventArgs e)
        {
            Methods.ButtonMouseLeave(ReturnToLoginPageButton);
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
    }
}
