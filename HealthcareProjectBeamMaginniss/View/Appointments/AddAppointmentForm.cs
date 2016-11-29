using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Appointments
{
    public partial class AddAppointmentForm : Form
    {
        #region Data members

        private readonly int patientId;
        private readonly StaffController staffController;
        private AppointmentController aptController;

        #endregion

        #region Constructors

        public AddAppointmentForm(int patientId)
        {
            this.InitializeComponent();
            this.dateTimeAppointment.MinDate = DateTime.Today;
            this.staffController = new StaffController();
            this.patientId = patientId;
            this.loadStaff();
        }

        #endregion

        #region Methods

        private void loadStaff()
        {
            try
            {
                var doctors = this.staffController.GetDoctors();
                this.comboBoxDoctor.DisplayMember = "FullName";
                this.comboBoxDoctor.ValueMember = "StaffId";
                this.comboBoxDoctor.DataSource = doctors;
            }
            catch (Exception e)
            {
                this.handleError(e);
            }
        }

        private void handleError(Exception e)
        {
            MessageBox.Show(null,
                Resources.AddAppointmentForm_handleError_Exception_occurred__ + e.Message +
                Resources.AddAppointmentForm_handleError_, Resources.AddAppointmentForm_handleError_Error,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
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
            var doctor = ((Staff) this.comboBoxDoctor.SelectedItem).StaffId;
            if (string.IsNullOrWhiteSpace(reason) || string.IsNullOrWhiteSpace(symptoms))
            {
                return;
            }
            this.aptController = new AppointmentController();
            try
            {
                this.aptController.AddPartial(new Appointment(reason, date, doctor, this.patientId, symptoms));
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
            Close();
        }

        #endregion
    }
}