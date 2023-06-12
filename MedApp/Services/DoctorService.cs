using MedApp.Domain.Models;
using MedApp.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.Services
{
    public class DoctorService
    {
        private readonly ApplicationDbContext context;

        public DoctorService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Doctor>> Get()
        {
            var doctorList = await context.Doctors.ToListAsync();

            return doctorList;
        }

        public async Task<Doctor> Get(string id)
        {
            var status = Guid.TryParse(id, out var doctorId);
            var doctor = await context.Doctors.FirstOrDefaultAsync(x => x.Id == doctorId);

            return doctor;
        }

        public async Task<List<string>> GetByName()
        {
            var doctorList = await context.Doctors.Select(x => x.Name).ToListAsync();

            return doctorList;
        }

        public async Task Post(string name, string specialization)
        {
            var doctor = new Doctor()
            {
                Name = name,
                Specialization = specialization
            };

            if (!context.Doctors.Where(x => x.Name == name).Any())
                await context.Doctors.AddAsync(doctor);
            await context.SaveChangesAsync();
        }

        public async Task Put(string id, string name, string specialization)
        {
            var status = Guid.TryParse(id, out var doctorId);
            var doctor = await context.Doctors.FirstOrDefaultAsync(x => x.Id == doctorId);

            doctor.Name = name;
            doctor.Specialization = specialization;

            await context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var status = Guid.TryParse(id, out var doctorId);
            var doctor = await context.Doctors.FirstOrDefaultAsync(x => x.Id == doctorId);

            context.Doctors.Remove(doctor);
            await context.SaveChangesAsync();
        }
    }
}