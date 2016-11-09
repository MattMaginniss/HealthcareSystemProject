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
    public partial class SearchPatientForm : Form
    {
        private readonly PatientController pr;

        public SearchPatientForm()
        {
            InitializeComponent();
        }
        public SearchPatientForm(PatientController patientController)
        {
            this.pr = patientController;
            InitializeComponent();
        }

        private void radioBtnName_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.dateTimeDateOfBirth.Enabled = false;
        }

        private void radBtnDOB_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.dateTimeDateOfBirth.Enabled = true;
        }

        public IList<Patient> Search()
        {
            IList<Patient> patients;
            if (this.radioBtnName.Checked)
            {
                patients = this.pr.GetPatientsByName(this.txtFirstName.Text, this.txtLastName.Text);
            }
            else
            {
                patients = this.pr.GetPatientsByDateOfBirth(this.dateTimeDateOfBirth.Value);
            }
            return patients;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
