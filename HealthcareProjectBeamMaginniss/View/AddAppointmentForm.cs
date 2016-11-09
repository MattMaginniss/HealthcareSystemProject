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

        public AddAppointmentForm()
        {
            InitializeComponent();
            this.staffController = new StaffController();
            
            this.loadStaff();

        }

        private void loadStaff()
        {
            var nurses = this.staffController.GetNurses();
            var doctors = this.staffController.GetDoctors();
            this.comboBoxDoctor.DisplayMember = "FullName";
            this.comboBoxNurse.DisplayMember = "FullName";
            this.comboBoxDoctor.ValueMember = "StaffId";
            this.comboBoxNurse.ValueMember = "StaffId";
            this.comboBoxNurse.DataSource = nurses;
            this.comboBoxDoctor.DataSource = doctors;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var reason = this.textBoxReason.Text;
            var symptoms = this.textBoxSymptoms.Text;
            var date = this.dateTimePickerAppointment.Value;
            var nurse = ((Staff)this.comboBoxNurse.SelectedItem).StaffId;
            var doctor = ((Staff)this.comboBoxDoctor.SelectedItem).StaffId;
            var systolicBP = this.numericUpDownSystolic;
            var diastolicBP = this.numericUpDownDiastolic;
            var temp = this.numericUpDownTemperature.Value;
            var pulse = this.numericUpDownPulse.Value;
            var weight = this.numericUpDownWeight.Value;
            if (string.IsNullOrWhiteSpace(reason) || string.IsNullOrWhiteSpace(symptoms))
            {
                return;
            }
            this.aptController = new AppointmentController();
            this.aptController.Add(new Appointment(0,reason,date,nurse,doctor));
        }
    }
}