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
        //Status can be active and seen for the doctors and for the patients active and canceled.
        public StatusDTO(string status) 
        {
            this.status = status;
        }
       
    }
}
