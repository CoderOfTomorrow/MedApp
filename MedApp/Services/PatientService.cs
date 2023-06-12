using MedApp.Domain.Models;
using MedApp.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedApp.Services
{
    public class PatientService
    {
        private readonly ApplicationDbContext context;

        public PatientService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Patient>> Get()
        {
            var list = await context.Patients.ToListAsync();

            return list;
        }

        public async Task Put(string name, string doctor)
        {
            var patient = new Patient()
            {
                Name = name,
                DoctorName = doctor
            };

            var doctorData = await context.Doctors.FirstOrDefaultAsync(x => x.Name == doctor);
            doctorData.AddPatient();

            await context.Patients.AddAsync(patient);
            await context.SaveChangesAsync();
        }
    }
}