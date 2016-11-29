using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View.Diagnoses
{
    public partial class AddEditDiagnosisForm : Form
    {
        #region Data members

        public int AptId;
        public Diagnosis Diagnosis;
        public DiagnosisController DiagnosisController;
        public bool Edit;

        #endregion

        #region Constructors

        public AddEditDiagnosisForm(int aptId)
        {
            this.InitializeComponent();
            this.Edit = false;
            this.AptId = aptId;
        }

        public AddEditDiagnosisForm(Diagnosis diagnosis)
        {
            this.InitializeComponent();
            this.Diagnosis = diagnosis;
            this.Edit = true;
            this.txtLabTestName.Text = diagnosis.DiagnosisInformation;
            this.chkFinal.Checked = diagnosis.FinalDiagnosis;
        }

        #endregion

        #region Methods

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DiagnosisController = new DiagnosisController();
            if (this.Edit)
            {
                this.DiagnosisController.Update(new Diagnosis(this.Diagnosis.DiagnosisId, this.txtLabTestName.Text,
                    this.Diagnosis.AppointmentId, this.chkFinal.Checked));
            }
            else
            {
                this.DiagnosisController.Add(new Diagnosis(this.txtLabTestName.Text, this.AptId, this.chkFinal.Checked));
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