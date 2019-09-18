namespace AddStudentTestDialog
{
    partial class AddCourseDialog
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
            this.addCourseLabel = new System.Windows.Forms.Label();
            this.addCourseTextbox = new System.Windows.Forms.TextBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.cancelCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCourseLabel
            // 
            this.addCourseLabel.Location = new System.Drawing.Point(82, 48);
            this.addCourseLabel.Name = "addCourseLabel";
            this.addCourseLabel.Size = new System.Drawing.Size(124, 32);
            this.addCourseLabel.TabIndex = 0;
            this.addCourseLabel.Text = "Add Course";
            this.addCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addCourseTextbox
            // 
            this.addCourseTextbox.Location = new System.Drawing.Point(214, 48);
            this.addCourseTextbox.Multiline = true;
            this.addCourseTextbox.Name = "addCourseTextbox";
            this.addCourseTextbox.Size = new System.Drawing.Size(378, 33);
            this.addCourseTextbox.TabIndex = 1;
            this.addCourseTextbox.TextChanged += new System.EventHandler(this.AddCourseTextbox_TextChanged);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(370, 95);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(100, 37);
            this.addCourseButton.TabIndex = 2;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // cancelCourseButton
            // 
            this.cancelCourseButton.Location = new System.Drawing.Point(490, 95);
            this.cancelCourseButton.Name = "cancelCourseButton";
            this.cancelCourseButton.Size = new System.Drawing.Size(100, 37);
            this.cancelCourseButton.TabIndex = 3;
            this.cancelCourseButton.Text = "Cancel";
            this.cancelCourseButton.UseVisualStyleBackColor = true;
            this.cancelCourseButton.Click += new System.EventHandler(this.CancelCourseButton_Click);
            // 
            // AddCourseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 192);
            this.Controls.Add(this.cancelCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.addCourseTextbox);
            this.Controls.Add(this.addCourseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCourseDialog";
            this.Text = "AddCourseDialog";
            this.Load += new System.EventHandler(this.AddCourseDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addCourseLabel;
        private System.Windows.Forms.TextBox addCourseTextbox;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button cancelCourseButton;
    }
}