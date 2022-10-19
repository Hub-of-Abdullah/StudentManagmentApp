using StudentManagmentApp.Manager;
using StudentManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagmentApp.UI
{
    public partial class StudentEntryPage : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            StudentInfoDisplayGrid.DataSource = null;
            StudentInfoDisplayGrid.DataSource = aStudentManager.GetAllStudent();
            StudentInfoDisplayGrid.DataBind();
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.firstName = firstNameTxtBx.Text;
            aStudent.lastName = lastNameTxtBx.Text;
            aStudent.className = classDropDownList.Text;
            aStudent.rollNo = Convert.ToInt32(rollNoTxtBx.Text);
            aStudent.Result = (float)Convert.ToDouble(resultTxtBx.Text);
            aStudent.Email = emailTxtBx.Text;

            string massage = aStudentManager.SaveStudent(aStudent);

            SuccessedFailedLabel.Text = massage;

            firstNameTxtBx.Text = "";
            lastNameTxtBx.Text = "";
            classDropDownList.Text = "";
            rollNoTxtBx.Text = "";
            resultTxtBx.Text = "";
            emailTxtBx.Text = "";
        }
       

        public void DataBindInGrid()
        {
            /// StudentInfoDisplayGrid.DataSource = null;
            ///StudentInfoDisplayGrid.DataSource = aStudentManager.GetAllStudent();
            ///StudentInfoDisplayGrid.DataBind();

        }

        protected void EachclassInfoShowBtn_Click(object sender, EventArgs e)
        {
            
                Student aStudent = new Student();

                aStudent.className = EachClassName.Text;
                StudentInfoDisplayGrid.DataSource = null;
                StudentInfoDisplayGrid.DataSource = aStudentManager.GetEachClassStudents(aStudent);
                StudentInfoDisplayGrid.DataBind();
            
        }
    }
}