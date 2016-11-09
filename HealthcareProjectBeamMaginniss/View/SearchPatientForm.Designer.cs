namespace HealthcareProjectBeamMaginniss.View
{
    partial class SearchPatientForm
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
            this.lblSeachForPatient = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateTimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioBtnName = new System.Windows.Forms.RadioButton();
            this.radBtnDOB = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeachForPatient
            // 
            this.lblSeachForPatient.AutoSize = true;
            this.lblSeachForPatient.Location = new System.Drawing.Point(72, 54);
            this.lblSeachForPatient.Name = "lblSeachForPatient";
            this.lblSeachForPatient.Size = new System.Drawing.Size(109, 13);
            this.lblSeachForPatient.TabIndex = 0;
            this.lblSeachForPatient.Text = "Search for Patient by:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(56, 203);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(69, 13);
            this.lblDoB.TabIndex = 1;
            this.lblDoB.Text = "Date of Birth:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(76, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(76, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // dateTimeDateOfBirth
            // 
            this.dateTimeDateOfBirth.Enabled = false;
            this.dateTimeDateOfBirth.Location = new System.Drawing.Point(127, 197);
            this.dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            this.dateTimeDateOfBirth.Size = new System.Drawing.Size(190, 20);
            this.dateTimeDateOfBirth.TabIndex = 4;
            this.dateTimeDateOfBirth.Value = new System.DateTime(2016, 11, 9, 9, 49, 50, 0);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.radioBtnName);
            this.groupBoxSearch.Controls.Add(this.radBtnDOB);
            this.groupBoxSearch.Location = new System.Drawing.Point(187, 27);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(113, 64);
            this.groupBoxSearch.TabIndex = 8;
            this.groupBoxSearch.TabStop = false;
            // 
            // radioBtnName
            // 
            this.radioBtnName.AutoSize = true;
            this.radioBtnName.Checked = true;
            this.radioBtnName.Location = new System.Drawing.Point(14, 13);
            this.radioBtnName.Name = "radioBtnName";
            this.radioBtnName.Size = new System.Drawing.Size(53, 17);
            this.radioBtnName.TabIndex = 1;
            this.radioBtnName.TabStop = true;
            this.radioBtnName.Text = "Name";
            this.radioBtnName.UseVisualStyleBackColor = true;
            this.radioBtnName.CheckedChanged += new System.EventHandler(this.radioBtnName_CheckedChanged);
            // 
            // radBtnDOB
            // 
            this.radBtnDOB.AutoSize = true;
            this.radBtnDOB.Location = new System.Drawing.Point(14, 36);
            this.radBtnDOB.Name = "radBtnDOB";
            this.radBtnDOB.Size = new System.Drawing.Size(84, 17);
            this.radBtnDOB.TabIndex = 0;
            this.radBtnDOB.Text = "Date of Birth";
            this.radBtnDOB.UseVisualStyleBackColor = true;
            this.radBtnDOB.CheckedChanged += new System.EventHandler(this.radBtnDOB_CheckedChanged);
            // 
            // SearchPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 293);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dateTimeDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblSeachForPatient);
            this.Name = "SearchPatientForm";
            this.Text = "Search for Patient";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeachForPatient;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioBtnName;
        private System.Windows.Forms.RadioButton radBtnDOB;
    }
}