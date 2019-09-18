/* create by :Bachir Mahomad
 Version:1
 Date:08/30/2019
 Objective: Create a contact information class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassContactDescription
{
    public class ContactInformation
    {
        // public variable 
        public string EmailAddress
        {              
            get { return emailAddress; }
            set
            {
                if (!((value != null) && (value.Length > 0)))
                {
                    throw new ArgumentException(" Enter valid  email address");
                }
                emailAddress = value;
            }
        }
        public string SnailMailAddress
        {              
            get { return snailMailAddress; }
            set
            {
                if (!(value != null))
                {
                    throw new ArgumentException(" Enter valid snail mail address");
                }
                snailMailAddress = value;
            }
        }
        public string OfficeLocation
        {
            get { return officeLocation; }
            set
            {
                if (!(value != null))
                {
                    throw new ArgumentException(" Enter valid snail mail address");
                }
                officeLocation = value;
            }

        }

        // private variable
        private string emailAddress;
         private string snailMailAddress;
        private string officeLocation;

        // Constructor
        public ContactInformation()
        {      
                      
        }
   
        // To string override method to display 
        public override string ToString()
        {
            return $"Email: {emailAddress}";
        }
        // method using boolean to validate string is not null or empty
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
