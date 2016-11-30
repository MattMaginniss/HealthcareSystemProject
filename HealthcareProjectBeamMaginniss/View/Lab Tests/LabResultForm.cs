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
            try
            {
                if (this.result.ResultId > 0)
                {
                    this.resultController.Update(this.result);
                }
                else
                {
                    this.resultController.Add(this.result);
                }
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void handleError(Exception exc)
        {
            MessageBox.Show(null, "An error occured. Please try again later.\n" + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        #endregion
    }
}