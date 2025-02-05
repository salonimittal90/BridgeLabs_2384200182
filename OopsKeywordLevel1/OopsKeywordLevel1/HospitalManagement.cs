using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OopsKeywordLevel1
{
    internal class HospitalManagement
    {
        // Static variable shared among all patients
        private static string HospitalName = "City General Hospital";
        private static int TotalPatients = 0; // Keeps track of total patients admitted

        // Readonly variable to ensure PatientID is immutable
        private readonly int PatientID;
        private string Name;
        private int Age;
        private string Ailment;

        // Constructor using 'this' keyword
        public HospitalManagement(int patientID, string name, int age, string ailment)
        {
            this.PatientID = patientID;
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            TotalPatients++; // Increment total patients count
        }

        // Static method to display total number of patients
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients Admitted: " + TotalPatients);
        }

        // Method to display patient details, using 'is' operator
        public void DisplayPatientDetails()
        {
            if (this is HospitalManagement)
            {
                Console.WriteLine("\nPatient Details:");
                Console.WriteLine("Hospital: " + HospitalName);
                Console.WriteLine("Patient ID: " + this.PatientID);
                Console.WriteLine("Name: " + this.Name);
                Console.WriteLine("Age: " + this.Age);
                Console.WriteLine("Ailment: " + this.Ailment);
            }
            else
            {
                Console.WriteLine("Invalid patient object.");
            }
        }
    }
}

