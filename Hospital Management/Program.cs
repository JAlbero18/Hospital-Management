using Hospital_Management;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Welcome();
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome");
        Doctor adam = new Doctor("Adam", 32, "Calubian", 0912345, DateTime.Now, 110, "Skin");
        Patient jerson = new Patient("Jerson", 14, "Spillway", 0912345, DateTime.Now, 111, DateTime.Now);

        Patient a = new Patient("Safeguard", 14, "Spillway", 0912345, DateTime.Now, 111, DateTime.Now);

        Patient b = new Patient("Tide", 14, "Spillway", 0912345, DateTime.Now, 111, DateTime.Now);

        Patient c = new Patient("Zonrox", 14, "Spillway", 0912345, DateTime.Now, 111, DateTime.Now);

        adam.addPatient(jerson);
        adam.addPatient(a);
        adam.addPatient(b);
        adam.addPatient(c);
        Console.WriteLine("Doctors Name: " + adam.Birthdate);
        Console.WriteLine("Patient Name: " + jerson.Name);
        Console.WriteLine("Patient Age: " + jerson.Age);
        Console.WriteLine("Admission Date: " + jerson.AdmitDate);


        Console.WriteLine("List of Patients");
            foreach (Patient patient in adam.Patients)
        { 
            Console.WriteLine(patient.Name);
        }
    }
}