using System;
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
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddUserForm" /> class.
        /// </summary>
        /// <param name="patientController">The patient controller to use.</param>
        public AddUserForm(PatientController patientController)
        {
            this.InitializeComponent();
            this.pr = patientController;
        }

        #endregion

        private void addUser()
        {
            var fname = this.fNameTextBox.Text;
            var lname = this.lNameTextBox.Text;
            var dob = this.dateTimePicker.Value;
            var address = this.addressTextBox.Text;
            var phone = this.phoneNumBox.Text;

            if (string.IsNullOrWhiteSpace(fname))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                return;
            }
            var p = new Patient(fname, lname, dob, address, phone);
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
    }
}