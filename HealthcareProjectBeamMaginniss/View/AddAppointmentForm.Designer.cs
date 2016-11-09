namespace HealthcareProjectBeamMaginniss.View
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
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxNurse = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.labelNurse = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.numericUpDownSystolic = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiastolic = new System.Windows.Forms.NumericUpDown();
            this.labelSystolic = new System.Windows.Forms.Label();
            this.labelDiastolic = new System.Windows.Forms.Label();
            this.numericUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPulse = new System.Windows.Forms.NumericUpDown();
            this.labelPulse = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelLbs = new System.Windows.Forms.Label();
            this.textBoxSymptoms = new System.Windows.Forms.TextBox();
            this.labelSymptoms = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSystolic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiastolic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(83, 12);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(249, 61);
            this.textBoxReason.TabIndex = 0;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(12, 29);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(65, 26);
            this.labelReason.TabIndex = 1;
            this.labelReason.Text = "Reason for\r\nappointment";
            this.labelReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(83, 80);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(249, 20);
            this.dateTimePickerAppointment.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(47, 80);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
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
            // labelNurse
            // 
            this.labelNurse.AutoSize = true;
            this.labelNurse.Location = new System.Drawing.Point(42, 110);
            this.labelNurse.Name = "labelNurse";
            this.labelNurse.Size = new System.Drawing.Size(35, 13);
            this.labelNurse.TabIndex = 6;
            this.labelNurse.Text = "Nurse";
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(38, 138);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(39, 13);
            this.labelDoctor.TabIndex = 7;
            this.labelDoctor.Text = "Doctor";
            // 
            // numericUpDownSystolic
            // 
            this.numericUpDownSystolic.Location = new System.Drawing.Point(83, 163);
            this.numericUpDownSystolic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSystolic.Name = "numericUpDownSystolic";
            this.numericUpDownSystolic.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownSystolic.TabIndex = 8;
            this.numericUpDownSystolic.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numericUpDownDiastolic
            // 
            this.numericUpDownDiastolic.Location = new System.Drawing.Point(251, 163);
            this.numericUpDownDiastolic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDiastolic.Name = "numericUpDownDiastolic";
            this.numericUpDownDiastolic.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownDiastolic.TabIndex = 9;
            this.numericUpDownDiastolic.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelSystolic
            // 
            this.labelSystolic.AutoSize = true;
            this.labelSystolic.Location = new System.Drawing.Point(17, 165);
            this.labelSystolic.Name = "labelSystolic";
            this.labelSystolic.Size = new System.Drawing.Size(60, 13);
            this.labelSystolic.TabIndex = 10;
            this.labelSystolic.Text = "Systolic BP";
            // 
            // labelDiastolic
            // 
            this.labelDiastolic.AutoSize = true;
            this.labelDiastolic.Location = new System.Drawing.Point(181, 165);
            this.labelDiastolic.Name = "labelDiastolic";
            this.labelDiastolic.Size = new System.Drawing.Size(64, 13);
            this.labelDiastolic.TabIndex = 11;
            this.labelDiastolic.Text = "Diastolic BP";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.DecimalPlaces = 1;
            this.numericUpDownTemperature.Location = new System.Drawing.Point(83, 189);
            this.numericUpDownTemperature.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownTemperature.TabIndex = 12;
            this.numericUpDownTemperature.Value = new decimal(new int[] {
            986,
            0,
            0,
            65536});
            // 
            // numericUpDownPulse
            // 
            this.numericUpDownPulse.Location = new System.Drawing.Point(251, 189);
            this.numericUpDownPulse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPulse.Name = "numericUpDownPulse";
            this.numericUpDownPulse.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownPulse.TabIndex = 13;
            this.numericUpDownPulse.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelPulse
            // 
            this.labelPulse.AutoSize = true;
            this.labelPulse.Location = new System.Drawing.Point(212, 191);
            this.labelPulse.Name = "labelPulse";
            this.labelPulse.Size = new System.Drawing.Size(33, 13);
            this.labelPulse.TabIndex = 14;
            this.labelPulse.Text = "Pulse";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(10, 191);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(67, 13);
            this.labelTemp.TabIndex = 15;
            this.labelTemp.Text = "Temperature";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(36, 217);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 16;
            this.labelWeight.Text = "Weight";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Location = new System.Drawing.Point(83, 215);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownWeight.TabIndex = 17;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // labelLbs
            // 
            this.labelLbs.AutoSize = true;
            this.labelLbs.Location = new System.Drawing.Point(166, 217);
            this.labelLbs.Name = "labelLbs";
            this.labelLbs.Size = new System.Drawing.Size(20, 13);
            this.labelLbs.TabIndex = 18;
            this.labelLbs.Text = "LB";
            // 
            // textBoxSymptoms
            // 
            this.textBoxSymptoms.Location = new System.Drawing.Point(83, 241);
            this.textBoxSymptoms.Name = "textBoxSymptoms";
            this.textBoxSymptoms.Size = new System.Drawing.Size(249, 20);
            this.textBoxSymptoms.TabIndex = 19;
            // 
            // labelSymptoms
            // 
            this.labelSymptoms.AutoSize = true;
            this.labelSymptoms.Location = new System.Drawing.Point(22, 244);
            this.labelSymptoms.Name = "labelSymptoms";
            this.labelSymptoms.Size = new System.Drawing.Size(55, 13);
            this.labelSymptoms.TabIndex = 20;
            this.labelSymptoms.Text = "Symptoms";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(85, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(257, 267);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 22;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 304);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSymptoms);
            this.Controls.Add(this.textBoxSymptoms);
            this.Controls.Add(this.labelLbs);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelPulse);
            this.Controls.Add(this.numericUpDownPulse);
            this.Controls.Add(this.numericUpDownTemperature);
            this.Controls.Add(this.labelDiastolic);
            this.Controls.Add(this.labelSystolic);
            this.Controls.Add(this.numericUpDownDiastolic);
            this.Controls.Add(this.numericUpDownSystolic);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelNurse);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.comboBoxNurse);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerAppointment);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.textBoxReason);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSystolic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiastolic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxNurse;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label labelNurse;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.NumericUpDown numericUpDownSystolic;
        private System.Windows.Forms.NumericUpDown numericUpDownDiastolic;
        private System.Windows.Forms.Label labelSystolic;
        private System.Windows.Forms.Label labelDiastolic;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDownPulse;
        private System.Windows.Forms.Label labelPulse;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelLbs;
        private System.Windows.Forms.TextBox textBoxSymptoms;
        private System.Windows.Forms.Label labelSymptoms;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}