using StudentManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace StudentManagmentApp.GateWay
{
    public class StudentGateWay
    {
        public int SqlDataReader { get; private set; }
        public int SaveStudent(Student aStudent)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ABDULLAH\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");

            string query = "INSERT INTO StudentTable (firstName, lastName, Class, RollNo, Result, Email) VALUES('" + aStudent.firstName + "','" + aStudent.lastName + "','" + aStudent.className + "','" + aStudent.rollNo + "','" + aStudent.Result + "','" + aStudent.Email + "')";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int rowAfefected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAfefected;
        }
        public bool IsExistClassAndRoll(string Class, int rollNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ABDULLAH\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");

            string query = "SELECT * FROM StudentTable WHERE Class = '" + Class + "' AND RollNo ='" + rollNo + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                return true;
            }
            return false;

        }
        public List<Student> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ABDULLAH\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");

            string query = "SELECT firstName AS FirstName, lastName As LastName, class AS Class, RollNo AS RollNo, Result AS Result, Email AS Email FROM StudentTable ";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Student> AllStudents = new List<Student>();

            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.firstName = reader["firstName"].ToString();
                aStudent.lastName = reader["lastName"].ToString();
                aStudent.className = reader["Class"].ToString();
                aStudent.rollNo = Convert.ToInt32(reader["RollNo"].ToString());
                aStudent.Result = (float)Convert.ToDouble(reader["Result"].ToString());
                aStudent.Email = reader["Email"].ToString();
                AllStudents.Add(aStudent);

            }
            connection.Close();
            return AllStudents;
        }

        public List<Student> GetEachClassStudents(string Class)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ABDULLAH\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");

            string query = "SELECT firstName AS FirstName, lastName As LastName, class AS Class, RollNo AS RollNo, Result AS Result, Email AS Email FROM StudentTable  WHERE Class = '"+ Class +"'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Student> EachClassStudents = new List<Student>();

            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.firstName = reader["firstName"].ToString();
                aStudent.lastName = reader["lastName"].ToString();
                aStudent.className = reader["Class"].ToString();
                aStudent.rollNo = Convert.ToInt32(reader["RollNo"].ToString());
                aStudent.Result = (float)Convert.ToDouble(reader["Result"].ToString());
                aStudent.Email = reader["Email"].ToString();
                EachClassStudents.Add(aStudent);

            }
            connection.Close();
            return EachClassStudents;
        }


    }
}