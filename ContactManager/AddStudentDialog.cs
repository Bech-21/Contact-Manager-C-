/* create by :Bachir Mahomad
 Version:2.0
 Date:09/06/2019
 Objective: Create a dialog box which add a student contact information to the main form
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
using ClassContactDescription;

namespace AddStudentTestDialog
{
    public partial class AddStudentDialog : Form
    {
        // public variable 
        public string FirstName;                            // public variable to store first name information from first name in dialog box
        public string LastName;                             // public variable to store last name information from last name in dialog box
        public string AcademicDepartment;                   // public variable to store academic department from academic departmentin dialog box
     
        public string EmailAddress;                         // public variable to store Email Address from EmailAddress in dialog box
        public string SnailMailAddress;
        public int GraduationYear;                           // public variable to store Graduation Year from Graduation Year in dialog box
        public List<string> CourseList=new List<string>();  // public variable to store Course List from Course List in dialog box

        public bool StudentMode = false;
        public bool FacultyMode = false;
        public bool ReadOnly = false;
        public bool EditMode = false;                          // public varible to activate the edit mode
                               
        // private variable to check the validity of the data
        private bool haveValidFirstName = false;
        private bool haveValidLastName = false;
        private bool haveValidAcademicDepartment = false;
     
        private bool haveValidEmailAddress = false;
        private bool haveValidSnailMailAddress = false;
        private bool haveValidGraduationYear = false;



        public AddStudentDialog()
        {
            InitializeComponent();
           
        }
        // method cancel the dialogu after cancel button and return
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        // method that display the error before addding a student and ensure that all field have been properly populate
        private void AddButton_Click(object sender, EventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;
            if (!haveValidFirstName)
            {
                badFieldName = "First Name";
                adviceString = "Must enter first name";
            }
            else if (!haveValidLastName)
            {
                badFieldName = "Last Name";
                adviceString = "Must enter last name";
            }
            else if (!haveValidAcademicDepartment)
            {
                badFieldName = "Academic Department";
                adviceString = "Must valid academic department";
            }
            else if (!haveValidEmailAddress)
            {
                badFieldName = "Email Address";
                adviceString = "Must valid email address";
            }
            else if (!haveValidSnailMailAddress)
            {
                badFieldName = "Snail Mail Address";
                adviceString = "Must enter valid snail mail address";
            }
            else if (!haveValidGraduationYear && StudentMode)
            {
                badFieldName = "Graduation Year";
                adviceString = "Graduation year should be between 1500 and 3000";
            }
           
            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}.\n{adviceString}.", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        // method to valid that the information enter in the first name text box.
        private void FirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidFirstName = false;
            validateFName();
        }
        // method to valid that the information enter in the last name text box.
        private void LastNameTexbox_TextChanged(object sender, EventArgs e)
        {
            haveValidLastName = false;
            validateLName();
        }
        // method to valid that the information enter in the academic department text box.
        private void AcademicDepartmentTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidAcademicDepartment = false;
            validateAcademicDepartment();

        }
        // method to valid that the information enter in the email address text box.
        private void EmailAddressTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidEmailAddress = false;
            validateEmailAddress();
        }
        // method to valid that the information enter in the snail mail address text box.
        private void SnailMailAddressTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidSnailMailAddress = false;
            validateSnailAddress();
        }
        // method to valid that the information enter in the graduation year text box.
        private void GraduationYearTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidGraduationYear = false;
            validateGraduationYear();
        }
       
       

        /*********Add course and delete course context menu on the add student dialog box***********/
        // method to add course and display the dialog box
        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseDialog adc = new AddCourseDialog();
            DialogResult result = adc.ShowDialog();
            if (result == DialogResult.OK)
            {

                courseListListbox.Items.Add(adc.CourseName.ToString());
                CourseList.Add(adc.CourseName);

            }
        }

        private void CourseListListbox_MouseHover(object sender, EventArgs e)
        {
            courseAddToolTipLabel.Visible = true;

        }

        private void CourseListListbox_MouseLeave(object sender, EventArgs e)
        {
            courseAddToolTipLabel.Visible = false;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make sure that someon is selected before displaying the information
            int index = courseListListbox.SelectedIndex;
            // make sure that a course is selected

            if (index == -1)
            {
                MessageBox.Show("Must select a course first");
                return;
            }


            // issue a a confirmation dialog
            DialogResult result1 = MessageBox.Show($"Do you wish to delete " +
               $"{CourseList[index]} course?", "Confirmation Message", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                //remove selected item from both the display the display list box
                // and the backiging store list also
                CourseList.RemoveAt(courseListListbox.SelectedIndex);
                courseListListbox.Items.RemoveAt(courseListListbox.SelectedIndex);
            }

        }
        /*********Edit Contact information context menu***********/
        //method display the contact information during the form load when the edit context is activate is active
        private void AddStudentDialog_Load(object sender, EventArgs e)
        {
            if (ReadOnly && StudentMode)            // Code use to change the student dialog box to read ony mode
            {
                courseListListbox.Items.Clear();
                assignVariableToTextBox();


                graduationYearTextbox.Text = GraduationYear.ToString();

                foreach (string course in CourseList)
                {
                    courseListListbox.Items.Add(course);

                }
                // put the the text on read only mode
                ReadMode();


                graduationYearTextbox.ReadOnly = true;

                courseListListbox.Enabled = false;
                courseListListbox.SelectionMode=SelectionMode.None;
                courseAddToolTipLabel.Visible = false;

            }
            else if (EditMode && StudentMode) // Code use to change the student dialog box to edit mode 
            {
                assignVariableToTextBox();

                graduationYearTextbox.Text = GraduationYear.ToString();

                foreach (string course in CourseList)
                {
                    courseListListbox.Items.Add(course);

                }
                Edit_Mode();

            }
            else if (FacultyMode && !ReadOnly && !EditMode) // Code use to change the student dialog box to add a faculty dialog box
            {
                FirstName=firstNameTextbox.Text;
                LastName = lastNameTexbox.Text;
                AcademicDepartment=academicDepartmentTextbox.Text;
                EmailAddress=emailAddressTextbox.Text;
                SnailMailAddress = snailMailAddressTextbox.Text;          
                // code used to transform the student dialog box to a add a faculty dialog box
                this.Text = $"Add Faculty Contact Information"; // change the title of the box
                AddFacultyDialog();

            }
            else if (ReadOnly && FacultyMode) // Code use to change the student dialog box to add a faculty dialog box and read only text box
            {
                assignVariableToTextBox();
                AddFacultyDialog();


                // put the the text on read only mode
                ReadMode();

            }
            else if (FacultyMode && EditMode) // Code use to change the student dialog box to add a faculty dialog box
            {
                assignVariableToTextBox();

                AddFacultyDialog();

                Edit_Mode();

            }

        }
        private void assignVariableToTextBox()
        {
            firstNameTextbox.Text = FirstName;
            lastNameTexbox.Text = LastName;
            academicDepartmentTextbox.Text = AcademicDepartment;
            emailAddressTextbox.Text = EmailAddress;
            snailMailAddressTextbox.Text = SnailMailAddress;
        }
        //method to change text box to read mode only
        private void ReadMode()
        {
            this.Text = $"{FirstName} {LastName} Contact Information";
            // put the the text on read only mode
            firstNameTextbox.ReadOnly = true;
            lastNameTexbox.ReadOnly = true;
            academicDepartmentTextbox.ReadOnly = true;
            emailAddressTextbox.ReadOnly = true;
            snailMailAddressTextbox.ReadOnly = true;
            cancelButton.Text = "Ok";
            addButton.Visible = false;

        }
        //method to change text box to edit mode only
        private void Edit_Mode()
        {
            // code used to transform the student dialog box to a add a faculty dialog box
            addButton.Text = "Update";
            this.Text = $"Edit {FirstName} {LastName} Contact Information";
        }
        //method used to transform the student dialog box into a faculty dialog box
        private void AddFacultyDialog()
        {
            // code used to transform the student dialog box to a add a faculty dialog box

            this.Size = new System.Drawing.Size(470, 280);// code to resize the size of dialog box
                                                          // code use to hide the text box that are not need 
            courseListListbox.Visible = false;
            courseListLabel.Visible = false;
            graduationYearLabel.Visible = false;
            graduationYearTextbox.Visible = false;
            // code use to change the snail label to add a location text box
            snailMailAddressLabel.Text = "Office Location Building";
        }

        private void validateFName()
        {
            if (firstNameTextbox.Text.Trim().Length == 0)
            {
                haveValidFirstName = false;
            }
            else
            {
                haveValidFirstName = true;
                FirstName = firstNameTextbox.Text.Trim();
            }
        }

        private void validateLName()
        {
            if (lastNameTexbox.Text.Trim().Length == 0)
            {
                haveValidLastName = false;
            }
            else
            {
                haveValidLastName = true;
                LastName = lastNameTexbox.Text.Trim();
            }
        }
        private void validateAcademicDepartment()
        {
            if (academicDepartmentTextbox.Text.Trim().Length == 0)
            {
                haveValidAcademicDepartment = false;
            }
            else
            {
                haveValidAcademicDepartment = true;
                AcademicDepartment = academicDepartmentTextbox.Text.Trim();
            }
        }
        private void validateEmailAddress()
        {
            if (emailAddressTextbox.Text.Trim().Length == 0)
            {
                haveValidEmailAddress = false;
            }
            else
            {
                haveValidEmailAddress = true;
                EmailAddress = emailAddressTextbox.Text.Trim();
            }
        }
        private void validateSnailAddress()
        {
            if (snailMailAddressTextbox.Text.Trim().Length == 0)
            {
                haveValidSnailMailAddress = false;
            }
            else
            {
                haveValidSnailMailAddress = true;
                SnailMailAddress = snailMailAddressTextbox.Text.Trim();
            }
        }
        private void validateGraduationYear()
        {
            if (int.TryParse(graduationYearTextbox.Text.Trim(),out GraduationYear))
            {
                if (GraduationYear>1500 && GraduationYear < 3000)
                {
                    haveValidGraduationYear = true;
                }
               
            }
          
        }

      
    }
}
