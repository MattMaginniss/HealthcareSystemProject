using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    public partial class OrderLabTestForm : Form
    {
        #region Data members

        private readonly Appointment apt;
        private readonly LabTestController ltController;
        private readonly LabTestOrderedController ltoController;
        private readonly StaffController staffController;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderLabTestForm" /> class.
        /// </summary>
        /// <param name="apt">The appointment to order a test for.</param>
        public OrderLabTestForm(Appointment apt)
        {
            this.InitializeComponent();
            this.staffController = new StaffController();
            this.ltController = new LabTestController();
            this.ltoController = new LabTestOrderedController();
            this.apt = apt;
            this.setUpForm();
        }

        #endregion

        private void setUpForm()
        {
            var doctors = this.staffController.GetDoctors();
            var labTest = this.ltController.GetAll();

            this.comboBoxLabTests.DisplayMember = "TestName";
            this.comboBoxLabTests.ValueMember = "TestCode";
            this.comboBoxLabTests.DataSource = labTest;

            this.comboBoxDoctor.DisplayMember = "FullName";
            this.comboBoxDoctor.ValueMember = "StaffId";
            this.comboBoxDoctor.DataSource = doctors;
            this.comboBoxDoctor.SelectedItem = this.staffController.GetById(this.apt.DoctorId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var labTest = ((LabTest) this.comboBoxLabTests.SelectedItem).LabTestId;
            var date = this.dateTimeLabTest.Value;
            var doctor = ((Staff) this.comboBoxDoctor.SelectedItem).StaffId;
            try
            {
                var aptLabOrderController = new AppointmentLabOrderController();
                this.ltoController.Add(new LabTestOrder(labTest, doctor, date));
                aptLabOrderController.Add(new AppointmentLabOrder(this.apt.AppointmentId, this.ltoController.GetLastId()));
                Close();
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var createLabTest = new CreateLabTestForm();
            createLabTest.ShowDialog();
            this.setUpForm();
        }

        private void handleError(Exception exc)
        {
            MessageBox.Show(null, Resources.OrderLabTestForm_handleError_ + exc.Message, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }
    }
}