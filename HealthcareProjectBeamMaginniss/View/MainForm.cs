using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View
{
    /// <summary>
    ///     Main form with datagridview of all patients
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {

        #region Data members

        private BindingSource bindingSource;
        private readonly PatientController patientController;
        private readonly LoginForm loginForm;
        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        /// <param name="text"></param>
        public MainForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.InitializeComponent();
            this.patientController = new PatientController();
            this.populateTable();
            this.displayName(loginForm.GetUsername());
        }

        private void displayName(string username)
        {
            LoginController login = new LoginController();
            var name = login.GetName(username) ?? "Unknown User";
            this.lblWelcome.Text += name + "!";
        }

        #endregion

        private void populateTable()
        {
            this.patientDataGridView.AutoGenerateColumns = false;
            this.updateTable();
            this.addPatientColumn("FirstName", "First Name");
            this.addPatientColumn("LastName", "Last Name");
            this.addPatientColumn("DobString", "Date of Birth");
            this.addPatientColumn("Sex", "Sex");
            this.addPatientColumn("Street1", "Street 1");
            this.addPatientColumn("Street2", "Street 2");
            this.addPatientColumn("City", "City");
            this.addPatientColumn("State", "State");
            this.addPatientColumn("Zip", "ZIP");
            this.addPatientColumn("Country", "Country");
            this.addPatientColumn("PhoneNo", "Phone #");
            this.resizeToFit();
        }

        private void updateTable()
        {
            this.bindingSource = new BindingSource {DataSource = this.patientController.GetAll()};
            this.patientDataGridView.DataSource = this.bindingSource;
           
        }

        private void addPatientColumn(string patientProperty, string columnTitle)
        {
            var column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = patientProperty,
                Name = columnTitle
            };
            this.patientDataGridView.Columns.Add(column);
        }

        private void resizeToFit()
        {
            this.patientDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.patientDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.patientDataGridView.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Logout();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            var addPatient = new AddPatientForm(this.patientController);
            addPatient.ShowDialog();
            this.updateTable();
        }

        private void labelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.loginForm.Logout();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if(this.patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select a user","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var patient = ((Patient)this.patientDataGridView.SelectedRows[0].DataBoundItem).PatientId;
                var addAppointment = new AddAppointmentForm(patient);
                addAppointment.ShowDialog();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.radioBtnName.Checked)
            {
                string firstNameQuery = txtFirstName.Text.ToLower();
                string lastNameQuery = txtLastName.Text.ToLower();

                if (!firstNameQuery.Equals("") && !lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource { DataSource = this.patientController.GetPatientsByFullName(firstNameQuery, lastNameQuery) };
                    this.patientDataGridView.DataSource = this.bindingSource;
                } else if (!firstNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource { DataSource = this.patientController.GetPatientsByFirstName(firstNameQuery) };
                    this.patientDataGridView.DataSource = this.bindingSource;
                } else if (!lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.patientController.GetPatientsByLastName(lastNameQuery)
                    };
                    this.patientDataGridView.DataSource = this.bindingSource;
                }
                else
                {
                   this.updateTable(); 
                }
            } else if (this.radBtnDOB.Checked)
            {
                String dobQuery = dateTimeDateOfBirth.Value.ToShortDateString();

                this.bindingSource = new BindingSource { DataSource = this.patientController.GetPatientsByDateOfBirth(dobQuery) };
                this.patientDataGridView.DataSource = this.bindingSource;
            }
        }

        private void buttonViewAppointments_Click(object sender, EventArgs e)
        {
            var viewAppointments = new ViewAppointmentForm();
            viewAppointments.ShowDialog();
        }
        private void radioBtnName_CheckedChanged_1(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.dateTimeDateOfBirth.Enabled = false;
        }

        private void radBtnDOB_CheckedChanged_1(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.dateTimeDateOfBirth.Enabled = true;
        }

        private void btnDGVReset_Click(object sender, EventArgs e)
        {
            this.radioBtnName.Checked = true;
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.dateTimeDateOfBirth.Value = DateTime.Today;
            this.updateTable();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select a user to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var patient = ((Patient)this.patientDataGridView.SelectedRows[0].DataBoundItem);
                var editPatient = new EditPatientForm(patient);
                editPatient.ShowDialog();
                this.updateTable();
            }
        }

        private void btnDoBReport_Click(object sender, EventArgs e)
        {
            var histogramForm = new HistogramForm();
            histogramForm.Show();
        }
    }
}