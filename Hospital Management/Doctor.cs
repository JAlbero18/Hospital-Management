using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    class Doctor : Person
    {
        public int Doctors_Id { get; set; }
        public string Specialization { get; set; }

        public List<Patient> Patients { get; set; }

        public Doctor(string name, int age, string address, int contactno, DateTime birthdate, int id, string specialization) : base (name, age, address, contactno, birthdate)
        {
            Doctors_Id = id;
            Specialization = specialization;
            Patients = new List<Patient>();
        }

        public void addPatient(Patient patient)
        {
            Patients.Add(patient);
        }

    }
}
