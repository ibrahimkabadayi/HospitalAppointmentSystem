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
    public partial class Form4 : Form
    {
        int doctorID;
        int adminID;
        private Form currentForm;
        public Form4(int doctorID, int adminID)
        {
            InitializeComponent();
            this.doctorID = doctorID;
            this.adminID = adminID;
            ButtonAnimationHelper.SetupButtonAnimation(ReturnToAdminPageButton);
            ButtonAnimationHelper.SetupButtonAnimation(ReturnToLoginPageButton);
        }
        private async void Form4_Load(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork(new HospitalDbContext()))
            {
                var appointments = await uow.Appointments.FindAsync(x => x.DoctorID == doctorID);
                List<Appointments> list = appointments;

                foreach (var appointment in list)
                {
                    var patient = await uow.Patients.GetByIdAsync(appointment.PatientID);
                    NoteDTO noteDTO = new NoteDTO(appointment.DoctorNote, appointment.PatientNote);
                    StatusDTO statusDTO = new StatusDTO(appointment.status);
                    AppointmentUC uc = new AppointmentUC(statusDTO, noteDTO, false, true, appointment.ID);
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
        private void ReturnToAdminPageButton_Click(object sender, EventArgs e)
        {
            Methods.ShowFormAsPanel(new Form5(adminID), this, ref currentForm);
        }
    }
}