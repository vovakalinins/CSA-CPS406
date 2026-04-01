using System;
using System.Linq;

namespace CSA406
{
    public static class StudentApplication
    {
        public static Applicant Apply(string Name, string StudentID, string Email)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name is empty");
            }
            if (string.IsNullOrEmpty(StudentID))
            {
                throw new Exception("Student ID is empty");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("Email is empty");
            }

            if (!StudentID.All(char.IsDigit))
            {
                throw new Exception("Student ID must only contain numbers");
            }

            if (StudentID.Length != 9)
            {
                throw new Exception("Student ID must contain 9 numbers");
            }

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
