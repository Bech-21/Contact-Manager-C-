/* create by :Bachir Mahomad
 Version:1
 Date:09/06/2019
 Objective: form to dispaly about information in the meny
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

namespace ContactManager
{
    public partial class HelpMenuDialog : Form
    {
        public HelpMenuDialog()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
