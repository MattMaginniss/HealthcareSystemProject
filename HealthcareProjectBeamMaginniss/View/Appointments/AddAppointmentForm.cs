using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

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
            this.staffController = new StaffController();
            this.patientId = patientId;
            this.loadStaff();
        }

        #endregion

        #region Methods

        private void loadStaff()
        {
            var doctors = this.staffController.GetDoctors();
            this.comboBoxDoctor.DisplayMember = "FullName";
            this.comboBoxDoctor.ValueMember = "StaffId";
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
            var doctor = ((Staff) this.comboBoxDoctor.SelectedItem).StaffId;
            if (string.IsNullOrWhiteSpace(reason) || string.IsNullOrWhiteSpace(symptoms))
            {
                return;
            }
            this.aptController = new AppointmentController();
            this.aptController.AddPartial(new Appointment(reason, date, doctor, this.patientId, symptoms));
            Close();
        }

        #endregion
    }
}