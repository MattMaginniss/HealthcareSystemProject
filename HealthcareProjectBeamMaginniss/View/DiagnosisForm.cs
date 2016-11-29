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
    public partial class DiagnosisForm : Form
    {
        private BindingSource bindingSource;
        private readonly DiagnosisController diagnosisController;
        private Appointment appt;
        
        public DiagnosisForm(Appointment appt)
        {
            this.appt = appt;
            InitializeComponent();
            this.diagnosisController = new DiagnosisController();
            this.populateTable();
        }
        private void populateTable()
        {
            this.dgvDiagnosis.AutoGenerateColumns = false;
            this.addDiagnosisColumn("diagnosisInformation", "Diagnosis");
            this.addDiagnosisColumn("finalDiagnosis", "Final?");
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

        private void resizeToFit()
        {
            this.dgvDiagnosis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDiagnosis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void updateTable()
        {
            this.bindingSource = new BindingSource
            {
                DataSource = this.diagnosisController.GetAllDiagnosisByAptID(this.appt.AppointmentID)
            };
            this.dgvDiagnosis.DataSource = this.bindingSource;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addDiagnosis = new AddEditDiagnosisForm("Add Diagnosis", this.appt.AppointmentID);
            addDiagnosis.ShowDialog();
            this.updateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnosis.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select a diagnosis to edit", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var diagnosis = (Diagnosis)this.dgvDiagnosis.SelectedRows[0].DataBoundItem;
                var editDiagnosis = new AddEditDiagnosisForm("Edit Diagnosis", diagnosis);
                editDiagnosis.ShowDialog();
                this.updateTable();

            }
        }
    }
}
