using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View.Patients
{
    /// <summary>
    ///     Form for adding a patient to the database
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddPatientForm : Form
    {
        #region Data members

        private readonly PatientController pr;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddPatientForm" /> class.
        /// </summary>
        public AddPatientForm()
        {
            this.InitializeComponent();
            this.dateTimeDOB.MaxDate = DateTime.Today;
            this.loadCountries();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddPatientForm" /> class.
        /// </summary>
        /// <param name="patientController">The patient controller to use.</param>
        public AddPatientForm(PatientController patientController)
        {
            this.InitializeComponent();
            this.dateTimeDOB.MaxDate = DateTime.Today;
            this.pr = patientController;
            this.loadCountries();
        }

        #endregion

        #region Methods

        private void addPatient()
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
            var p = new Patient(0, fname, lname, dob, sex, street1, street2, city, state, zip, ccode, phone);
            this.pr.Add(p);
            Dispose();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.addPatient();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void phoneNumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loadCountries()
        {
            var country = new Country();
            foreach (var ctry in country.CountryDict.Keys)
            {
                this.comboBoxCountry.Items.Add(ctry);
            }
        }

        #endregion
    }
}