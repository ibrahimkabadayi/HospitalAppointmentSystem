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
    public partial class Form2 : Form
    {
        private readonly int doctorID;
        private readonly IUnitOfWork _unitOfWork;
        public Form2(int id)
        {
            doctorID = id;
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
            ButtonAnimationHelper.SetupButtonAnimation(button1);
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            var doc = await _unitOfWork.Doctors.GetByIdAsync(doctorID);
            titleLabel.Text = "Welcome doctor " + doc.Name + " " + doc.Surname + "!";
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var appointments = await _unitOfWork.Appointments.FindAsync(x => x.DoctorID == doctorID && x.date.ToString().Equals(dateTextBox.Text));
            
            for(int i = 0; i < appointments.Count; i++) 
            {
                Appointments app = appointments[i];
                var patient = _unitOfWork.Patients.GetByIdAsync(app.PatientID);
                Patients patientObject = patient.Result;
                NoteDTO noteDTO = new NoteDTO(app.DoctorNote, app.PatientNote);
                StatusDTO statusDTO = new StatusDTO(app.status);

                AppointmentUC uc = new AppointmentUC(statusDTO, noteDTO, true, false, app.ID);
                uc.nameLabel.Text = patientObject.Name;
                uc.surnameLabel.Text = patientObject.Surname;
                uc.dateLabel.Text = app.date.ToString();
                uc.timeLabel.Text = app.time.ToString();
                uc.telephoneLabel.Text = patientObject.Telephone;
                uc.gmailLabel.Text = patientObject.Email;

                panel.Controls.Add(uc);
            }
        }
    }
}
