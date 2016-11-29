namespace HealthcareProjectBeamMaginniss.View.Patients
{
    partial class AddPatientForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 41);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(5, 70);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Location = new System.Drawing.Point(27, 133);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(44, 13);
            this.lblAddr1.TabIndex = 3;
            this.lblAddr1.Text = "Street 1";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 292);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone #";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(77, 12);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 38);
            this.txtLastName.MaxLength = 45;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Location = new System.Drawing.Point(76, 64);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(195, 20);
            this.dateTimeDOB.TabIndex = 3;
            // 
            // txtAddr1
            // 
            this.txtAddr1.AcceptsReturn = true;
            this.txtAddr1.Location = new System.Drawing.Point(77, 130);
            this.txtAddr1.MaxLength = 100;
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(194, 20);
            this.txtAddr1.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 289);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 20);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumBox_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(78, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioBtnFemale);
            this.groupBoxSex.Controls.Add(this.radioBtnMale);
            this.groupBoxSex.Location = new System.Drawing.Point(77, 90);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(194, 34);
            this.groupBoxSex.TabIndex = 4;
            this.groupBoxSex.TabStop = false;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(101, 9);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Checked = true;
            this.radioBtnMale.Location = new System.Drawing.Point(27, 9);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(46, 99);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 14;
            this.lblSex.Text = "Sex";
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Location = new System.Drawing.Point(27, 160);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(44, 13);
            this.lblAddr2.TabIndex = 15;
            this.lblAddr2.Text = "Street 2";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(78, 157);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(193, 20);
            this.txtAddr2.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(78, 183);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(193, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(78, 209);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(193, 20);
            this.txtState.TabIndex = 8;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(78, 235);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(193, 20);
            this.txtZip.TabIndex = 9;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(47, 186);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(39, 212);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(47, 238);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(24, 13);
            this.lblZip.TabIndex = 22;
            this.lblZip.Text = "ZIP";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(78, 262);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(193, 21);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(29, 265);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 24;
            this.lblCountry.Text = "Country";
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 353);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "AddPatientForm";
            this.Text = "Add Patient";
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label lblCountry;
    }
}