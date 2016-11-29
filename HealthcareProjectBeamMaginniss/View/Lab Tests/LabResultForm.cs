using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    public partial class LabResultForm : Form
    {
        #region Data members

        private readonly LabTestResult result;
        private readonly LabTestResultController resultController;
        private readonly LabTestOrdered testOrdered;

        #endregion

        #region Constructors

        public LabResultForm(LabTestOrdered testOrdered)
        {
            this.InitializeComponent();
            this.testOrdered = testOrdered;
            this.resultController = new LabTestResultController();
            this.result = this.resultController.GetById(testOrdered.TestResultId);
            if (this.result == null)
            {
                this.result = new LabTestResult(this.testOrdered.TestOrderedId, "");
            }
            this.textBox.Text = this.result.TestResults;
        }

        #endregion

        #region Methods

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.result.TestResults = this.textBox.Text;
            if (this.result.ResultId > 0)
            {
                this.resultController.Update(this.result);
            }
            else
            {
                this.resultController.Add(this.result);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}