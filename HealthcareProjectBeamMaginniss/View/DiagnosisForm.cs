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
        public Appointment appt;
        
        public DiagnosisForm(Appointment appt)
        {
            this.appt = appt;
            InitializeComponent();
            this.populateTable();
            this.diagnosisController = new DiagnosisController();
        }
        private void populateTable()
        {
            this.dgvDiagnosis.AutoGenerateColumns = false;
            this.addDiagnosisColumn("diagnosisID", "id");
            this.addDiagnosisColumn("diagnosisInformation", "Diagnosis");
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
            this.dgvDiagnosis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvDiagnosis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void updateTable()
        {
            try
            {
                this.bindingSource = new BindingSource
                {
                    DataSource = this.diagnosisController.GetAllDiagnosisByAptID(this.appt.AppointmentID)
                };

            }
            catch (NullReferenceException nre)
            {
                this.dgvDiagnosis.Rows.Add(0, "There are no diagnosis for this appointment. Click 'add' below to add one.");
            }
            this.dgvDiagnosis.DataSource = this.bindingSource;
        }
    }
}
