using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Model_Classes;

namespace HospitalAppointmentSystem
{
    internal interface IUnitOfWork : IDisposable
    {
        IRepository<Branches> Branches { get; }
        IRepository<Doctors> Doctors { get; }
        IRepository<Patients> Patients { get; }
        IRepository<WorkingHours> WorkingHours { get; }
        IRepository<Appointments> Appointments { get; }
        IRepository<Admins> Admins { get; }
        IRepository<Users> Users { get; }
        Task<int> SaveChangesAsync();
    }
}
