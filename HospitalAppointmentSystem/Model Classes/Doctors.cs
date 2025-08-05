using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    internal class Doctors
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BranchID { get; set; }
        public int WorkingHoursID { get; set; }
        public string Password { get; set; }
    }
}
