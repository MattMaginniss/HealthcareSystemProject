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
    public partial class EditPatientForm : Form
    {
        private PatientController pc;
        private int patientID;
        public EditPatientForm(Patient patient)
        {
            InitializeComponent();
            this.loadCountries();
            this.patientID = patient.PatientId;
            this.txtFirstName.Text = patient.FirstName;
            this.txtLastName.Text = patient.LastName;
            this.dateTimeDOB.Value = patient.Dob;
            if (patient.Sex.Equals('M'))
            {
                this.radioBtnMale.Checked = true;
            }
            else
            {
                this.radioBtnFemale.Checked = true;
            }
            this.txtAddr1.Text = patient.Street1;
            this.txtAddr2.Text = patient.Street2;
            this.txtCity.Text = patient.City;
            this.txtState.Text = patient.State;
            this.txtZip.Text = patient.Zip;
            this.txtPhone.Text = patient.PhoneNo;
        }
        private void loadCountries()
        {
            var country = new Country();
            foreach (var ctry in country.CountryDict.Keys)
            {
                this.comboBoxCountry.Items.Add(ctry);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var fname = this.txtFirstName.Text;
            var lname = this.txtLastName.Text;
            var dob = this.dateTimeDOB.Value;
            var sex = this.radioBtnMale.Checked ? 'M' : 'F';
            var street1 = this.txtAddr1.Text;
            var street2 = this.txtAddr2.Text;
            var city = this.txtCity.Text;
            var state = this.txtState.Text;
            var country = this.comboBoxCountry.Text;
            var zip = this.txtZip.Text;
            var phone = this.txtPhone.Text;
            var ctry = new Country();
            if (string.IsNullOrWhiteSpace(fname))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(street1))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(state))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(country) || !ctry.Contains(country))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(zip))
            {
                return;
            }
            var ccode = ctry.Get(country);
            this.pc = new PatientController();
            this.pc.Update(new Patient(this.patientID, fname, lname, dob, sex, street1, street2, city, state, zip, ccode, phone));
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
