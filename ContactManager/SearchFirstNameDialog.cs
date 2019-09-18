/* create by :Bachir Mahomad
 Version:2.0
 Date:09/06/2019
 Objective: Create a search form where user can enter parameter they wish to search by
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
    
    public partial class SearchFirstNameDialog : Form
    {
        public bool SearchbyLName = false;
        public bool SearchbyFName = false;
        public bool SearchbyFLName = false;
        
        public string searchParameter;
        private bool haveValidsearchParameter = false;
       
        public SearchFirstNameDialog()
        {
            InitializeComponent();
        }

        private void CancelCourseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!haveValidsearchParameter)
            {
                MessageBox.Show("Enter a valid search parameter", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        
        private void EnterFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidsearchParameter = false;
            validatesearchParameter();
        }

        private void validatesearchParameter()
        {
            if (searchTextbox.Text.Trim().Length == 0)
            {
                haveValidsearchParameter = false;
            }
            else
            {
                haveValidsearchParameter = true;
                searchParameter = searchTextbox.Text.Trim();
            }
        }

        private void SearchFirstNameDialog_Load(object sender, EventArgs e)
        {
            if (SearchbyLName)
            {
                searchLabel.Text = "Enter Last Name";
                this.Text = "Search By Last Name:";
            }
            else if (SearchbyFName)
            {
                searchLabel.Text = "Enter First Name";
                this.Text = "Search By First Name:";
            }
            else if (SearchbyFLName)
            {
                searchLabel.Text = "Enter First and Last Name";
                this.Text = "Search By First And Last Name:";
            }

           
        }
    }
}
