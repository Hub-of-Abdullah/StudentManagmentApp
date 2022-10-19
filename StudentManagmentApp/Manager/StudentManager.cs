using StudentManagmentApp.GateWay;
using StudentManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentApp.Manager
{

    public class StudentManager
    {
        StudentGateWay studentGetWay = new StudentGateWay();
        public string SaveStudent( Student aStudent)
        {
            if(aStudent.firstName == "")
            {
                return "Please type your first name.";
            }
            if (aStudent.lastName == "")
            {
                return "Please type your last name.";
            }
            if (aStudent.className == "")
            {
                return "Please type your class.";
            }
            if (aStudent.rollNo == null)
            {
                return "Please type your Roll.";
             
            }
            if (aStudent.Result == null)
            {
                return "Please type your Result.";
            }
            if (aStudent.Email == "")
            {
                return "Please type your Email.";
            }


            if (studentGetWay.IsExistClassAndRoll( aStudent.className, aStudent.rollNo))
            {
                return "This student Information already Exit";
            }

            int rowAffected = studentGetWay.SaveStudent(aStudent);
            if (rowAffected > 0)
            {
                return "Student Data Save Successfully....!";
            }
            return "Student data fail to save....! "; ;
        }

        public List<Student> GetAllStudent()
        {
            return studentGetWay.GetAllStudents();
        }
        public List<Student> GetEachClassStudents(Student aStudent)
        {
            return studentGetWay.GetEachClassStudents(aStudent.className);
        }
    }
}