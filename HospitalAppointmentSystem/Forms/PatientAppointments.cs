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
            ButtonAnimationHelper.SetupButtonAnimation(ReturnToLoginPageButton);
            ButtonAnimationHelper.SetupButtonAnimation(ReturnToPatientPageButton);
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
            Methods.ShowFormAsPanel(new Form3(PatientID), this, ref currentForm);
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
    }
}
