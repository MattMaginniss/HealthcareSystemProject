using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Appointments
{
    public partial class AppointmentCheckinForm : Form
    {
        #region Data members

        private readonly Appointment apt;
        private readonly StaffController staffController;
        private AppointmentController aptController;

        #endregion

        #region Constructors

        public AppointmentCheckinForm(Appointment apt)
        {
            this.InitializeComponent();
            this.staffController = new StaffController();
            this.apt = apt;
            try
            {
                this.loadStaff();
                this.fillForm();
            }
            catch (Exception e)
            {
                this.handleError(e);
            }
        }

        #endregion

        #region Methods

        private void fillForm()
        {
            this.txtBoxReason.Text = this.apt.ReasonForAppointment;
            this.txtBoxSymptoms.Text = this.apt.Symptoms;
            this.dateTimeAppointment.Value = this.apt.Date;
            this.comboBoxDoctor.SelectedItem = this.staffController.GetById(this.apt.DoctorId);
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
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var reason = this.txtBoxReason.Text;
            var symptoms = this.txtBoxSymptoms.Text;
            var date = this.dateTimeAppointment.Value;
            var nurse = ((Staff) this.comboBoxNurse.SelectedItem).StaffId;
            var doctor = ((Staff) this.comboBoxDoctor.SelectedItem).StaffId;
            var systolicBp = (int) this.numUpDownSystolic.Value;
            var diastolicBp = (int) this.numUpDownDiastolic.Value;
            var temp = this.numUpDownTemperature.Value;
            var pulse = (int) this.numUpDownPulse.Value;
            var weight = this.numUpDownWeight.Value;
            if (string.IsNullOrWhiteSpace(reason) || string.IsNullOrWhiteSpace(symptoms))
            {
                return;
            }
            this.aptController = new AppointmentController();
            try
            {
                this.aptController.Update(new Appointment(this.apt.AppointmentId, reason, date, nurse, doctor,
                    this.apt.PatientId,
                    systolicBp, diastolicBp, temp, pulse, weight, symptoms));
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
            Close();
        }

        private void handleError(Exception e)
        {
            MessageBox.Show(null,
                Resources.AppointmentCheckinForm_handleError_Exception_occurred__ + e.Message +
                Resources.AppointmentCheckinForm_handleError_, Resources.AppointmentCheckinForm_handleError_Error,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }

        #endregion
    }
}