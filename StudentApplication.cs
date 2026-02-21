//using Newtonsoft.Json;
using System;
using System.Linq;


namespace CSA406
{
    public static class StudentApplication
    {
        public static Applicant Apply(string Name, string StudentID, string Email)
        {
            Console.WriteLine("Applying for student application...");

            // Ensure that name stuid and email are not empty
            if (String.IsNullOrEmpty(Name))
            {
                throw new Exception("Name is empty");
            }
            if (String.IsNullOrEmpty(StudentID))
            {
                throw new Exception("Student ID is empty");
            }
            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("Email is empty");
            }

            // Ensure studentid only contains numbers
            if (!StudentID.All(char.IsDigit))
            {
                throw new Exception("Student ID must only contain numbers");
            }

            if (StudentID.Length != 9)
            {
                throw new Exception("Student ID must contain 9 numbers");
            }

            // Ensure email contains @ and .
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                throw new Exception("Email must contain @ and .");
            }

            var newApplicant = new Applicant
            {
                ID = Guid.NewGuid().ToString(),
                Name = Name,
                StudentID = StudentID,
                Email = Email
            };

            Data.saveApplicant(newApplicant);

            return newApplicant;
        }
    }
}
