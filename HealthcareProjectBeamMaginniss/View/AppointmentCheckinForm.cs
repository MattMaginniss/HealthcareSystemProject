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
    public partial class AppointmentCheckinForm : Form
    {
        private readonly StaffController staffController;
        private AppointmentController aptController;
        private readonly Appointment apt;

        public AppointmentCheckinForm(Appointment apt)
        {
            InitializeComponent();
            this.staffController = new StaffController();
            this.apt = apt;
            this.loadStaff();
            this.fillForm();

        }

        private void fillForm()
        {  
            this.txtBoxReason.Text = this.apt.ReasonForAppointment;
            this.txtBoxSymptoms.Text = this.apt.symptoms;
            this.dateTimeAppointment.Value = this.apt.date;
            this.comboBoxDoctor.SelectedItem = this.staffController.GetById(this.apt.doctorID);
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
            var reason = this.txtBoxReason.Text;
            var symptoms = this.txtBoxSymptoms.Text;
            var date = this.dateTimeAppointment.Value;
            var nurse = ((Staff)this.comboBoxNurse.SelectedItem).StaffId;
            var doctor = ((Staff)this.comboBoxDoctor.SelectedItem).StaffId;
            var systolicBP =(int) this.numUpDownSystolic.Value;
            var diastolicBP = (int)this.numUpDownDiastolic.Value;
            var temp = this.numUpDownTemperature.Value;
            var pulse = (int)this.numUpDownPulse.Value;
            var weight = this.numUpDownWeight.Value;
            if (string.IsNullOrWhiteSpace(reason) || string.IsNullOrWhiteSpace(symptoms))
            {
                return;
            }
            this.aptController = new AppointmentController();
            this.aptController.Update(new Appointment(this.apt.AppointmentID,reason,date,nurse,doctor, this.apt.patientID, systolicBP, diastolicBP, temp,pulse,weight,symptoms,this.apt.diagnosisID));
            this.Close();
        }
    }
}