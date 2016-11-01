using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;

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

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.patientController = new PatientController();
            this.populateTable();
        }

        #endregion

        private void populateTable()
        {
            this.updateTable();
            this.addPatientColumn("FirstName", "First Name");
            this.addPatientColumn("LastName", "Last Name");
            this.addPatientColumn("DobString", "Date of Birth");
            this.addPatientColumn("Address", "Address");
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
            this.patientDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.patientDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            var addPatient = new AddUserForm(this.patientController);
            addPatient.ShowDialog();
            this.updateTable();
        }
    }
}