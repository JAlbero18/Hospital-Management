using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    class Employee
    {
        public int Employee_Id { get; set; }
        public List<Doctor> Doctors { get; set; }

        /*public Employee(string name, int age, string address, int contactno, DateTime birthdate, int employee_id) : base(name, age, address, contactno, birthdate)
        {
            Employee_Id = employee_id;
            Doctors = new List<Doctor>();
        }*/

        public void addEmloyee(Doctor doctor)
        {
            Doctors.Add(doctor);
        }
    }

}
