using System.Collections.Generic;

namespace MedApp.Domain.Models
{
    public class Doctor : Entity
    {
        public Doctor()
        {
        }

        public string Name { get; set; }
        public string Specialization { get; set; }
        public List<Patient> Patients { get; set; }
        public int PatientsCount { get; set; } = 0;

        public void AddPatient()
        {
            PatientsCount++;
        }
    }
}