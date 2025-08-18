using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    internal class Appointments
    {
        public required int ID { get; set; }
        public required int DoctorID { get; set; }
        public required int PatientID { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }
        public string status { get; set; } 
    }
}
