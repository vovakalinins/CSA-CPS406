using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSA406
{
    public class Applicant
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string StudentID { get; set; }
        public string Email { get; set; }
        public string Status { get; set; } = "Pending";
        public string FinalDecision { get; set; } = "Pending";
        public string SubmissionDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public string LastModified { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public static class Data
    {
        public static string filePath = "applicants.json"; // this is the "database"

        public static void saveApplicant(Applicant applicant)
        {
            List<Applicant> allApplicants = getApplicants();

            // ensure there is no duplicate studentid
            if (allApplicants.Any(a => a.StudentID == applicant.StudentID))
            {
                throw new Exception("An application with this Student ID already exists.");
            }

            allApplicants.Add(applicant);
            string updatedJson = JsonSerializer.Serialize(allApplicants, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Data.filePath, updatedJson);
        }

        public static List<Applicant> getApplicants()
        {
            if (File.Exists(Data.filePath))
            {
                string existingJson = File.ReadAllText(Data.filePath);
                return JsonSerializer.Deserialize<List<Applicant>>(existingJson) ?? new List<Applicant>();
            }
            else
            {
                return new List<Applicant>();
            }
        }

        public static List<Applicant> updateApplicant(Applicant applicant, bool isAccepted)
        {
            List<Applicant> allApplicants = getApplicants();
            Applicant existingApplicant = allApplicants.FirstOrDefault(a => a.ID == applicant.ID);
            if (existingApplicant != null)
            {
                existingApplicant.Status = isAccepted ? "Accepted" : "Rejected";
                //existingApplicant.FinalDecision = isAccepted ? "Accepted" : "Rejected";
                existingApplicant.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updatedJson = JsonSerializer.Serialize(allApplicants, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(Data.filePath, updatedJson);
            }

            return allApplicants;
        }
    }
}
