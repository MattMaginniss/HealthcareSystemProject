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
    public partial class CreateLabTestForm : Form
    {
        private LabTestController ltController;

        public CreateLabTestForm()
        {
            InitializeComponent();
            this.ltController = new LabTestController();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var labTestName = this.txtLabTestName.Text;
            if (string.IsNullOrWhiteSpace(labTestName))
            {
                return;
            }
            this.ltController.Add(new LabTest(labTestName));
            this.Close();
        }
    }
}
