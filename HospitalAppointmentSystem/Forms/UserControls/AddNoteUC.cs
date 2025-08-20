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
    public partial class AddNoteUC : UserControl
    {
        private NoteDTO noteDTO;
        private bool isDoctor;
        public AddNoteUC(NoteDTO noteDTO, bool isDoctor)
        {
            InitializeComponent();
            this.noteDTO = noteDTO;
            this.isDoctor = isDoctor;
        }

        private void AddNoteUC_Load(object sender, EventArgs e)
        {
            if (isDoctor)
                noteTextBox.Text = noteDTO.DoctorNote;
            else
                noteTextBox.Text = noteDTO.PatientNote;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noteTextBox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(isDoctor)
                noteDTO.DoctorNote = noteTextBox.Text;
            else
                noteDTO.PatientNote = noteTextBox.Text;

            Hide();
            Dispose();
        }
    }
}
