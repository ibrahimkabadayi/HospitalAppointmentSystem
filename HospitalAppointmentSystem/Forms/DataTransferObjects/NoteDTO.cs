using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Forms.DataTransferObjects
{
    public class NoteDTO
    {
        public string? DoctorNote { get; set; }
        public string? PatientNote { get; set; }

        public NoteDTO(string DoctorNote, string PatientNote) 
        {
            this.DoctorNote = DoctorNote;
            this.PatientNote = PatientNote;
        }
    }
}
