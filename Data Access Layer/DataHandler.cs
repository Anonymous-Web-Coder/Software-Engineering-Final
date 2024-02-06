using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;


using Student_Management_System.Business_Logic_Layer;

namespace Student_Management_System.Data_Access_Layer
{
    internal class DataHandler
    {
        public static void SaveLoginData(string studentNumber, string password) { }
        public static SqlConnection GetDatabaseConnection()
        {
            return new SqlConnection("Data Source=webCoder\\SQLEXPRESS;Initial Catalog=StudentRegistrationSystemforBelgiumCampus;Integrated Security=True");
        }
        public static void RegisterStudent(Student student) { }
        public static void EditStudent(Student student) { }
        public static void DeleteStudent(string studentNumber) { }
        public static void AddCourse(Course course) { }
        public static void EditCourse(Course course) { }
        public static void DeleteCourse(int courseId)   {  }
        public DataTable displayStudent()
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("spStudents", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand.CommandText = "SELECT * FROM Students";
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchStudent(string department)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("spSearchStudent", sqlConnection);
            cmd.Parameters.AddWithValue("@firstName", department);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        string conn = "Data Source=webCoder\\SQLEXPRESS;Initial Catalog=StudentRegistrationSystemforBelgiumCampus;Integrated Security=True";
     
 
    }
}
