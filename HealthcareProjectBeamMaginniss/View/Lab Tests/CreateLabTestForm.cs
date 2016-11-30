using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    /// <summary>
    ///     Creates a new lab test that can then be ordered by a doctor
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CreateLabTestForm : Form
    {
        #region Data members

        private readonly LabTestController ltController;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateLabTestForm" /> class.
        /// </summary>
        public CreateLabTestForm()
        {
            this.InitializeComponent();
            this.ltController = new LabTestController();
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var labTestName = this.txtLabTestName.Text;
            if (string.IsNullOrWhiteSpace(labTestName))
            {
                return;
            }
            try
            {
                this.ltController.Add(new LabTest(labTestName));
            }
            catch (Exception exc)
            {
                MessageBox.Show(null, Resources.CreateLabTestForm_btnSubmit_Click_ + exc.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }
    }
}