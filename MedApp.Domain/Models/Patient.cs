using System;

namespace MedApp.Domain.Models
{
    public class Patient : Entity
    {
        public Patient()
        {
            Date = DateTime.UtcNow;
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string DoctorName { get; set; }
    }
}