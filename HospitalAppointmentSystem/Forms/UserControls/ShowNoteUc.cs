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
    public partial class ShowNoteUC : UserControl
    {
        private NoteDTO notes;
        private bool isDoctor;
        public ShowNoteUC(NoteDTO notes, bool isDoctor)
        {
            InitializeComponent();
            this.notes = notes;
            this.isDoctor = isDoctor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void ShowNoteUC_Load(object sender, EventArgs e)
        {
            if (isDoctor) 
                noteTextBox.Text = notes.DoctorNote;
            else 
                noteTextBox.Text = notes.PatientNote;
        }
    }
}
