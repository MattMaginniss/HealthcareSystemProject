using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;
using HealthcareProjectBeamMaginniss.View.Appointments;
using HealthcareProjectBeamMaginniss.View.Diagnoses;
using HealthcareProjectBeamMaginniss.View.Lab_Tests;
using HealthcareProjectBeamMaginniss.View.Patients;

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
        /// <param name="loginForm">The LoginForm</param>
        public MainForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.InitializeComponent();
            this.patientController = new PatientController();
            this.populateTable();
            this.displayName(loginForm.GetUsername());
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
            this.bindingSource = new BindingSource {DataSource = this.patientController.GetFirst30()};
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
            Close();
            this.loginForm.Logout();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, Resources.MainForm_buttonAddAppointment_Click_Please_select_a_user,
                    Resources.MainForm_buttonAddAppointment_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var patient = ((Patient) this.patientDataGridView.SelectedRows[0].DataBoundItem).PatientId;
                var addAppointment = new AddAppointmentForm(patient);
                addAppointment.ShowDialog();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.radioBtnName.Checked)
            {
                var firstNameQuery = this.txtFirstName.Text.ToLower();
                var lastNameQuery = this.txtLastName.Text.ToLower();

                if (!firstNameQuery.Equals("") && !lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.patientController.GetPatientsByFullName(firstNameQuery, lastNameQuery)
                    };
                    this.patientDataGridView.DataSource = this.bindingSource;
                }
                else if (!firstNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.patientController.GetPatientsByFirstName(firstNameQuery)
                    };
                    this.patientDataGridView.DataSource = this.bindingSource;
                }
                else if (!lastNameQuery.Equals(""))
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
            }
            else if (this.radBtnDOB.Checked)
            {
                var dobQuery = this.dateTimeDateOfBirth.Value.ToShortDateString();

                this.bindingSource = new BindingSource
                {
                    DataSource = this.patientController.GetPatientsByDateOfBirth(dobQuery)
                };
                this.patientDataGridView.DataSource = this.bindingSource;
            }
            else if (this.radioButtonCountries.Checked)
            {
                try
                {
                    var countryQuery = new Country().CountryDict[this.comboBoxCountries.Text];
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.patientController.GetPatientsByCountry(countryQuery)
                    };
                    this.patientDataGridView.DataSource = this.bindingSource;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void buttonViewAppointments_Click(object sender, EventArgs e)
        {
            var viewAppointments = new ViewAppointmentForm();
            viewAppointments.ShowDialog();
        }

        private void radioBtnName_CheckedChanged_1(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = this.radioBtnName.Checked;
            this.txtLastName.Enabled = this.radioBtnName.Checked;
        }

        private void radBtnDOB_CheckedChanged_1(object sender, EventArgs e)
        {
            this.dateTimeDateOfBirth.Enabled = this.radBtnDOB.Checked;
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
                MessageBox.Show(this, Resources.MainForm_btnEditPatient_Click_Please_select_a_user_to_edit,
                    Resources.MainForm_buttonAddAppointment_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var patient = (Patient) this.patientDataGridView.SelectedRows[0].DataBoundItem;
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

        private void displayName(string username)
        {
            var login = new LoginController();
            var name = login.GetName(username) ?? "Unknown User";
            this.lblWelcome.Text += name + Resources.MainForm_displayName__;
        }

        private void btnViewPatientApts_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, Resources.MainForm_buttonAddAppointment_Click_Please_select_a_user,
                    Resources.MainForm_buttonAddAppointment_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var patientId = ((Patient) this.patientDataGridView.SelectedRows[0].DataBoundItem).PatientId;
                var patientApts = new ViewAppointmentForm(patientId);
                patientApts.ShowDialog();
            }
        }

        private void btnViewPatientDiagnoses_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, Resources.MainForm_buttonAddAppointment_Click_Please_select_a_user,
                    Resources.MainForm_buttonAddAppointment_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var patientId = ((Patient) this.patientDataGridView.SelectedRows[0].DataBoundItem).PatientId;
                var patientDiagnosis = new DiagnosisForm(patientId);
                patientDiagnosis.ShowDialog();
            }
        }

        private void btnViewPatientTests_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, Resources.MainForm_buttonAddAppointment_Click_Please_select_a_user,
                    Resources.MainForm_buttonAddAppointment_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var patientId = ((Patient) this.patientDataGridView.SelectedRows[0].DataBoundItem).PatientId;
                var patientTests = new ViewLabTestForm(patientId);
                patientTests.ShowDialog();
            }
        }

        private void radioButtonCountries_CheckedChanged(object sender, EventArgs e)
        {
            if (this.comboBoxCountries.Items.Count == 0)
            {
                this.loadCountries();
            }
            this.comboBoxCountries.Enabled = this.radioButtonCountries.Checked;
        }

        private void loadCountries()
        {
            var country = new Country();
            foreach (var ctry in country.CountryDict.Keys)
            {
                this.comboBoxCountries.Items.Add(ctry);
            }
        }
    }
}