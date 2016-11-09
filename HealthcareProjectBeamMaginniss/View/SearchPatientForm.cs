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
    }
}
