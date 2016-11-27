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
            this.dgvAppointment.AutoGenerateColumns = false;
            this.updateTable();
            this.addAppointmentColumn("ReasonForAppointment", "Reason");
            this.addAppointmentColumn("date", "Date");
            this.addAppointmentColumn("nureseID", "Nurse");
            this.addAppointmentColumn("doctorID", "Doctor");
            this.addAppointmentColumn("patientID", "Patient");
            this.addAppointmentColumn("systolicBP", "systolicBP");
            this.addAppointmentColumn("diastolicBP", "diastolicBP");
            this.addAppointmentColumn("temperature", "temperature");
            this.addAppointmentColumn("pulse", "pulse");
            this.addAppointmentColumn("weight", "weight");
            this.addAppointmentColumn("symptoms", "symptoms");
            this.resizeToFit();
        }

        private void resizeToFit()
        {
            this.dgvAppointment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvAppointment.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void updateTable()
        {
            this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAll() };
            this.dgvAppointment.DataSource = this.bindingSource;
        }

        private void addAppointmentColumn(string patientProperty, string columnTitle)
        {
            var column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = patientProperty,
                Name = columnTitle
            };
            this.dgvAppointment.Columns.Add(column);
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (this.dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select an appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var appt = (Appointment)this.dgvAppointment.SelectedRows[0].DataBoundItem;
                var addAppointment = new AppointmentCheckinForm(appt);
                addAppointment.ShowDialog();
                this.updateTable();
            }
        }
    }
}
