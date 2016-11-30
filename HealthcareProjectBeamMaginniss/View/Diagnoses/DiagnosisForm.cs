using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Diagnoses
{
    /// <summary>
    ///     Allows viewing of diagnoses made for a particular patient or appointment
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class DiagnosisForm : Form
    {
        #region Data members

        private readonly DiagnosisController diagnosisController;
        private readonly Appointment appt;
        private BindingSource bindingSource;
        private readonly int userId;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DiagnosisForm" /> class. Use if you want to view diagnoses for a
        ///     specific appointment
        /// </summary>
        /// <param name="appt">The appointment of the diagnoses.</param>
        public DiagnosisForm(Appointment appt)
        {
            this.appt = appt;
            this.userId = 0;
            this.InitializeComponent();
            this.diagnosisController = new DiagnosisController();
            this.populateTable();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DiagnosisForm" /> class. Use if you want to view diagnoses for a
        ///     specific patient
        /// </summary>
        /// <param name="userId">The patient identifier of the diagnoses.</param>
        public DiagnosisForm(int userId)
        {
            this.userId = userId;
            this.appt = null;
            this.InitializeComponent();
            this.diagnosisController = new DiagnosisController();
            this.populateTable();
        }

        #endregion

        private void populateTable()
        {
            this.dgvDiagnosis.AutoGenerateColumns = false;
            this.addDiagnosisColumn("diagnosisInformation", "Diagnosis");
            this.addFinalDiagnosisColumn("finalDiagnosis", "Final?");
            this.updateTable();
            this.resizeToFit();
        }

        private void addDiagnosisColumn(string diagnosisProperty, string columnTitle)
        {
            var column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = diagnosisProperty,
                Name = columnTitle
            };
            this.dgvDiagnosis.Columns.Add(column);
        }

        private void addFinalDiagnosisColumn(string diagnosisProperty, string columnTitle)
        {
            var column = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = diagnosisProperty,
                Name = columnTitle
            };
            this.dgvDiagnosis.Columns.Add(column);
        }

        private void resizeToFit()
        {
            this.dgvDiagnosis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDiagnosis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void updateTable()
        {
            try
            {
                if (this.appt == null)
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.diagnosisController.GetAllDiagnosisByPatientId(this.userId)
                    };
                }
                else
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.diagnosisController.GetAllDiagnosisByAptId(this.appt.AppointmentId)
                    };
                }

                this.dgvDiagnosis.DataSource = this.bindingSource;
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addDiagnosis = new AddEditDiagnosisForm(this.appt.AppointmentId);
            addDiagnosis.ShowDialog();
            this.updateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnosis.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, Resources.DiagnosisForm_btnEdit_Click_Please_select_a_diagnosis_to_edit,
                    Resources.DiagnosisForm_btnEdit_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var diagnosis = (Diagnosis) this.dgvDiagnosis.SelectedRows[0].DataBoundItem;
                    var editDiagnosis = new AddEditDiagnosisForm(diagnosis);
                    editDiagnosis.ShowDialog();
                    this.updateTable();
                }
                catch (Exception exc)
                {
                    this.handleError(exc);
                }
            }
        }

        private void handleError(Exception e)
        {
            MessageBox.Show(null,
                Resources.DiagnosisForm_handleError_Exception_occurred__ + e.Message +
                Resources.DiagnosisForm_handleError_, Resources.DiagnosisForm_handleError_Error, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }
    }
}