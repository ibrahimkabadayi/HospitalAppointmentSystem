using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Forms.DataTransferObjects
{
    public class StatusDTO
    { 
        public string status { get; set; } 
        public StatusDTO(string status) 
        {
            this.status = status;
        }      
    }
}
