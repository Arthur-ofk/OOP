using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Hospital
    {
        public Dictionary<string, Department> Departments { get; set; }
        public Dictionary<string, string> PatientInDepartment { get; set; }
        public Dictionary<string, string> PatientToDoctor { get; set; }

        public Hospital()
        {
            Departments = new Dictionary<string, Department>();
            PatientInDepartment = new Dictionary<string, string>();
            PatientToDoctor = new Dictionary<string, string>();
        }

        public void AddPatient(string department, string doctor, string patient)
        {
            Patient newPatient = RegisterPatient(patient, doctor); 
            
            PatientInDepartment[patient] = department;
            PatientToDoctor[patient] = doctor;

            if (!Departments.ContainsKey(department))
                Departments[department] = new Department(department);

            foreach (var room in Departments[department].Rooms)
            {
                if (room.Value.Count < 3)
                {
                    newPatient.Room = room.Key;
                    room.Value.Add(newPatient);
                    return;
                }
            }
        }
        private Patient RegisterPatient(string patient, string doctor)
        {
            return new Patient(patient, doctor);
        }
    }
}
