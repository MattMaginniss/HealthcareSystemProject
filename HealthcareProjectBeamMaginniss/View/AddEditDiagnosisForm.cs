using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class AddEditDiagnosisForm : Form
    {
        public Diagnosis diagnosis;
        public Boolean edit;
        public DiagnosisController diagnosisController;
        public AddEditDiagnosisForm(String formName)
        {
            InitializeComponent();
            this.Text = formName;
            this.edit = false;
        }


        public AddEditDiagnosisForm(String formName, Diagnosis diagnosis)
        {
            InitializeComponent();
            this.Text = formName;
            this.diagnosis = diagnosis;
            this.edit = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.diagnosisController = new DiagnosisController();
            if (this.edit)
            {
                this.diagnosisController.Update(new Diagnosis(this.diagnosis.diagnosisId, this.txtLabTestName.Text,
                    this.diagnosis.appointment_id, this.chkFinal.Checked));
            }
            else
            {
                /* this.diagnosisController.Add(new Diagnosis(this.txtLabTestName.Text,
                    this.diagnosis.appointment_id, this.chkFinal.Checked));
                 */
            }
        }
    }
}
