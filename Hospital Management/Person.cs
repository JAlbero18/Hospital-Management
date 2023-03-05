using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital_Management
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int ContactNo { get; set; }
        public DateTime Birthdate { get; set; }

        public Person(string name, int age, string address, int contactno, DateTime birthdate)
        {
            Name = name;
            Age = age;
            Address = address;
            ContactNo = contactno;
            Birthdate = birthdate;
        }
    }
}
