/* create by :Bachir Mahomad
 Version:2.0
 Date:09/06/2019
 Objective: Create a dialog box which add acourse to the list displaying the student chosen course the main form
 */






using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddStudentTestDialog
{
    
    public partial class AddCourseDialog : Form
    {
        // public variable
        public string CourseName;
        private bool haveValidCourse = false;
        public AddCourseDialog()
        {
            InitializeComponent();
        }

        private void CancelCourseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        // to validate  that the course is not empty
        private void AddCourseTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidCourse = false;
            validateCourse();

        }
 

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (!haveValidCourse)
            {
                MessageBox.Show("Enter a valid course name", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;

        }
        private void validateCourse()
        {
            if (addCourseTextbox.Text.Trim().Length == 0)
            {
                haveValidCourse = false;
            }
            else
            {
                haveValidCourse = true;
                CourseName = addCourseTextbox.Text.Trim();
            }
        }

        private void AddCourseDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
