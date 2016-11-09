﻿namespace HealthcareProjectBeamMaginniss.View
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
            this.addPatientButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.LinkLabel();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonViewAppointments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(13, 13);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.Size = new System.Drawing.Size(915, 569);
            this.patientDataGridView.TabIndex = 0;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(934, 86);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(144, 23);
            this.addPatientButton.TabIndex = 1;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(934, 144);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(144, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search Patient Data";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(934, 13);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(58, 13);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Location = new System.Drawing.Point(934, 42);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(40, 13);
            this.labelLogout.TabIndex = 4;
            this.labelLogout.TabStop = true;
            this.labelLogout.Text = "Logout";
            this.labelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLogout_LinkClicked);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(934, 115);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(144, 23);
            this.buttonAddAppointment.TabIndex = 5;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonViewAppointments
            // 
            this.buttonViewAppointments.Location = new System.Drawing.Point(937, 559);
            this.buttonViewAppointments.Name = "buttonViewAppointments";
            this.buttonViewAppointments.Size = new System.Drawing.Size(141, 23);
            this.buttonViewAppointments.TabIndex = 6;
            this.buttonViewAppointments.Text = "View Appointments";
            this.buttonViewAppointments.UseVisualStyleBackColor = true;
            this.buttonViewAppointments.Click += new System.EventHandler(this.buttonViewAppointments_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 601);
            this.Controls.Add(this.buttonViewAppointments);
            this.Controls.Add(this.buttonAddAppointment);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientDataGridView);
            this.Name = "MainForm";
            this.Text = "NATT Healthcare Systems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.LinkLabel labelLogout;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonViewAppointments;
    }
}