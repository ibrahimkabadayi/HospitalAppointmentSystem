using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Model_Classes;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalDbContext _context;
        private IRepository<Appointments> _Appointments;
        private IRepository<Doctors> _Doctors;
        private IRepository<Patients> _Patients;
        private IRepository<Branches> _Branches;
        private IRepository<WorkingHours> _WorkingHours;
        private IRepository<Admins> _Admins;
        private IRepository<Users> _Users;

        public UnitOfWork(HospitalDbContext context)
        {
            _context = context;
        }
        public IRepository<Branches> Branches => _Branches ??= new Repository<Branches>(_context);
        public IRepository<Doctors> Doctors => _Doctors ??= new Repository<Doctors>(_context);
        public IRepository<Patients> Patients => _Patients ??= new Repository<Patients>(_context);
        public IRepository<WorkingHours> WorkingHours => _WorkingHours ??= new Repository<WorkingHours>(_context);
        public IRepository<Appointments> Appointments => _Appointments ??= new Repository<Appointments>(_context);
        public IRepository<Users> Users => _Users ??= new Repository<Users>(_context);
        public IRepository<Admins> Admins => _Admins ??= new Repository<Admins>(_context);

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
