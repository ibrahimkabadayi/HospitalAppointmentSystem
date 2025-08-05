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
        public int DoctorID { get; set; }
        public required string PatientID { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }
        public required string status { get; set; } 
    }
}
