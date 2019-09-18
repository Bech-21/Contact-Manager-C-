namespace AddStudentTestDialog
{
    partial class AddStudentDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTexbox = new System.Windows.Forms.TextBox();
            this.academicDepartmentLabel = new System.Windows.Forms.Label();
            this.academicDepartmentTextbox = new System.Windows.Forms.TextBox();
            this.graduationYearLabel = new System.Windows.Forms.Label();
            this.graduationYearTextbox = new System.Windows.Forms.TextBox();
            this.courseListLabel = new System.Windows.Forms.Label();
            this.contactInformationLabel = new System.Windows.Forms.Label();
            this.courseListListbox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.emailAddressTextbox = new System.Windows.Forms.TextBox();
            this.snailMailAddressLabel = new System.Windows.Forms.Label();
            this.snailMailAddressTextbox = new System.Windows.Forms.TextBox();
            this.courseAddToolTipLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(58, 17);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(87, 29);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(149, 23);
            this.firstNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(277, 20);
            this.firstNameTextbox.TabIndex = 1;
            this.firstNameTextbox.TextChanged += new System.EventHandler(this.FirstNameTextbox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(58, 45);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(87, 29);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTexbox
            // 
            this.lastNameTexbox.Location = new System.Drawing.Point(149, 51);
            this.lastNameTexbox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTexbox.Name = "lastNameTexbox";
            this.lastNameTexbox.Size = new System.Drawing.Size(277, 20);
            this.lastNameTexbox.TabIndex = 2;
            this.lastNameTexbox.TextChanged += new System.EventHandler(this.LastNameTexbox_TextChanged);
            // 
            // academicDepartmentLabel
            // 
            this.academicDepartmentLabel.Location = new System.Drawing.Point(18, 74);
            this.academicDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.academicDepartmentLabel.Name = "academicDepartmentLabel";
            this.academicDepartmentLabel.Size = new System.Drawing.Size(127, 29);
            this.academicDepartmentLabel.TabIndex = 0;
            this.academicDepartmentLabel.Text = "Academic Department:";
            this.academicDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // academicDepartmentTextbox
            // 
            this.academicDepartmentTextbox.Location = new System.Drawing.Point(149, 80);
            this.academicDepartmentTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.academicDepartmentTextbox.Name = "academicDepartmentTextbox";
            this.academicDepartmentTextbox.Size = new System.Drawing.Size(277, 20);
            this.academicDepartmentTextbox.TabIndex = 3;
            this.academicDepartmentTextbox.TextChanged += new System.EventHandler(this.AcademicDepartmentTextbox_TextChanged);
            // 
            // graduationYearLabel
            // 
            this.graduationYearLabel.Location = new System.Drawing.Point(21, 175);
            this.graduationYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.graduationYearLabel.Name = "graduationYearLabel";
            this.graduationYearLabel.Size = new System.Drawing.Size(134, 29);
            this.graduationYearLabel.TabIndex = 0;
            this.graduationYearLabel.Text = "Graduation Year:";
            this.graduationYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // graduationYearTextbox
            // 
            this.graduationYearTextbox.Location = new System.Drawing.Point(159, 181);
            this.graduationYearTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.graduationYearTextbox.Name = "graduationYearTextbox";
            this.graduationYearTextbox.Size = new System.Drawing.Size(88, 20);
            this.graduationYearTextbox.TabIndex = 6;
            this.graduationYearTextbox.TextChanged += new System.EventHandler(this.GraduationYearTextbox_TextChanged);
            // 
            // courseListLabel
            // 
            this.courseListLabel.Location = new System.Drawing.Point(68, 209);
            this.courseListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseListLabel.Name = "courseListLabel";
            this.courseListLabel.Size = new System.Drawing.Size(87, 29);
            this.courseListLabel.TabIndex = 0;
            this.courseListLabel.Text = "Course List:";
            this.courseListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contactInformationLabel
            // 
            this.contactInformationLabel.Location = new System.Drawing.Point(21, 103);
            this.contactInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactInformationLabel.Name = "contactInformationLabel";
            this.contactInformationLabel.Size = new System.Drawing.Size(124, 29);
            this.contactInformationLabel.TabIndex = 0;
            this.contactInformationLabel.Text = "Contact Information:";
            this.contactInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseListListbox
            // 
            this.courseListListbox.ContextMenuStrip = this.contextMenuStrip1;
            this.courseListListbox.FormattingEnabled = true;
            this.courseListListbox.Location = new System.Drawing.Point(159, 222);
            this.courseListListbox.Margin = new System.Windows.Forms.Padding(2);
            this.courseListListbox.Name = "courseListListbox";
            this.courseListListbox.Size = new System.Drawing.Size(267, 121);
            this.courseListListbox.TabIndex = 7;
            this.courseListListbox.MouseLeave += new System.EventHandler(this.CourseListListbox_MouseLeave);
            this.courseListListbox.MouseHover += new System.EventHandler(this.CourseListListbox_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course...";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(276, 356);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(352, 356);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.Location = new System.Drawing.Point(68, 123);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(134, 29);
            this.emailAddressLabel.TabIndex = 0;
            this.emailAddressLabel.Text = "Email Address:";
            this.emailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailAddressTextbox
            // 
            this.emailAddressTextbox.Location = new System.Drawing.Point(206, 129);
            this.emailAddressTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailAddressTextbox.Name = "emailAddressTextbox";
            this.emailAddressTextbox.Size = new System.Drawing.Size(219, 20);
            this.emailAddressTextbox.TabIndex = 4;
            this.emailAddressTextbox.TextChanged += new System.EventHandler(this.EmailAddressTextbox_TextChanged);
            // 
            // snailMailAddressLabel
            // 
            this.snailMailAddressLabel.Location = new System.Drawing.Point(68, 148);
            this.snailMailAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.snailMailAddressLabel.Name = "snailMailAddressLabel";
            this.snailMailAddressLabel.Size = new System.Drawing.Size(134, 29);
            this.snailMailAddressLabel.TabIndex = 0;
            this.snailMailAddressLabel.Text = "Snail Mail Address:";
            this.snailMailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // snailMailAddressTextbox
            // 
            this.snailMailAddressTextbox.Location = new System.Drawing.Point(206, 153);
            this.snailMailAddressTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.snailMailAddressTextbox.Name = "snailMailAddressTextbox";
            this.snailMailAddressTextbox.Size = new System.Drawing.Size(219, 20);
            this.snailMailAddressTextbox.TabIndex = 5;
            this.snailMailAddressTextbox.TextChanged += new System.EventHandler(this.SnailMailAddressTextbox_TextChanged);
            // 
            // courseAddToolTipLabel
            // 
            this.courseAddToolTipLabel.AutoSize = true;
            this.courseAddToolTipLabel.Location = new System.Drawing.Point(197, 207);
            this.courseAddToolTipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseAddToolTipLabel.Name = "courseAddToolTipLabel";
            this.courseAddToolTipLabel.Size = new System.Drawing.Size(169, 13);
            this.courseAddToolTipLabel.TabIndex = 11;
            this.courseAddToolTipLabel.Text = "Right click to add or delete course";
            this.courseAddToolTipLabel.Visible = false;
            // 
            // AddStudentDialog
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 403);
            this.Controls.Add(this.courseAddToolTipLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.courseListListbox);
            this.Controls.Add(this.snailMailAddressTextbox);
            this.Controls.Add(this.emailAddressTextbox);
            this.Controls.Add(this.graduationYearTextbox);
            this.Controls.Add(this.academicDepartmentTextbox);
            this.Controls.Add(this.lastNameTexbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.snailMailAddressLabel);
            this.Controls.Add(this.courseListLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.graduationYearLabel);
            this.Controls.Add(this.contactInformationLabel);
            this.Controls.Add(this.academicDepartmentLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudentDialog";
            this.Text = "Add Student Contact Information";
            this.Load += new System.EventHandler(this.AddStudentDialog_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTexbox;
        private System.Windows.Forms.Label academicDepartmentLabel;
        private System.Windows.Forms.TextBox academicDepartmentTextbox;
        private System.Windows.Forms.Label graduationYearLabel;
        private System.Windows.Forms.TextBox graduationYearTextbox;
        private System.Windows.Forms.Label courseListLabel;
        private System.Windows.Forms.Label contactInformationLabel;
        private System.Windows.Forms.ListBox courseListListbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox emailAddressTextbox;
        private System.Windows.Forms.Label snailMailAddressLabel;
        private System.Windows.Forms.TextBox snailMailAddressTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label courseAddToolTipLabel;
    }
}