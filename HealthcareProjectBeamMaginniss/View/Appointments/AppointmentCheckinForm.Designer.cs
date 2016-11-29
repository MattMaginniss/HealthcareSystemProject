namespace HealthcareProjectBeamMaginniss.View.Appointments
{
    partial class AppointmentCheckinForm
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
            this.comboBoxNurse = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.numUpDownSystolic = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDiastolic = new System.Windows.Forms.NumericUpDown();
            this.lblSystolic = new System.Windows.Forms.Label();
            this.lblDiastolic = new System.Windows.Forms.Label();
            this.numUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPulse = new System.Windows.Forms.NumericUpDown();
            this.lblPulse = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.numUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.lblLbs = new System.Windows.Forms.Label();
            this.txtBoxSymptoms = new System.Windows.Forms.TextBox();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSystolic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiastolic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Enabled = false;
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
            // comboBoxNurse
            // 
            this.comboBoxNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNurse.FormattingEnabled = true;
            this.comboBoxNurse.Location = new System.Drawing.Point(83, 107);
            this.comboBoxNurse.Name = "comboBoxNurse";
            this.comboBoxNurse.Size = new System.Drawing.Size(249, 21);
            this.comboBoxNurse.TabIndex = 4;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(83, 135);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(249, 21);
            this.comboBoxDoctor.TabIndex = 5;
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Location = new System.Drawing.Point(42, 110);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(35, 13);
            this.lblNurse.TabIndex = 6;
            this.lblNurse.Text = "Nurse";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(38, 138);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 7;
            this.lblDoctor.Text = "Doctor";
            // 
            // numUpDownSystolic
            // 
            this.numUpDownSystolic.Location = new System.Drawing.Point(83, 163);
            this.numUpDownSystolic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownSystolic.Name = "numUpDownSystolic";
            this.numUpDownSystolic.Size = new System.Drawing.Size(77, 20);
            this.numUpDownSystolic.TabIndex = 8;
            this.numUpDownSystolic.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numUpDownDiastolic
            // 
            this.numUpDownDiastolic.Location = new System.Drawing.Point(251, 163);
            this.numUpDownDiastolic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownDiastolic.Name = "numUpDownDiastolic";
            this.numUpDownDiastolic.Size = new System.Drawing.Size(81, 20);
            this.numUpDownDiastolic.TabIndex = 9;
            this.numUpDownDiastolic.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lblSystolic
            // 
            this.lblSystolic.AutoSize = true;
            this.lblSystolic.Location = new System.Drawing.Point(17, 165);
            this.lblSystolic.Name = "lblSystolic";
            this.lblSystolic.Size = new System.Drawing.Size(60, 13);
            this.lblSystolic.TabIndex = 10;
            this.lblSystolic.Text = "Systolic BP";
            // 
            // lblDiastolic
            // 
            this.lblDiastolic.AutoSize = true;
            this.lblDiastolic.Location = new System.Drawing.Point(181, 165);
            this.lblDiastolic.Name = "lblDiastolic";
            this.lblDiastolic.Size = new System.Drawing.Size(64, 13);
            this.lblDiastolic.TabIndex = 11;
            this.lblDiastolic.Text = "Diastolic BP";
            // 
            // numUpDownTemperature
            // 
            this.numUpDownTemperature.DecimalPlaces = 1;
            this.numUpDownTemperature.Location = new System.Drawing.Point(83, 189);
            this.numUpDownTemperature.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownTemperature.Name = "numUpDownTemperature";
            this.numUpDownTemperature.Size = new System.Drawing.Size(77, 20);
            this.numUpDownTemperature.TabIndex = 12;
            this.numUpDownTemperature.Value = new decimal(new int[] {
            986,
            0,
            0,
            65536});
            // 
            // numUpDownPulse
            // 
            this.numUpDownPulse.Location = new System.Drawing.Point(251, 189);
            this.numUpDownPulse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownPulse.Name = "numUpDownPulse";
            this.numUpDownPulse.Size = new System.Drawing.Size(81, 20);
            this.numUpDownPulse.TabIndex = 13;
            this.numUpDownPulse.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblPulse
            // 
            this.lblPulse.AutoSize = true;
            this.lblPulse.Location = new System.Drawing.Point(212, 191);
            this.lblPulse.Name = "lblPulse";
            this.lblPulse.Size = new System.Drawing.Size(33, 13);
            this.lblPulse.TabIndex = 14;
            this.lblPulse.Text = "Pulse";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(10, 191);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 15;
            this.lblTemp.Text = "Temperature";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(36, 217);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight";
            // 
            // numUpDownWeight
            // 
            this.numUpDownWeight.DecimalPlaces = 1;
            this.numUpDownWeight.Location = new System.Drawing.Point(83, 215);
            this.numUpDownWeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numUpDownWeight.Name = "numUpDownWeight";
            this.numUpDownWeight.Size = new System.Drawing.Size(77, 20);
            this.numUpDownWeight.TabIndex = 17;
            this.numUpDownWeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblLbs
            // 
            this.lblLbs.AutoSize = true;
            this.lblLbs.Location = new System.Drawing.Point(166, 217);
            this.lblLbs.Name = "lblLbs";
            this.lblLbs.Size = new System.Drawing.Size(20, 13);
            this.lblLbs.TabIndex = 18;
            this.lblLbs.Text = "LB";
            // 
            // txtBoxSymptoms
            // 
            this.txtBoxSymptoms.Location = new System.Drawing.Point(83, 241);
            this.txtBoxSymptoms.Name = "txtBoxSymptoms";
            this.txtBoxSymptoms.Size = new System.Drawing.Size(249, 20);
            this.txtBoxSymptoms.TabIndex = 19;
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Location = new System.Drawing.Point(22, 244);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(55, 13);
            this.lblSymptoms.TabIndex = 20;
            this.lblSymptoms.Text = "Symptoms";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(85, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(257, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // AppointmentCheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 304);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSymptoms);
            this.Controls.Add(this.txtBoxSymptoms);
            this.Controls.Add(this.lblLbs);
            this.Controls.Add(this.numUpDownWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblPulse);
            this.Controls.Add(this.numUpDownPulse);
            this.Controls.Add(this.numUpDownTemperature);
            this.Controls.Add(this.lblDiastolic);
            this.Controls.Add(this.lblSystolic);
            this.Controls.Add(this.numUpDownDiastolic);
            this.Controls.Add(this.numUpDownSystolic);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblNurse);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.comboBoxNurse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimeAppointment);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtBoxReason);
            this.Name = "AppointmentCheckinForm";
            this.Text = "Appointment Check-in";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSystolic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiastolic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox comboBoxNurse;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.NumericUpDown numUpDownSystolic;
        private System.Windows.Forms.NumericUpDown numUpDownDiastolic;
        private System.Windows.Forms.Label lblSystolic;
        private System.Windows.Forms.Label lblDiastolic;
        private System.Windows.Forms.NumericUpDown numUpDownTemperature;
        private System.Windows.Forms.NumericUpDown numUpDownPulse;
        private System.Windows.Forms.Label lblPulse;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown numUpDownWeight;
        private System.Windows.Forms.Label lblLbs;
        private System.Windows.Forms.TextBox txtBoxSymptoms;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}