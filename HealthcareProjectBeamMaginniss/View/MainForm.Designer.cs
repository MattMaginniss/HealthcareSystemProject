namespace HealthcareProjectBeamMaginniss.View
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddPatientButton = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnViewAppointments = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioBtnName = new System.Windows.Forms.RadioButton();
            this.radBtnDOB = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dateTimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblSeachForPatient = new System.Windows.Forms.Label();
            this.btnDGVReset = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnDoBReport = new System.Windows.Forms.Button();
            this.btnViewPatientDiagnoses = new System.Windows.Forms.Button();
            this.btnViewPatientTests = new System.Windows.Forms.Button();
            this.btnViewPatientApts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(16, 106);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.Size = new System.Drawing.Size(1220, 700);
            this.patientDataGridView.TabIndex = 0;
            // 
            // btnAddPatientButton
            // 
            this.btnAddPatientButton.Location = new System.Drawing.Point(1244, 106);
            this.btnAddPatientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPatientButton.Name = "btnAddPatientButton";
            this.btnAddPatientButton.Size = new System.Drawing.Size(192, 28);
            this.btnAddPatientButton.TabIndex = 1;
            this.btnAddPatientButton.Text = "Add Patient";
            this.btnAddPatientButton.UseVisualStyleBackColor = true;
            this.btnAddPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1005, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Patient Data";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(1244, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(74, 17);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(1244, 38);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(52, 17);
            this.lblLogout.TabIndex = 4;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLogout_LinkClicked);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(1244, 177);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(192, 28);
            this.btnAddAppointment.TabIndex = 5;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // btnViewAppointments
            // 
            this.btnViewAppointments.Location = new System.Drawing.Point(1244, 467);
            this.btnViewAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAppointments.Name = "btnViewAppointments";
            this.btnViewAppointments.Size = new System.Drawing.Size(192, 28);
            this.btnViewAppointments.TabIndex = 6;
            this.btnViewAppointments.Text = "View All Appointments";
            this.btnViewAppointments.UseVisualStyleBackColor = true;
            this.btnViewAppointments.Click += new System.EventHandler(this.buttonViewAppointments_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.radioBtnName);
            this.groupBoxSearch.Controls.Add(this.radBtnDOB);
            this.groupBoxSearch.Location = new System.Drawing.Point(185, 22);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSearch.Size = new System.Drawing.Size(151, 79);
            this.groupBoxSearch.TabIndex = 17;
            this.groupBoxSearch.TabStop = false;
            // 
            // radioBtnName
            // 
            this.radioBtnName.AutoSize = true;
            this.radioBtnName.Checked = true;
            this.radioBtnName.Location = new System.Drawing.Point(19, 16);
            this.radioBtnName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnName.Name = "radioBtnName";
            this.radioBtnName.Size = new System.Drawing.Size(66, 21);
            this.radioBtnName.TabIndex = 1;
            this.radioBtnName.TabStop = true;
            this.radioBtnName.Text = "Name";
            this.radioBtnName.UseVisualStyleBackColor = true;
            this.radioBtnName.CheckedChanged += new System.EventHandler(this.radioBtnName_CheckedChanged_1);
            // 
            // radBtnDOB
            // 
            this.radBtnDOB.AutoSize = true;
            this.radBtnDOB.Location = new System.Drawing.Point(19, 44);
            this.radBtnDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBtnDOB.Name = "radBtnDOB";
            this.radBtnDOB.Size = new System.Drawing.Size(108, 21);
            this.radBtnDOB.TabIndex = 0;
            this.radBtnDOB.Text = "Date of Birth";
            this.radBtnDOB.UseVisualStyleBackColor = true;
            this.radBtnDOB.CheckedChanged += new System.EventHandler(this.radBtnDOB_CheckedChanged_1);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(453, 68);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 22);
            this.txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(453, 33);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 22);
            this.txtFirstName.TabIndex = 14;
            // 
            // dateTimeDateOfBirth
            // 
            this.dateTimeDateOfBirth.Enabled = false;
            this.dateTimeDateOfBirth.Location = new System.Drawing.Point(756, 33);
            this.dateTimeDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            this.dateTimeDateOfBirth.Size = new System.Drawing.Size(240, 22);
            this.dateTimeDateOfBirth.TabIndex = 13;
            this.dateTimeDateOfBirth.Value = new System.DateTime(2016, 11, 25, 0, 0, 0, 0);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(364, 71);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(365, 36);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(660, 36);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(91, 17);
            this.lblDoB.TabIndex = 10;
            this.lblDoB.Text = "Date of Birth:";
            // 
            // lblSeachForPatient
            // 
            this.lblSeachForPatient.AutoSize = true;
            this.lblSeachForPatient.Location = new System.Drawing.Point(32, 54);
            this.lblSeachForPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeachForPatient.Name = "lblSeachForPatient";
            this.lblSeachForPatient.Size = new System.Drawing.Size(145, 17);
            this.lblSeachForPatient.TabIndex = 9;
            this.lblSeachForPatient.Text = "Search for Patient by:";
            // 
            // btnDGVReset
            // 
            this.btnDGVReset.Location = new System.Drawing.Point(1005, 70);
            this.btnDGVReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDGVReset.Name = "btnDGVReset";
            this.btnDGVReset.Size = new System.Drawing.Size(192, 28);
            this.btnDGVReset.TabIndex = 18;
            this.btnDGVReset.Text = "Reset";
            this.btnDGVReset.UseVisualStyleBackColor = true;
            this.btnDGVReset.Click += new System.EventHandler(this.btnDGVReset_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Location = new System.Drawing.Point(1244, 142);
            this.btnEditPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(192, 28);
            this.btnEditPatient.TabIndex = 19;
            this.btnEditPatient.Text = "Edit Patient";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnDoBReport
            // 
            this.btnDoBReport.Location = new System.Drawing.Point(1244, 503);
            this.btnDoBReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoBReport.Name = "btnDoBReport";
            this.btnDoBReport.Size = new System.Drawing.Size(192, 28);
            this.btnDoBReport.TabIndex = 20;
            this.btnDoBReport.Text = "View Patient DoB Report";
            this.btnDoBReport.UseVisualStyleBackColor = true;
            this.btnDoBReport.Click += new System.EventHandler(this.btnDoBReport_Click);
            // 
            // btnViewPatientDiagnoses
            // 
            this.btnViewPatientDiagnoses.Location = new System.Drawing.Point(1244, 314);
            this.btnViewPatientDiagnoses.Name = "btnViewPatientDiagnoses";
            this.btnViewPatientDiagnoses.Size = new System.Drawing.Size(192, 23);
            this.btnViewPatientDiagnoses.TabIndex = 21;
            this.btnViewPatientDiagnoses.Text = "View Patient Diagnoses";
            this.btnViewPatientDiagnoses.UseVisualStyleBackColor = true;
            this.btnViewPatientDiagnoses.Click += new System.EventHandler(this.btnViewPatientDiagnoses_Click);
            // 
            // btnViewPatientTests
            // 
            this.btnViewPatientTests.Location = new System.Drawing.Point(1243, 343);
            this.btnViewPatientTests.Name = "btnViewPatientTests";
            this.btnViewPatientTests.Size = new System.Drawing.Size(193, 23);
            this.btnViewPatientTests.TabIndex = 22;
            this.btnViewPatientTests.Text = "View Patient Tests";
            this.btnViewPatientTests.UseVisualStyleBackColor = true;
            this.btnViewPatientTests.Click += new System.EventHandler(this.btnViewPatientTests_Click);
            // 
            // btnViewPatientApts
            // 
            this.btnViewPatientApts.Location = new System.Drawing.Point(1244, 279);
            this.btnViewPatientApts.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPatientApts.Name = "btnViewPatientApts";
            this.btnViewPatientApts.Size = new System.Drawing.Size(192, 28);
            this.btnViewPatientApts.TabIndex = 23;
            this.btnViewPatientApts.Text = "View Patient Appointments";
            this.btnViewPatientApts.UseVisualStyleBackColor = true;
            this.btnViewPatientApts.Click += new System.EventHandler(this.btnViewPatientApts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 828);
            this.Controls.Add(this.btnViewPatientApts);
            this.Controls.Add(this.btnViewPatientTests);
            this.Controls.Add(this.btnViewPatientDiagnoses);
            this.Controls.Add(this.btnDoBReport);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnDGVReset);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dateTimeDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblSeachForPatient);
            this.Controls.Add(this.btnViewAppointments);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddPatientButton);
            this.Controls.Add(this.patientDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "NATT Healthcare Systems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button btnAddPatientButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnViewAppointments;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioBtnName;
        private System.Windows.Forms.RadioButton radBtnDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblSeachForPatient;
        private System.Windows.Forms.Button btnDGVReset;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnDoBReport;
        private System.Windows.Forms.Button btnViewPatientDiagnoses;
        private System.Windows.Forms.Button btnViewPatientTests;
        private System.Windows.Forms.Button btnViewPatientApts;
    }
}