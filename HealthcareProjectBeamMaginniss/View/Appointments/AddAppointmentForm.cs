using System;
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
    public partial class AddAppointmentForm : Form
    {
        private readonly StaffController staffController;
        private AppointmentController aptController;
        private readonly int patientID;

        public AddAppointmentForm(int patientID)
        {
            InitializeComponent();
            this.staffController = new StaffController();
            this.patientID = patientID;
            this.loadStaff();

        }

        private void loadStaff()
        {
            var doctors = this.staffController.GetDoctors();
            this.comboBoxDoctor.DisplayMember = "FullName";
            this.comboBoxDoctor.ValueMember = "StaffId";
            this.comboBoxDoctor.DataSource = doctors;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var reason = this.txtBoxReason.Text;
            var symptoms = this.txtBoxSymptoms.Text;
            var date = this.dateTimeAppointment.Value;
            var doctor = ((Staff)this.comboBoxDoctor.SelectedItem).StaffId;
            if (string.IsNullOrWhiteSpace(reason) || string.IsNullOrWhiteSpace(symptoms))
            {
                return;
            }
            this.aptController = new AppointmentController();
            this.aptController.AddPartial(new Appointment(reason,date,doctor, this.patientID,symptoms));
            this.Close();
        }

    }
}