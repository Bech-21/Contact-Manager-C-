namespace AddStudentTestDialog
{
    partial class SearchFirstNameDialog
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.Location = new System.Drawing.Point(-70, 43);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(296, 33);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Enter First and Last Name";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(232, 46);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(328, 26);
            this.searchTextbox.TabIndex = 1;
            this.searchTextbox.TextChanged += new System.EventHandler(this.EnterFirstNameTextbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(344, 87);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // cancelCourseButton
            // 
            this.cancelCourseButton.Location = new System.Drawing.Point(460, 87);
            this.cancelCourseButton.Name = "cancelCourseButton";
            this.cancelCourseButton.Size = new System.Drawing.Size(100, 32);
            this.cancelCourseButton.TabIndex = 3;
            this.cancelCourseButton.Text = "Cancel";
            this.cancelCourseButton.UseVisualStyleBackColor = true;
            this.cancelCourseButton.Click += new System.EventHandler(this.CancelCourseButton_Click);
            // 
            // SearchFirstNameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 193);
            this.Controls.Add(this.cancelCourseButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchLabel);
            this.Name = "SearchFirstNameDialog";
            this.Text = "Search By First Name";
            this.Load += new System.EventHandler(this.SearchFirstNameDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelCourseButton;
    }
}