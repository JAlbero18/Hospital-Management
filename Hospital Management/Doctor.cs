using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    class Doctor : Person
    {
        public int Employee_ID { get; set; }
        public string Specialization { get; set; }


        public List<Patient> Patients = new List<Patient>();

        public Doctor(string name, int age, string address, int contactno, DateTime birthdate, int employee_id, string specialization) : base (name, age, address, contactno, birthdate)
        {
            Specialization = specialization;
        }

        public void addPatient(Patient patient)
        {
            Patients.Add(patient);
        }

    }
}
