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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.radioBtnName.Checked)
            {
                string firstNameQuery = txtFirstName.Text.ToLower();
                string lastNameQuery = txtLastName.Text.ToLower();

                if (!firstNameQuery.Equals("") && !lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAppointmentByPatientFullName(firstNameQuery, lastNameQuery) };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else if (!firstNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAppointmentByPatientFirstName(firstNameQuery) };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else if (!lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.appointmentController.GetAppointmentByPatientLastName(lastNameQuery)
                    };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else
                {
                    this.updateTable();
                }
            }
            else if (this.radBtnDOB.Checked)
            {
                String dobQuery = dateTimeDateOfBirth.Value.ToShortDateString();

                this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAppointmentByPatientDateOfBirth(dobQuery) };
                this.dgvAppointment.DataSource = this.bindingSource;
            }

            else if (this.radBtnBoth.Checked)
            {
                string firstNameQuery = txtFirstName.Text.ToLower();
                string lastNameQuery = txtLastName.Text.ToLower();
                String dobQuery = dateTimeDateOfBirth.Value.ToShortDateString();

                if (!firstNameQuery.Equals("") && !lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAppointmentByPatientFullNameAndDob(firstNameQuery, lastNameQuery, dobQuery) };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else if (!firstNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource { DataSource = this.appointmentController.GetAppointmentByPatientFirstNameAndDob(firstNameQuery, dobQuery) };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else if (!lastNameQuery.Equals(""))
                {
                    this.bindingSource = new BindingSource
                    {
                        DataSource = this.appointmentController.GetAppointmentByPatientLastNameAndDob(lastNameQuery, dobQuery)
                    };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else
                {
                    this.updateTable();
                }
            }
        }
        private void radioBtnName_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.dateTimeDateOfBirth.Enabled = false;
        }

        private void radBtnDOB_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.dateTimeDateOfBirth.Enabled = true;
        }

        private void radBtnBoth_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
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

        private void btnOrderTests_Click(object sender, EventArgs e)
        {
            if (this.dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select an appointment to order tests for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
