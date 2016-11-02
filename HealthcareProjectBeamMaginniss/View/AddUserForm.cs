using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View
{
    /// <summary>
    ///     Form for adding a patient to the database
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddUserForm : Form
    {
        #region Data members

        private readonly PatientController pr;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddUserForm" /> class.
        /// </summary>
        public AddUserForm()
        {
            this.InitializeComponent();
            this.loadCountries();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddUserForm" /> class.
        /// </summary>
        /// <param name="patientController">The patient controller to use.</param>
        public AddUserForm(PatientController patientController)
        {
            this.InitializeComponent();
            this.pr = patientController;
            this.loadCountries();

        }

        #endregion

        private void addUser()
        {
            var fname = this.fNameTextBox.Text;
            var lname = this.lNameTextBox.Text;
            var dob = this.dateTimePicker.Value;
            var sex = this.radioMale.Checked ? 'M' : 'F';
            var street1 = this.textBoxStreet1.Text;
            var street2 = this.textBoxStreet2.Text;
            var city = this.textBoxCity.Text;
            var state = this.textBoxState.Text;
            var country = this.comboBoxCountry.Text;
            var zip = this.textBoxZip.Text; 
            var phone = this.phoneNumBox.Text;
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
            var p = new Patient(fname, lname, dob, sex, street1, street2,city,state,zip,ccode, phone);
            this.pr.Add(p);
            Dispose();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.addUser();
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
            foreach(var ctry in country.CountryDict.Keys)
            {
                this.comboBoxCountry.Items.Add(ctry);
            }
        }
    }
}