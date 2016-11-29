namespace HealthcareProjectBeamMaginniss.View.Appointments
{
    partial class AddAppointmentForm
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
            this.txtBoxReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.txtBoxSymptoms = new System.Windows.Forms.TextBox();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Location = new System.Drawing.Point(83, 12);
            this.txtBoxReason.Multiline = true;
            this.txtBoxReason.Name = "txtBoxReason";
            this.txtBoxReason.Size = new System.Drawing.Size(249, 61);
            this.txtBoxReason.TabIndex = 0;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 29);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(65, 26);
            this.lblReason.TabIndex = 1;
            this.lblReason.Text = "Reason for\r\nappointment";
            this.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimeAppointment
            // 
            this.dateTimeAppointment.Location = new System.Drawing.Point(83, 80);
            this.dateTimeAppointment.Name = "dateTimeAppointment";
            this.dateTimeAppointment.Size = new System.Drawing.Size(249, 20);
            this.dateTimeAppointment.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(47, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(83, 106);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(249, 21);
            this.comboBoxDoctor.TabIndex = 5;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(38, 109);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 7;
            this.lblDoctor.Text = "Doctor";
            // 
            // txtBoxSymptoms
            // 
            this.txtBoxSymptoms.Location = new System.Drawing.Point(83, 133);
            this.txtBoxSymptoms.Name = "txtBoxSymptoms";
            this.txtBoxSymptoms.Size = new System.Drawing.Size(249, 20);
            this.txtBoxSymptoms.TabIndex = 19;
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Location = new System.Drawing.Point(22, 136);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(55, 13);
            this.lblSymptoms.TabIndex = 20;
            this.lblSymptoms.Text = "Symptoms";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(83, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(257, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 200);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSymptoms);
            this.Controls.Add(this.txtBoxSymptoms);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimeAppointment);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtBoxReason);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtBoxSymptoms;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}