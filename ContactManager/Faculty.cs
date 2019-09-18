/* create by :Bachir Mahomad
 Version:1
 Date:08/30/2019
 Objective: Create a faculty class which will inherit from the person class
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassContactDescription;

namespace UniversityPeopleClas
{
    public class Faculty:Person
    {
        // base constructor for faculty object
        public Faculty(string fname, string lname, string academicdepartment, ContactInformation contactdetails)
            :base( fname,  lname,  academicdepartment, contactdetails)
        {

        }
        public Faculty(string fromFile) : base(fromFile)
        {
            char[] delimeters = { '|', ',' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            contactDetails = new ContactInformation();
            contactDetails.EmailAddress = tokens[4];
            contactDetails.OfficeLocation= tokens[5];          
        }

        // the formated string is a method used to display on the display properly

        public override string ToFileString()
        {
            string s = "";
            AccountType = "faculty";
            s = base.ToFileString() + $"|{contactDetails.EmailAddress}" + $"|{contactDetails.OfficeLocation}";
             
         
            return s;
        }
        // the formated string is a method used to display on the display properly

        public override string ToFormattedString()
        {

            AccountType = "Faculty";
            return base.ToFormattedString();
        }

        // override of the to string method to display factulty informmation
        public override string ToString()
        {
            return base.ToString() + $"Email: {contactDetails.EmailAddress}, Office Mail: {contactDetails.OfficeLocation}";
        }















    }
    



}
