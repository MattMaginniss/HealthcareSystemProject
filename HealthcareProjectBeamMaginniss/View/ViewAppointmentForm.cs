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

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class ViewAppointmentForm : Form
    {
        private BindingSource bindingSource;
        private readonly AppointmentController appointmentController;

        public ViewAppointmentForm()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.populateTable();

        }

        private void populateTable()
        {
            this.dataGridViewAppointment.AutoGenerateColumns = false;
            this.updateTable();
            this.addPatientColumn("ReasonForAppointment", "Reason");
            this.addPatientColumn("date", "Date");
            this.addPatientColumn("nureseID", "Nurse");
            this.addPatientColumn("doctorID", "Doctor");
            this.addPatientColumn("patientID", "Patient");
            this.addPatientColumn("systolicBP", "systolicBP");
            this.addPatientColumn("diastolicBP", "diastolicBP");
            this.addPatientColumn("temperature", "temperature");
            this.addPatientColumn("pulse", "pulse");
            this.addPatientColumn("weight", "weight");
            this.addPatientColumn("symptoms", "symptoms");
            this.resizeToFit();
        }

        private void resizeToFit()
        {
            this.dataGridViewAppointment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAppointment.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewAppointment.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void updateTable()
        {
            this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAll() };
            this.dataGridViewAppointment.DataSource = this.bindingSource;
        }

        private void addPatientColumn(string patientProperty, string columnTitle)
        {
            var column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = patientProperty,
                Name = columnTitle
            };
            this.dataGridViewAppointment.Columns.Add(column);
        }
    }
}
