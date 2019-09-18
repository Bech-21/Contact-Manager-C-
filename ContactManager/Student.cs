/* create by :Bachir Mahomad
 Version:1
 Date:08/30/2019
 Objective: Create a student class which will inherit from the person class
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassContactDescription;

namespace UniversityPeopleClas
{
   
   public class Student:Person
    {
        //public variable

        public int GraduationYear                //  variable that refer to graduation year of the student 
        {
            get { return graduationYear; }
        }
        public List<string> CourseList                     //  classes in which  the student is enroll in  
        {
            get { return courseList; }
        }

        // private variable 
        private int graduationYear;
        private List<string> courseList;

        

        //constructor

        public Student (string fname, string lname, string academicdepartment, ContactInformation contactdetails, int graduationyear, List<string> courselist)
            :base( fname,  lname,  academicdepartment, contactdetails)
        {
            if (!validateDate(graduationyear))
            {
                throw new ArgumentException(" Enter valid course");
            }

            graduationYear = graduationyear;
            courseList = courselist;

        }
        // constractor to construct object after opening and reading a new file 
        public Student (string fromFile):base(fromFile)
        {
            char[] delimeters = { '|', ',' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            contactDetails = new ContactInformation();
            contactDetails.EmailAddress = tokens[4];
            contactDetails.SnailMailAddress = tokens[5];
            graduationYear =int.Parse(tokens[6]);
            courseList = new List<string>();
            for (int i = 7; i < tokens.Length; i++)
            {
                courseList.Add(tokens[i]);
            }

        }

        // the formated string is a method used to display on the display properly

        public override string ToFileString()
        {
            string s = "";
            AccountType = "Student";
            s = base.ToFileString() +
                $"|{contactDetails.EmailAddress}" + $"|{contactDetails.SnailMailAddress}" +
                $"|{graduationYear}";
            foreach (string course in courseList)
            {
                s = s + "|" +course;

            }

            return s;
        }
        // the formated string is a method used to display on the display properly

        public override string ToFormattedString()
        {

             AccountType = "Student";
            return base.ToFormattedString();
        }
        public override string ToString()
        {
            string s = "";
            s = base.ToString() + $"Email: {contactDetails.EmailAddress}, Snail Mail: {contactDetails.SnailMailAddress},{Environment.NewLine} " +
                $"Gradution Year:{graduationYear}, Courses: ";
            foreach (string course in courseList)
            {
                s = s + course + " ";

            }
            return s;
      
        }

        private bool validateDate(int date)
        {
            if (!((date > 1500) && (date < 3000)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }



   }
}
