namespace HealthcareProjectBeamMaginniss.View
{
    partial class ViewAppointmentForm
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
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.btnDGVReset = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radBtnBoth = new System.Windows.Forms.RadioButton();
            this.radioBtnName = new System.Windows.Forms.RadioButton();
            this.radBtnDOB = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dateTimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblSeachForAppointment = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOrderTests = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(12, 146);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(1137, 418);
            this.dgvAppointment.TabIndex = 0;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(1155, 146);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(96, 23);
            this.buttonCheckIn.TabIndex = 1;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // btnDGVReset
            // 
            this.btnDGVReset.Location = new System.Drawing.Point(1005, 62);
            this.btnDGVReset.Name = "btnDGVReset";
            this.btnDGVReset.Size = new System.Drawing.Size(144, 23);
            this.btnDGVReset.TabIndex = 28;
            this.btnDGVReset.Text = "Reset";
            this.btnDGVReset.UseVisualStyleBackColor = true;
            this.btnDGVReset.Click += new System.EventHandler(this.btnDGVReset_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.radBtnBoth);
            this.groupBoxSearch.Controls.Add(this.radioBtnName);
            this.groupBoxSearch.Controls.Add(this.radBtnDOB);
            this.groupBoxSearch.Location = new System.Drawing.Point(246, 22);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(113, 87);
            this.groupBoxSearch.TabIndex = 27;
            this.groupBoxSearch.TabStop = false;
            // 
            // radBtnBoth
            // 
            this.radBtnBoth.AutoSize = true;
            this.radBtnBoth.Location = new System.Drawing.Point(14, 60);
            this.radBtnBoth.Name = "radBtnBoth";
            this.radBtnBoth.Size = new System.Drawing.Size(84, 17);
            this.radBtnBoth.TabIndex = 2;
            this.radBtnBoth.TabStop = true;
            this.radBtnBoth.Text = "Search Both";
            this.radBtnBoth.UseVisualStyleBackColor = true;
            this.radBtnBoth.CheckedChanged += new System.EventHandler(this.radBtnBoth_CheckedChanged);
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
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(487, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 26;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(487, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 20);
            this.txtFirstName.TabIndex = 25;
            // 
            // dateTimeDateOfBirth
            // 
            this.dateTimeDateOfBirth.Enabled = false;
            this.dateTimeDateOfBirth.Location = new System.Drawing.Point(765, 35);
            this.dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            this.dateTimeDateOfBirth.Size = new System.Drawing.Size(181, 20);
            this.dateTimeDateOfBirth.TabIndex = 24;
            this.dateTimeDateOfBirth.Value = new System.DateTime(2016, 11, 25, 0, 0, 0, 0);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(420, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(421, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(693, 37);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(69, 13);
            this.lblDoB.TabIndex = 21;
            this.lblDoB.Text = "Date of Birth:";
            // 
            // lblSeachForAppointment
            // 
            this.lblSeachForAppointment.AutoSize = true;
            this.lblSeachForAppointment.Location = new System.Drawing.Point(106, 43);
            this.lblSeachForAppointment.Name = "lblSeachForAppointment";
            this.lblSeachForAppointment.Size = new System.Drawing.Size(135, 13);
            this.lblSeachForAppointment.TabIndex = 20;
            this.lblSeachForAppointment.Text = "Search for Appointment by:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1005, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 26);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search Appointment Data";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOrderTests
            // 
            this.btnOrderTests.Location = new System.Drawing.Point(1156, 176);
            this.btnOrderTests.Name = "btnOrderTests";
            this.btnOrderTests.Size = new System.Drawing.Size(95, 23);
            this.btnOrderTests.TabIndex = 29;
            this.btnOrderTests.Text = "Order Tests";
            this.btnOrderTests.UseVisualStyleBackColor = true;
            this.btnOrderTests.Click += new System.EventHandler(this.btnOrderTests_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.Location = new System.Drawing.Point(1156, 206);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(95, 36);
            this.btnDiagnosis.TabIndex = 30;
            this.btnDiagnosis.Text = "Add/Update Diagnosis";
            this.btnDiagnosis.UseVisualStyleBackColor = true;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // ViewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 576);
            this.Controls.Add(this.btnDiagnosis);
            this.Controls.Add(this.btnOrderTests);
            this.Controls.Add(this.btnDGVReset);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dateTimeDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblSeachForAppointment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.dgvAppointment);
            this.Name = "ViewAppointmentForm";
            this.Text = "View Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button btnDGVReset;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioBtnName;
        private System.Windows.Forms.RadioButton radBtnDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblSeachForAppointment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radBtnBoth;
        private System.Windows.Forms.Button btnOrderTests;
        private System.Windows.Forms.Button btnDiagnosis;
    }
}