using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    internal interface IUnitOfWork
    {
        IRepository<Branches> Branches { get; }
        IRepository<Doctors> Doctors { get; }
        IRepository<Patients> Patients { get; }
        IRepository<WorkingHours> WorkingHours { get; }
        IRepository<Appointments> Appointments { get; }
        Task<int> SaveChangesAsync();
    }
}
