using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    public partial class CreateLabTestForm : Form
    {
        #region Data members

        private readonly LabTestController ltController;

        #endregion

        #region Constructors

        public CreateLabTestForm()
        {
            this.InitializeComponent();
            this.ltController = new LabTestController();
        }

        #endregion

        #region Methods

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
            this.ltController.Add(new LabTest(labTestName));
            Close();
        }

        #endregion
    }
}