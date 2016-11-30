using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    /// <summary>
    ///     Allows viewing and updating of lab results
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LabResultForm : Form
    {
        #region Data members

        private readonly LabTestResult result;
        private readonly LabTestResultController resultController;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LabResultForm" /> class.
        /// </summary>
        /// <param name="testOrder">The Lab Test Order.</param>
        public LabResultForm(LabTestOrder testOrder)
        {
            this.InitializeComponent();
            this.resultController = new LabTestResultController();
            try
            {
                this.result = this.resultController.GetById(testOrder.TestResultId);
            }
            catch
            {
                this.result = null;
            }
            if (this.result == null)
            {
                this.result = new LabTestResult(testOrder.TestOrderedId, "");
            }
            this.textBox.Text = this.result.TestResults;
        }

        #endregion

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
            MessageBox.Show(null, Resources.LabResultForm_handleError_ + exc.Message, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }
    }
}