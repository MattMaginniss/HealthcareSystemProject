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
    public partial class AddUserForm : Form
    {
        private PatientController pr;

        public AddUserForm()
        {
            this.InitializeComponent();
        }

        public AddUserForm(PatientController patientController)
        {
            this.InitializeComponent();
            this.pr = patientController;
        }

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
            this.Dispose();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.addUser();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
