using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    class Appointment
    {
        public DateTime Appointment_Schedule { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public void addAppointment(Doctor doctor, Patient patient, DateTime appointment_schedule)
        {
            Doctor = doctor;
            Patient = patient;
            Appointment_Schedule = appointment_schedule;
        }
    }
}
