namespace Students
{
    partial class Form1
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
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.addStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.newStudentNumber = new System.Windows.Forms.NumericUpDown();
            this.newStudentLastName = new System.Windows.Forms.TextBox();
            this.newStudentFirstName = new System.Windows.Forms.TextBox();
            this.updateStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.studentNumber = new System.Windows.Forms.NumericUpDown();
            this.studentFirstName = new System.Windows.Forms.TextBox();
            this.studentLastName = new System.Windows.Forms.TextBox();
            this.addStudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentNumber)).BeginInit();
            this.updateStudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(13, 13);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(142, 69);
            this.studentsListBox.TabIndex = 0;
            this.studentsListBox.SelectedIndexChanged += new System.EventHandler(this.studentsListBox_SelectedIndexChanged);
            // 
            // addStudentGroupBox
            // 
            this.addStudentGroupBox.Controls.Add(this.addStudentButton);
            this.addStudentGroupBox.Controls.Add(this.newStudentNumber);
            this.addStudentGroupBox.Controls.Add(this.newStudentLastName);
            this.addStudentGroupBox.Controls.Add(this.newStudentFirstName);
            this.addStudentGroupBox.Location = new System.Drawing.Point(212, 13);
            this.addStudentGroupBox.Name = "addStudentGroupBox";
            this.addStudentGroupBox.Size = new System.Drawing.Size(200, 113);
            this.addStudentGroupBox.TabIndex = 1;
            this.addStudentGroupBox.TabStop = false;
            this.addStudentGroupBox.Text = "Add student";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(118, 43);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // newStudentNumber
            // 
            this.newStudentNumber.Location = new System.Drawing.Point(6, 19);
            this.newStudentNumber.Name = "newStudentNumber";
            this.newStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.newStudentNumber.TabIndex = 2;
            // 
            // newStudentLastName
            // 
            this.newStudentLastName.Location = new System.Drawing.Point(6, 71);
            this.newStudentLastName.Name = "newStudentLastName";
            this.newStudentLastName.Size = new System.Drawing.Size(100, 20);
            this.newStudentLastName.TabIndex = 1;
            // 
            // newStudentFirstName
            // 
            this.newStudentFirstName.Location = new System.Drawing.Point(6, 45);
            this.newStudentFirstName.Name = "newStudentFirstName";
            this.newStudentFirstName.Size = new System.Drawing.Size(100, 20);
            this.newStudentFirstName.TabIndex = 0;
            // 
            // updateStudentGroupBox
            // 
            this.updateStudentGroupBox.Controls.Add(this.updateButton);
            this.updateStudentGroupBox.Controls.Add(this.studentNumber);
            this.updateStudentGroupBox.Controls.Add(this.studentFirstName);
            this.updateStudentGroupBox.Controls.Add(this.studentLastName);
            this.updateStudentGroupBox.Location = new System.Drawing.Point(212, 142);
            this.updateStudentGroupBox.Name = "updateStudentGroupBox";
            this.updateStudentGroupBox.Size = new System.Drawing.Size(200, 100);
            this.updateStudentGroupBox.TabIndex = 2;
            this.updateStudentGroupBox.TabStop = false;
            this.updateStudentGroupBox.Text = "Update student";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(118, 43);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(6, 19);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(100, 20);
            this.studentNumber.TabIndex = 6;
            // 
            // studentFirstName
            // 
            this.studentFirstName.Location = new System.Drawing.Point(6, 45);
            this.studentFirstName.Name = "studentFirstName";
            this.studentFirstName.Size = new System.Drawing.Size(100, 20);
            this.studentFirstName.TabIndex = 4;
            // 
            // studentLastName
            // 
            this.studentLastName.Location = new System.Drawing.Point(6, 71);
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.Size = new System.Drawing.Size(100, 20);
            this.studentLastName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.updateStudentGroupBox);
            this.Controls.Add(this.addStudentGroupBox);
            this.Controls.Add(this.studentsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addStudentGroupBox.ResumeLayout(false);
            this.addStudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentNumber)).EndInit();
            this.updateStudentGroupBox.ResumeLayout(false);
            this.updateStudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.GroupBox addStudentGroupBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.NumericUpDown newStudentNumber;
        private System.Windows.Forms.TextBox newStudentLastName;
        private System.Windows.Forms.TextBox newStudentFirstName;
        private System.Windows.Forms.GroupBox updateStudentGroupBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.NumericUpDown studentNumber;
        private System.Windows.Forms.TextBox studentFirstName;
        private System.Windows.Forms.TextBox studentLastName;
    }
}

