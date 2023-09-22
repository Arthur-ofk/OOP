using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Patient
    {
        public string Name { get; set; }
        public string Doctor { get; set; }
        public int Room { get; set; }
        public Patient(string patient, string doctor)
        {
            Name = patient;
            Doctor = doctor;
        }
    }
}
