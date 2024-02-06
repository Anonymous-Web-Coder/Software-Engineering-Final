using Student_Management_System.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student_Management_System.Data_Access_Layer
{
    internal class FileHandler
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public static bool PerformLogin(string studentNumber, string password)
        {
              
          
            if (Validation.ValidateLogin(studentNumber, password))
            {
                // Save student number and password to a text file (you can use StreamWriter)
                // Perform other login-related logic if needed

                return true;
            }

            return false;
        }
        public string PerformLogin()
        {
            string feedback = string.Empty;
            string filePath = @""+Name+".txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArray = new string[2];
                        lineArray = line.Split(':');
                        if (lineArray[1] == Password)
                        {
                            feedback = "Access granted";
                            return feedback;
                        }
                        else
                        {
                            feedback = "Incorrect password";
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
                feedback = "Incorrect username ";

            }
            return feedback;
        }
        public string WriteFiles()
        {
            string feedback;
            string filePath = @""+Name+".txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name     :{Name}");
                    writer.WriteLine($"Surname  :{Surname}");
                    writer.WriteLine($"Email    :{Email}");
                    writer.WriteLine($"Password :{Password}");
                    feedback = "registered successfully!";
                }
                return feedback;
            }
            catch (Exception)
            {
                return "Invalid directory";
            }
        }


    }
}
