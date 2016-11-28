﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class OrderLabTestForm : Form
    {
        private readonly StaffController staffController;
        private AppointmentController aptController;
        private readonly LabTestController ltController;
        private readonly Appointment apt;

        public OrderLabTestForm(Appointment apt)
        {
            InitializeComponent();
            this.staffController = new StaffController();
            this.ltController = new LabTestController();
            this.apt = apt;
            this.SetUpForm();
        }

        private void SetUpForm()
        {
            var doctors = this.staffController.GetDoctors();
            var labTest = this.ltController.GetAll();

            this.comboBoxLabTests.DisplayMember = "TestName";
            this.comboBoxLabTests.ValueMember = "TestCode";
            this.comboBoxLabTests.DataSource = labTest;

            this.comboBoxDoctor.DisplayMember = "FullName";
            this.comboBoxDoctor.ValueMember = "StaffId";
            this.comboBoxDoctor.DataSource = doctors;
            this.comboBoxDoctor.SelectedItem = this.staffController.GetById(this.apt.doctorID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var createLabTest = new CreateLabTestForm();
            createLabTest.ShowDialog();
            this.SetUpForm();
        }
    }
}
