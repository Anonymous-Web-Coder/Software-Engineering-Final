using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student_Management_System.Business_Logic_Layer
{
    internal class Validation
    {
        public static bool ValidateLogin(string studentNumber, string password)
        {
            // Validate student number format
            if (!Regex.IsMatch(studentNumber, @"^BC\d{5}(DIP|BCOM)$"))
            {
                return false;
            }
     
            return true;
        }
    }
}
