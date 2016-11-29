using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Diagnoses
{
    public partial class DiagnosisForm : Form
    {
        #region Data members

        private readonly DiagnosisController diagnosisController;
        private readonly Appointment appt;
        private BindingSource bindingSource;

        #endregion

        #region Constructors

        public DiagnosisForm(Appointment appt)
        {
            this.appt = appt;
            this.InitializeComponent();
            this.diagnosisController = new DiagnosisController();
            this.populateTable();
        }

        #endregion

        #region Methods

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
            var column = new DataGridViewTextBoxColumn {
                DataPropertyName = diagnosisProperty,
                Name = columnTitle
            };
            this.dgvDiagnosis.Columns.Add(column);
        }

        private void addFinalDiagnosisColumn(string diagnosisProperty, string columnTitle)
        {
            var column = new DataGridViewCheckBoxColumn {
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
            this.bindingSource = new BindingSource {
                DataSource = this.diagnosisController.GetAllDiagnosisByAptId(this.appt.AppointmentId)
            };
            this.dgvDiagnosis.DataSource = this.bindingSource;
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
                MessageBox.Show(this, Resources.DiagnosisForm_btnEdit_Click_Please_select_a_diagnosis_to_edit, Resources.DiagnosisForm_btnEdit_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var diagnosis = (Diagnosis) this.dgvDiagnosis.SelectedRows[0].DataBoundItem;
                var editDiagnosis = new AddEditDiagnosisForm(diagnosis);
                editDiagnosis.ShowDialog();
                this.updateTable();
            }
        }

        #endregion
    }
}