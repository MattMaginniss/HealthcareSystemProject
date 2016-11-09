using System;
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
            this.labelWelcome.Text += name + "!";
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
            var addPatient = new AddUserForm(this.patientController);
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
            var patient = ((Patient)this.patientDataGridView.SelectedRows[0].DataBoundItem).PatientId;
            var addAppointment = new AddAppointmentForm(patient);
            addAppointment.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchPatient = new SearchPatientForm();
            searchPatient.ShowDialog();
            if (searchPatient.DialogResult == DialogResult.OK)
            {
                this.bindingSource = new BindingSource { DataSource = searchPatient.Search()};
                
            }
            this.updateTable();
        }

        private void buttonViewAppointments_Click(object sender, EventArgs e)
        {
            var viewAppointments = new ViewAppointmentForm();
            viewAppointments.ShowDialog();
        }
    }
}