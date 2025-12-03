using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Bot
    {
        public static void main()
        {
            // 1. Introduction
            Console.WriteLine("========================================");
            Console.WriteLine("   Hello, I am Bob, your Medical Bot.");
            Console.WriteLine("========================================");

            // 2. Gather User Input
            Console.Write("Please enter the patient's name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter the patient's age: ");
            // Basic error handling to ensure age is a number
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age entered. Please restart and enter a number.");
                return;
            }

            Console.WriteLine("\nChoose a symptom from the following: ");
            Console.WriteLine("1. Headache");
            Console.WriteLine("2. Skin Rashes");
            Console.WriteLine("3. Dizziness");
            Console.WriteLine("4. Fever");

            Console.Write("\nEnter Symptom: ");
            string symptom = Console.ReadLine().ToLower();

            // 3. Call the logic method (Passing arguments)
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("PROCESSING PRESCRIPTION...");
            Console.WriteLine("----------------------------------------");

            string prescription = PrescribeMedication(symptom, age);

            // 4. Final Output
            Console.WriteLine($"\nPatient: {name}");
            Console.WriteLine($"Dr. Bob says: {prescription}");
            Console.ReadKey();
        }

        // This method handles the logic based on the arguments passed
        static string PrescribeMedication(string symptom, int age)
        {
            string medication;

            switch (symptom)
            {
                case "headache":
                    if (age < 12)
                        medication = "Take 5ml of Children's Ibuprofen syrup.";
                    else
                        medication = "Take one 400mg Ibuprofen tablet.";
                    break;

                case "skin rashes":
                case "rashes":
                    medication = "Apply Hydrocortisone cream twice a day to the affected area.";
                    break;

                case "dizziness":
                    if (age > 60)
                        medication = "Please sit down and drink water. If it persists, call emergency services immediately.";
                    else
                        medication = "Rest in a quiet, dark room and ensure you are hydrated.";
                    break;

                case "fever":
                    if (age < 3)
                        medication = "WARNING: Please visit a real doctor immediately. High fever in toddlers is dangerous.";
                    else if (age < 12)
                        medication = "Take 5ml of Children's Acetaminophen.";
                    else
                        medication = "Take one 500mg Paracetamol tablet every 6 hours.";
                    break;

                default:
                    medication = "I do not recognize that symptom. Please consult a human doctor.";
                    break;
            }

            return medication;
        }
    }
}
