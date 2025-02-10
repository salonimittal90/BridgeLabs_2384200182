using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfEncapsulation
{


    // Interface for Medical Records
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // Abstract Class for Patients
    abstract class Patient : IMedicalRecord
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;
        private List<string> medicalHistory = new List<string>();

        // Constructor
        public Patient(int id, string name, int age, string diagnosis)
        {
            this.patientId = id;
            this.name = name;
            this.age = age;
            this.diagnosis = diagnosis;
        }

        // Encapsulation - Properties
        public int PatientId { get { return patientId; } }
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public string Diagnosis { get { return diagnosis; } }

        // Abstract Method for Bill Calculation
        public abstract double CalculateBill();

        // Concrete Method to Get Patient Details
        public void GetPatientDetails()
        {
            Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}, Diagnosis: {Diagnosis}");
        }

        // Interface Methods for Medical Records
        public void AddRecord(string record)
        {
            medicalHistory.Add(record);
            Console.WriteLine($"Medical record added for {Name}");
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Medical Records for {Name}:");
            foreach (var record in medicalHistory)
            {
                Console.WriteLine($"- {record}");
            }
        }
    }

    // InPatient Class
    class InPatient : Patient
    {
        private int daysAdmitted;
        private double dailyRate;

        public InPatient(int id, string name, int age, string diagnosis, int days, double rate)
            : base(id, name, age, diagnosis)
        {
            this.daysAdmitted = days;
            this.dailyRate = rate;
        }

        public override double CalculateBill()
        {
            return daysAdmitted * dailyRate + 5000;  // ₹5000 additional charge for hospitalization
        }
    }

    // OutPatient Class
    class OutPatient : Patient
    {
        private double consultationFee;

        public OutPatient(int id, string name, int age, string diagnosis, double fee)
            : base(id, name, age, diagnosis)
        {
            this.consultationFee = fee;
        }

        public override double CalculateBill()
        {
            return consultationFee;  // Only consultation fee for outpatients
        }
    }

}
