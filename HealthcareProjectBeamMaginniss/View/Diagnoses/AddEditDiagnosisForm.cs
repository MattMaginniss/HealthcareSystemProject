using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Diagnoses
{
    /// <summary>
    ///     Allows the creation and modification of diagnoses
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddEditDiagnosisForm : Form
    {
        #region Data members

        private readonly int aptId;
        private readonly Diagnosis diagnosis;
        private DiagnosisController diagnosisController;
        private readonly bool edit;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddEditDiagnosisForm" /> class.
        /// </summary>
        /// <param name="aptId">The appointment identifier.</param>
        public AddEditDiagnosisForm(int aptId)
        {
            this.InitializeComponent();
            this.edit = false;
            this.aptId = aptId;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddEditDiagnosisForm" /> class.
        /// </summary>
        /// <param name="diagnosis">The diagnosis.</param>
        public AddEditDiagnosisForm(Diagnosis diagnosis)
        {
            this.InitializeComponent();
            this.diagnosis = diagnosis;
            this.edit = true;
            this.txtLabTestName.Text = diagnosis.DiagnosisInformation;
            this.chkFinal.Checked = diagnosis.FinalDiagnosis;
        }

        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.diagnosisController = new DiagnosisController();
                if (this.edit)
                {
                    this.diagnosisController.Update(new Diagnosis(this.diagnosis.DiagnosisId, this.txtLabTestName.Text,
                        this.diagnosis.AppointmentId, this.chkFinal.Checked));
                }
                else
                {
                    this.diagnosisController.Add(new Diagnosis(this.txtLabTestName.Text, this.aptId,
                        this.chkFinal.Checked));
                }
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(null,
                    Resources.AddEditDiagnosisForm_btnSubmit_Click_Exception_occurred__ + exc.Message +
                    Resources.AddEditDiagnosisForm_btnSubmit_Click_,
                    Resources.AddEditDiagnosisForm_btnSubmit_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}