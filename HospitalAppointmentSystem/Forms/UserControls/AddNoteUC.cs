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
            ButtonAnimationHelper.SetupButtonAnimation(deleteButton);
            ButtonAnimationHelper.SetupButtonAnimation(button2);
        }

        public event Action<NoteDTO> OnNoteSave;
        private void AddNoteUC_Load(object sender, EventArgs e)
        {
            if (isDoctor)
                noteTextBox.Text = noteDTO.DoctorNote;
            else
                noteTextBox.Text = noteDTO.PatientNote;
        }
        private void button1_Click(object sender, EventArgs e)//Delete Button
        {
            noteTextBox.Text = string.Empty;
            if(isDoctor)
                noteDTO.DoctorNote = string.Empty;
            else 
                noteDTO.PatientNote = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)//Save and Close button
        {
            if(isDoctor)
                noteDTO.DoctorNote = noteTextBox.Text;
            else
                noteDTO.PatientNote = noteTextBox.Text;

            OnNoteSave?.Invoke(noteDTO);
        }
    }
}
