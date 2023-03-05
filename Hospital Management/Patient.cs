using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    class Patient : Person
    {
        public int Patient_Id { get; set; }
        public DateTime AdmitDate { get; set; }

        public Patient(string name, int age, string address, int contactno, DateTime birthdate, int patient_Id, DateTime admitdate) : base (name, age, address, contactno, birthdate)
        {
            Patient_Id = patient_Id;
            AdmitDate = admitdate;
        }

    }
}
