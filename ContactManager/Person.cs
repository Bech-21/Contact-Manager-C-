/* create by :Bachir Mahomad
 Version:1
 Date:08/30/2019
 Objective: Creat a Child class University  person based class 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassContactDescription;

namespace UniversityPeopleClas

{
    public class Person
    {
        //public variable  
        public string FirstName                                         // a person first name
        {
            get { return firstName; }
        }
           
        public string LastName                                           // a person last name
        {
            get { return lastName; }
        }
        public string AcademicDepartment                                  // the department in which a person is assigned to 
        {
            get { return academicDepartment; }
        }
        public ContactInformation ContactDetails                                  // the department in which a person is assigned to 
        {
            get { return contactDetails; }
            set { }
        }



        public string AccountType="";

        // Private Shadow properties
        private string firstName;
        private string lastName;
        private string academicDepartment;
       
        protected ContactInformation contactDetails;
  
        
        // constractor for the base class
        public Person(String fname, string lname, string academicdepartment, ContactInformation contactdetails)
        {
            if (!validateString(fname))
            {
                throw new ArgumentException("Enter valid first name");
            }
            if (!validateString(lname))
            {
                 throw new ArgumentException("Enter valid Last name");
            }
            if (!validateString(academicdepartment))
            {
                 throw new ArgumentException("Enter academic department");
            }
           
             firstName=fname;
             lastName = lname;
             academicDepartment = academicdepartment;
             contactDetails = contactdetails;
        }
        // constractor to construct object after opening and reading a new file 
        public Person(string fromFile)
        {
            char[] delimeters = { '|', ',' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            firstName = tokens[0];
            lastName = tokens[1];
            AccountType = tokens[2];
            academicDepartment = tokens[3];

        }

        // the formated string is a method used to display on the display properly

        public virtual string ToFileString()
        {

            string theString = "";
            theString += $"{firstName}|";
            theString += $"{lastName}|";
            theString += $"{AccountType}|";
            theString += $"{academicDepartment}";
            return theString;
        }
        // the formated string is a method used to display on the display properly

        public virtual string ToFormattedString()
        {

            string theString = "";
            theString += $"{firstName,-25}";
            theString += $"{lastName,-25}";
            theString += $"{AccountType,-25}";
            theString += $"{academicDepartment,-25}";
            return theString;
        }
        // string extension method to display the person information

        public override string ToString()
        {
            return $"FirstName: {firstName}, Last Name: {lastName}, Academic Department: {academicDepartment}, ";
        }

        // boolean to validate the data is enter and is not empty

        protected bool validateString(string TheString)
        {
            if (!((TheString != null) && (TheString.Length > 0)))
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

