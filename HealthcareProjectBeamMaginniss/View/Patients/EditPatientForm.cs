using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Patients
{
    public partial class EditPatientForm : Form
    {
        #region Data members

        private readonly int patientId;
        private PatientController pc;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EditPatientForm" /> class.
        /// </summary>
        /// <param name="patient">The patient to update.</param>
        public EditPatientForm(Patient patient)
        {
            this.InitializeComponent();
            this.dateTimeDOB.MaxDate = DateTime.Today;
            this.loadCountries();
            this.patientId = patient.PatientId;
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

        #endregion

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
            this.editPatient();
        }

        private void editPatient()
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
                MessageBox.Show(this, Resources.EditPatientForm_btnSubmit_Click_Please_select_a_country,
                    Resources.EditPatientForm_btnSubmit_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(zip))
            {
                return;
            }
            var ccode = ctry.Get(country);
            try
            {
                this.pc = new PatientController();
                this.pc.Update(new Patient(this.patientId, fname, lname, dob, sex, street1, street2, city, state, zip,
                    ccode,
                    phone));
                Dispose();
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void handleError(Exception exc)
        {
            MessageBox.Show(null, Resources.EditPatientForm_handleError_ + exc.Message, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }
    }
}