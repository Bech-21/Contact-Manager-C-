/* create by :Bachir Mahomad
 Version:2.0
 Date:09/06/2019
 Objective: Main form for the electric billing system
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
using UniversityPeopleClas;
using ClassContactDescription;
using AddStudentTestDialog;
using System.IO;

namespace ContactManager
{
    public partial class ContactManagerMainForm : Form
    {
        // list variable to keep a record of faculty and student  
        List<Person> PeopleInventory = new List<Person>();
        // global varaible to save the file path 
        private string myfilePath;
        // boolean variable for insure the file have been saved 
        private bool haveFileBeenSaved = false;
        // exitentiate a new add faculty dialog box to enter information
        AddStudentDialog afd = new AddStudentDialog();
        // exitentiate dialog box showing and configure the dialog box
        AddStudentDialog asd = new AddStudentDialog();
        // exitentiate creating a search 
        SearchFirstNameDialog snfd = new SearchFirstNameDialog();
        public ContactManagerMainForm()
        {
            InitializeComponent();
        }

      

        /**** File Menu Code **********/
        //method to navigate ,read  and load the content of a new file 
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open a dialog a new save dialog box
            OpenFileDialog ofd = new OpenFileDialog();
            // configure dialog and show 
            ofd.Title = "Save Contact List";
            ofd.DefaultExt = "txt";
            ofd.Filter = "Contact Inventory File|*.cil|Text Files|*.txt|All Files|*.*";
            ofd.FilterIndex = 2;
            DialogResult result = ofd.ShowDialog();
            //pass the file name from 
            if (result != DialogResult.OK)
            {
                return;
            }
            myfilePath = ofd.FileName;
            //Savefile(ofd.FileName);
            StreamReader input = new StreamReader(ofd.FileName);
            // All inside a try catch
            Person p=null;
            try
            {
                // open a stream reader on productList on the desktop 
                // foreach contact call the constractor that takes a single string
                //and get a contact information back . Add that object to my list and to the display close
                while (!input.EndOfStream)
                {
                    string contactType = input.ReadLine();
                    switch (contactType)
                    {
                        case "Student": p = new Student(input.ReadLine()); break;
                        case "Faculty": p = new Faculty(input.ReadLine()); break;

                        default:
                            MessageBox.Show("Unkown Contact Information");
                            p = null;
                            break;
                    }
                    if (p != null)
                    {
                        PeopleInventory.Add(p);
                        displayContactListbox.Items.Add(p.ToFormattedString());
                    }
                }
                input.Close();

            }
            catch (Exception excp)
            {
                MessageBox.Show($"Error:File did not Load.{excp.Message}");
                return;
            }
            haveFileBeenSaved = false;
        }
        //method to save a file a file when the save button is hit
        private void SaveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!File.Exists(myfilePath))
            {
                SaveDialog();
                if (myfilePath != null)
                {
                    Savefile(myfilePath);

                }
            }
            else
            {
                Savefile(myfilePath);
                
            }
           
        }
        

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog();
            if (myfilePath != null)
            {
                Savefile(myfilePath);
              
            }
           
        }
        public string SaveDialog()
        {
            //open a dialog a new save dialog box
            SaveFileDialog sfd = new SaveFileDialog();
            // configure dialog and show 
            sfd.Title = "Save Contact List";
            sfd.DefaultExt = "txt";
            sfd.Filter = "Contact Inventory File|*.cil|Text Files|*.txt|All Files|*.*";
            sfd.FilterIndex = 2;
            DialogResult result = sfd.ShowDialog();
            //pass the file name from 
            if (result != DialogResult.OK)
            {
                return null;
            }
           myfilePath = sfd.FileName;
            return myfilePath;
        }

        public void Savefile(string filePath)
        {
            //open a dialog a save dialog box
            // configure dialog and show 
            //pass the file name from 
            // all inside a try catch 
            try
            {
                //open a stream writer
                // foreach student in my inventory list used the tofile string to write the file and then close the file
                
                StreamWriter output = new StreamWriter(filePath);
                foreach (Person p in PeopleInventory)
                {

                    if (p is Student)
                    {
                        output.WriteLine(contactTypeString(p));
                        output.WriteLine(p.ToFileString());
                    }
                    else if (p is Faculty)
                    {
                        output.WriteLine(contactTypeString(p));
                        output.WriteLine(p.ToFileString());
                    }

                }
                output.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Error:File did not write.{excp.Message}");
                return;
            }
            haveFileBeenSaved = true;
            MessageBox.Show($"Contact list have been saved");

          
        }
        private string contactTypeString(Person p)
        {
            if (p is Student)
                return "Student";
            else if (p is Faculty)
                return "Faculty";
            else
                return "Unknown";
        }
        // Exist Method 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check to see if the file is alreadysaved or not
            if (!haveFileBeenSaved)
            {
             
                SaveDialog();
                if(myfilePath !=null)
                {
                    Savefile(myfilePath);
                }
                else
                {
                    return;
                }
            }

            Application.Exit();

        }

        /**** Help Menu Code **********/

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpMenuDialog hlp = new HelpMenuDialog();
            
            DialogResult result = hlp.ShowDialog();
            DialogResult = DialogResult.OK;
            
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        /**** Contact display and context Menu Code **********/

        // method to display a the contact information when a person is selected in the list
        private void ContactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            // make sure that someon is selected before displaying the information
            
            Person p;
            p=SelectContactFirst();
            if (p != null)
            {
                if (p is Faculty)
                {
                    // create a new dialog for displaying and configure it
                    afd.FacultyMode = true;
                    afd.ReadOnly = true;
                    addFacultyDialog();
                    displayContactListbox.ClearSelected();
                    

                }
                else if (p is Student)
                {
                    asd.ReadOnly = true;
                    asd.StudentMode = true;
                    addStudentDialog();
                    displayContactListbox.ClearSelected();
                }
            }
           
        }
        public Person SelectContactFirst()
        {
            int index = displayContactListbox.SelectedIndex;
            // make sure that someon is selected before displaying the information

            if (index == -1)
            {
                MessageBox.Show("Must select a contact first");
                return null;
            }
            Person p = PeopleInventory[index];
            return p;
        }
        private void addFacultyDialog()
        {
            int index = displayContactListbox.SelectedIndex;
            Faculty f = (Faculty)PeopleInventory[index];
            afd.FirstName = f.FirstName;
            afd.LastName = f.LastName;
            afd.AcademicDepartment = f.AcademicDepartment;
            afd.EmailAddress = f.ContactDetails.EmailAddress;
            afd.SnailMailAddress = f.ContactDetails.OfficeLocation;


            // show the dialog and and wait for the Ok
            DialogResult result = afd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
          
        }
        private void addStudentDialog()
        {
            int index = displayContactListbox.SelectedIndex;

            // dialog box showing and configure the dialog box             
            Student s = (Student)PeopleInventory[index];

            asd.FirstName = s.FirstName;
            asd.LastName = s.LastName;
            asd.AcademicDepartment = s.AcademicDepartment;
            asd.EmailAddress = s.ContactDetails.EmailAddress;
            asd.SnailMailAddress = s.ContactDetails.SnailMailAddress;
            asd.GraduationYear = s.GraduationYear;
            asd.CourseList = s.CourseList;
            DialogResult result = asd.ShowDialog();
            // issue a a confirmation dialog
            if (result != DialogResult.OK)
            {
                return;
            }
            
        }
        // method to create and display the contact information for a student 
        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayContactListbox.ClearSelected();
            Person p;
            try
            {
                p = createStudentContact();
            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Unable to add student contact information. {excp.Message}");
                return;
            }
            catch (FormatException excp)
            {
                MessageBox.Show($"Non numeric data in a numeric field. {excp.Message}");
                return;
            }
            if (p != null)
            {
                PeopleInventory.Add(p);
                displayContactListbox.Items.Add(p.ToFormattedString());
            }
            haveFileBeenSaved = false;
        }
        // method to create and display the contact information for a faculty 
        private void FacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayContactListbox.ClearSelected();
            Person p;
            try
            {
                p = createFacultyContact();
            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Unable to add student contact information. {excp.Message}");
                return;
            }
            catch (FormatException excp)
            {
                MessageBox.Show($"Non numeric data in a numeric field. {excp.Message}");
                return;
            }
            if (p != null)
            {
                PeopleInventory.Add(p);
                displayContactListbox.Items.Add(p.ToFormattedString());
            }
            haveFileBeenSaved = false;

        }
        // method to enter and adding a student contact information
        public Person createStudentContact()
        {
            asd = new AddStudentDialog();
     
            DialogResult result = asd.ShowDialog();
            // issue a a confirmation dialog
            if (result != DialogResult.OK)
            {
                return null;
            }
           
            //add the information enter into the dialog box into the display list   
            // and the backing store list also people inventory list
            ContactInformation c = new ContactInformation();
            c.SnailMailAddress = asd.SnailMailAddress; // Used code on the add student dialog box to change the snail mail to office building text box
            c.EmailAddress = asd.EmailAddress;      
           
            Person p = new Student(asd.FirstName, asd.LastName, asd.AcademicDepartment, c, asd.GraduationYear, asd.CourseList);
            return p;
        }
        public Person createFacultyContact()
        {
            afd = new AddStudentDialog();
            afd.FacultyMode = true;

            DialogResult result = afd.ShowDialog();
            // issue a a confirmation dialog
            if (result != DialogResult.OK)
            {
                return null;
            }
            //add the information enter into the dialog box into the display list   
            // and the backing store list also people inventory list
            ContactInformation c = new ContactInformation();
            c.OfficeLocation = afd.SnailMailAddress; //(the snail email will be change to add a location in the add student dialog box by using code to change snail label to office build
            c.EmailAddress = afd.EmailAddress;

            Person p = new Faculty(afd.FirstName, afd.LastName, afd.AcademicDepartment, c);
            return p;
        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make sure that someon is selected before displaying the information

            int index = displayContactListbox.SelectedIndex;
            Person p;
            p=SelectContactFirst();

            if (p != null)
            {
                DialogResult result1 = MessageBox.Show($"Do you wish to edit " +
                  $"{p.FirstName} {p.LastName} contact information?", "Confirmation Message", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    if (p is Faculty)
                    {
                        afd = new AddStudentDialog();
                        afd.FacultyMode = true;
                        afd.EditMode = true;
                        addFacultyDialog();

                        // if user confirm create a update the current contact information and student from the info from the dialog box
                        ContactInformation c = new ContactInformation();
                        c.EmailAddress = afd.EmailAddress;
                        c.OfficeLocation = afd.SnailMailAddress;
                        Person p1 = new Faculty(afd.FirstName, afd.LastName, afd.AcademicDepartment, c);
                        PeopleInventory[index] = p1;
                        displayContactListbox.Items[index] = p1.ToFormattedString();

                    }
                    else if (p is Student)
                    {
                        asd = new AddStudentDialog();
                        // ceate a new dialog for displaying and configure it
                        asd.EditMode = true;
                        asd.StudentMode = true;
                        addStudentDialog();
                        // show the dialog and and wait for the Ok

                        // if user confirm create a update the current contact information and student from the info from the dialog box
                        ContactInformation c = new ContactInformation();
                        c.EmailAddress = asd.EmailAddress;
                        c.SnailMailAddress = asd.SnailMailAddress;
                        Person p1 = new Student(asd.FirstName, asd.LastName, asd.AcademicDepartment, c, asd.GraduationYear, asd.CourseList);
                        PeopleInventory[index] = p1;
                        displayContactListbox.Items[index] = p1.ToFormattedString();

                    }
                 
                    haveFileBeenSaved = false;
                }
              
            }
                     
        }
        
        // method to delete a contact information from the display list and storage list
        private void DeleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make sure that someon is selected before displaying the information
            int index = displayContactListbox.SelectedIndex;
            Person p;
            p=SelectContactFirst();

            if (p != null)
            {
                // issue a a confirmation dialog
                DialogResult result1 = MessageBox.Show($"Do you wish to delete " +
                   $"{p.FirstName} {p.LastName} contact information?", "Confirmation Message", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    if (p is Faculty)
                    {
                        Faculty f = (Faculty)PeopleInventory[index];

                        {
                            //remove selected item from both the display the display list box
                            // and the backiging store list also
                            PeopleInventory.RemoveAt(displayContactListbox.SelectedIndex);
                            displayContactListbox.Items.RemoveAt(displayContactListbox.SelectedIndex);
                        }
                    }
                    else if (p is Student)
                    {
                        Student s = (Student)PeopleInventory[index];

                        {
                            //remove selected item from both the display the display list box
                            // and the backiging store list also
                            PeopleInventory.RemoveAt(displayContactListbox.SelectedIndex);
                            displayContactListbox.Items.RemoveAt(displayContactListbox.SelectedIndex);
                        }
                    }
                    MessageBox.Show("Contact have been removed ");
                    haveFileBeenSaved = false;
                }
               
            }  
        }
     
        //////////////////////////////////////////////////////////////////////////////////////////////////
        /**** search under context Menu Code **********/
        // Method to seach by first Name 
        private void FirstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new dialog for displaying and configure it
            SearchFirstNameDialog snfd = new SearchFirstNameDialog();
            snfd.SearchbyFName = true;

            // show the dialog and and wait for the Ok
            DialogResult result = snfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            // clear the selected item
            // loop through the ite contain in the inventory and only display the item that match with search paramer
            displayContactListbox.ClearSelected();
            for (int i =0; i < PeopleInventory.Count; i++)
            {
                if (PeopleInventory[i].FirstName.ToLower().Contains(snfd.searchParameter.ToLower()))
                {
                    displayContactListbox.SetSelected(i,true);
                }

            }
            MessageBox.Show($"{displayContactListbox.SelectedItems.Count.ToString()} items found");
        }
        // Method to seach by Last Name 

        private void LastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          
            // ceate a new dialog for displaying and configure it
            SearchFirstNameDialog snfd = new SearchFirstNameDialog();

            snfd.SearchbyLName = true;

            // show the dialog and and wait for the Ok
            DialogResult result = snfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            // loop through the ite contain in the inventory and only display the item that match with search paramer
            displayContactListbox.ClearSelected();
            for (int i = 0; i < PeopleInventory.Count; i++)
            {
                if (PeopleInventory[i].LastName.ToLower().Contains(snfd.searchParameter.ToLower()))
                {
                    displayContactListbox.SetSelected(i, true);
                }

            }
            MessageBox.Show($"{displayContactListbox.SelectedItems.Count.ToString()} items found");
        }
        // Method to seach by first and lastname 
        private void FirstAndLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string  fname;
            string lname;
         
            // ceate a new dialog for displaying and configure it
            SearchFirstNameDialog snfd = new SearchFirstNameDialog();

            snfd.SearchbyFLName = true;

            // show the dialog and and wait for the Ok
            DialogResult result = snfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

          


            try
            {
                //SplitString(snfd.searchParameter);
                char[] delimeters = { ' ', ',' };
                string[] tokens = snfd.searchParameter.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                fname = tokens[0];
                lname = tokens[1];
                // loop through the ite contain in the inventory and only display the item that match with search paramer
                displayContactListbox.ClearSelected();
                for (int i = 0; i < PeopleInventory.Count; i++)
                {
                    if (PeopleInventory[i].FirstName.ToLower().Contains(fname.ToLower()) &&
                        PeopleInventory[i].LastName.ToLower().Contains(lname.ToLower()))
                    {
                        displayContactListbox.SetSelected(i, true);
                    }

                }
                MessageBox.Show($"{displayContactListbox.SelectedItems.Count.ToString()} items found");

            }
            catch (Exception excp)
            {
                MessageBox.Show($"Leave space between first and last name", "Format Error");
                return;
            }

        }

      
        private void RefreshPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            displayContactListbox.ClearSelected();
        }

        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
