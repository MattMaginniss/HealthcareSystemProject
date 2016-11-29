using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class LabResultForm : Form
    {
        private LabTestOrdered testOrdered;
        private LabTestResult result;
        private LabTestResultController resultController;

        public LabResultForm(LabTestOrdered testOrdered)
        {
            this.testOrdered = testOrdered;
            this.resultController = new LabTestResultController();
            this.result = resultController.GetById(testOrdered.TestResultId);
            if(result == null)
            {
                result = new LabTestResult(this.testOrdered.TestOrderedId, "");
            }
            this.textBox.Text = this.result.TestResults;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.result.TestResults = this.textBox.Text;
            if(this.result.ResultId > 0)
            {
                this.resultController.Update(this.result);
            }
            else
            {
                this.resultController.Add(this.result);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
