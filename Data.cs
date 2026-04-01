using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CSA406
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string LinkedStudentID { get; set; }
        public string Name { get; set; }
    }

    public class Applicant
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string StudentID { get; set; }
        public string Email { get; set; }
        public string Status { get; set; } = "Pending";
        public string FinalDecision { get; set; } = "Pending";
        public string ReportFilePath { get; set; }
        public string SubmissionDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public string LastModified { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public class Evaluation
    {
        public string ID { get; set; }
        public string StudentID { get; set; }
        public string EmployerName { get; set; }
        public int TechnicalSkills { get; set; }
        public int Professionalism { get; set; }
        public string Comments { get; set; }
        public string SubmissionDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public static class Data
    {
        public static string filePath = "applicants.json";
        public static string usersFilePath = "users.json";
        public static string evaluationsFilePath = "evaluations.json";

        public static void seedDefaultUsers()
        {
            if (!File.Exists(usersFilePath))
            {
                var defaultUsers = new List<User>
                {
                    new User { Username = "coordinator", Password = "admin123", Role = "Coordinator", Name = "Co-op Coordinator", LinkedStudentID = "" },
                    //new User { Username = "123123123", Password = "pass123", Role = "Student", Name = "Student", LinkedStudentID = "123123123" },
                    new User { Username = "employer1", Password = "pass123", Role = "Employer", Name = "John Smith", LinkedStudentID = "" }
                };
                string json = JsonSerializer.Serialize(defaultUsers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(usersFilePath, json);
            }
        }

        public static User authenticateUser(string username, string password)
        {
            seedDefaultUsers();
            List<User> users = getUsers();
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public static List<User> getUsers()
        {
            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            return new List<User>();
        }

        public static void saveApplicant(Applicant applicant)
        {
            List<Applicant> allApplicants = getApplicants();

            if (allApplicants.Any(a => a.StudentID == applicant.StudentID))
            {
                throw new Exception("An application with this Student ID already exists.");
            }

            allApplicants.Add(applicant);
            string updatedJson = JsonSerializer.Serialize(allApplicants, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);
        }

        public static List<Applicant> getApplicants()
        {
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Applicant>>(existingJson) ?? new List<Applicant>();
            }
            return new List<Applicant>();
        }

        public static List<Applicant> updateApplicant(Applicant applicant, bool isAccepted)
        {
            List<Applicant> allApplicants = getApplicants();
            Applicant existingApplicant = allApplicants.FirstOrDefault(a => a.ID == applicant.ID);
            if (existingApplicant != null)
            {
                existingApplicant.Status = isAccepted ? "Provisionally Accepted" : "Rejected";
                existingApplicant.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updatedJson = JsonSerializer.Serialize(allApplicants, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updatedJson);
            }
            return allApplicants;
        }

        public static Applicant getApplicantByStudentID(string studentID)
        {
            return getApplicants().FirstOrDefault(a => a.StudentID == studentID);
        }

        public static void updateApplicantReport(string studentID, string reportPath)
        {
            List<Applicant> allApplicants = getApplicants();
            Applicant applicant = allApplicants.FirstOrDefault(a => a.StudentID == studentID);
            if (applicant != null)
            {
                applicant.ReportFilePath = reportPath;
                applicant.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updatedJson = JsonSerializer.Serialize(allApplicants, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updatedJson);
            }
        }

        public static void finalAcceptApplicant(string applicantId)
        {
            List<Applicant> allApplicants = getApplicants();
            Applicant applicant = allApplicants.FirstOrDefault(a => a.ID == applicantId);
            if (applicant != null)
            {
                applicant.Status = "Finally Accepted";
                applicant.FinalDecision = "Finally Accepted";
                applicant.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updatedJson = JsonSerializer.Serialize(allApplicants, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updatedJson);
            }
        }

        public static List<Evaluation> getEvaluations()
        {
            if (File.Exists(evaluationsFilePath))
            {
                string json = File.ReadAllText(evaluationsFilePath);
                return JsonSerializer.Deserialize<List<Evaluation>>(json) ?? new List<Evaluation>();
            }
            return new List<Evaluation>();
        }

        public static void saveEvaluation(Evaluation evaluation)
        {
            List<Evaluation> all = getEvaluations();
            all.Add(evaluation);
            string json = JsonSerializer.Serialize(all, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(evaluationsFilePath, json);
        }

        public static bool hasEvaluation(string studentID)
        {
            return getEvaluations().Any(e => e.StudentID == studentID);
        }

        public static List<Applicant> getAcceptedApplicants()
        {
            return getApplicants().Where(a => a.Status == "Provisionally Accepted").ToList();
        }

        public static void registerUser(User user)
        {
            seedDefaultUsers();
            List<User> users = getUsers();
            if (users.Any(u => u.Username == user.Username))
            {
                throw new Exception("An account with this Student ID already exists.");
            }
            users.Add(user);
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(usersFilePath, json);
        }
    }
}
