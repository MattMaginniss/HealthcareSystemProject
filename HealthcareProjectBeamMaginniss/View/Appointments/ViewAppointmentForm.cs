using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;
using HealthcareProjectBeamMaginniss.View.Diagnoses;
using HealthcareProjectBeamMaginniss.View.Lab_Tests;

namespace HealthcareProjectBeamMaginniss.View.Appointments
{
    public partial class ViewAppointmentForm : Form
    {
        #region Data members

        private readonly AppointmentController appointmentController;
        private BindingSource bindingSource;
        private readonly int patientId;

        #endregion

        #region Constructors

        public ViewAppointmentForm() : this(0)
        {
        }

        public ViewAppointmentForm(int patientId)
        {
            this.patientId = patientId;
            this.InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.populateTable();
        }

        #endregion

        #region Methods

        private void populateTable()
        {
            this.dgvAppointment.AutoGenerateColumns = false;
            this.updateTable();
            this.addAppointmentColumn("ReasonForAppointment", "Reason");
            this.addAppointmentColumn("date", "Date");
            this.addAppointmentColumn("nurseName", "Nurse");
            this.addAppointmentColumn("doctorName", "Doctor");
            this.addAppointmentColumn("patientName", "Patient");
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
            if (this.patientId == 0)
            {
                this.bindingSource = new BindingSource {DataSource = this.appointmentController.GetAll()};
                this.dgvAppointment.DataSource = this.bindingSource;
            }
            else
            {
                this.bindingSource = new BindingSource {
                    DataSource = this.appointmentController.GetAppointmentByPatientId(this.patientId)
                };
                this.dgvAppointment.DataSource = this.bindingSource;
            }
        }

        private void addAppointmentColumn(string patientProperty, string columnTitle)
        {
            var column = new DataGridViewTextBoxColumn {
                DataPropertyName = patientProperty,
                Name = columnTitle
            };
            this.dgvAppointment.Columns.Add(column);
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (this.dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, Resources.ViewAppointmentForm_buttonCheckIn_Click_Please_select_an_appointment,
                    Resources.ViewAppointmentForm_buttonCheckIn_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var appt = (Appointment) this.dgvAppointment.SelectedRows[0].DataBoundItem;
                var addAppointment = new AppointmentCheckinForm(appt);
                addAppointment.ShowDialog();
                this.updateTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.radioBtnName.Checked)
                {
                    var firstNameQuery = this.txtFirstName.Text.ToLower();
                    var lastNameQuery = this.txtLastName.Text.ToLower();

                    if (!firstNameQuery.Equals("") && !lastNameQuery.Equals(""))
                    {
                        this.bindingSource = new BindingSource {
                            DataSource =
                                this.appointmentController.GetAppointmentByPatientFullName(firstNameQuery, lastNameQuery)
                        };
                        this.dgvAppointment.DataSource = this.bindingSource;
                    }
                    else if (!firstNameQuery.Equals(""))
                    {
                        this.bindingSource = new BindingSource {
                            DataSource = this.appointmentController.GetAppointmentByPatientFirstName(firstNameQuery)
                        };
                        this.dgvAppointment.DataSource = this.bindingSource;
                    }
                    else if (!lastNameQuery.Equals(""))
                    {
                        this.bindingSource = new BindingSource {
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
                    var dobQuery = this.dateTimeDateOfBirth.Value.ToShortDateString();

                    this.bindingSource = new BindingSource {
                        DataSource = this.appointmentController.GetAppointmentByPatientDateOfBirth(dobQuery)
                    };
                    this.dgvAppointment.DataSource = this.bindingSource;
                }
                else if (this.radBtnBoth.Checked)
                {
                    var firstNameQuery = this.txtFirstName.Text.ToLower();
                    var lastNameQuery = this.txtLastName.Text.ToLower();
                    var dobQuery = this.dateTimeDateOfBirth.Value.ToShortDateString();

                    if (!firstNameQuery.Equals("") && !lastNameQuery.Equals(""))
                    {
                        this.bindingSource = new BindingSource {
                            DataSource =
                                this.appointmentController.GetAppointmentByPatientFullNameAndDob(firstNameQuery,
                                    lastNameQuery,
                                    dobQuery)
                        };
                        this.dgvAppointment.DataSource = this.bindingSource;
                    }
                    else if (!firstNameQuery.Equals(""))
                    {
                        this.bindingSource = new BindingSource {
                            DataSource =
                                this.appointmentController.GetAppointmentByPatientFirstNameAndDob(firstNameQuery,
                                    dobQuery)
                        };
                        this.dgvAppointment.DataSource = this.bindingSource;
                    }
                    else if (!lastNameQuery.Equals(""))
                    {
                        this.bindingSource = new BindingSource {
                            DataSource =
                                this.appointmentController.GetAppointmentByPatientLastNameAndDob(lastNameQuery, dobQuery)
                        };
                        this.dgvAppointment.DataSource = this.bindingSource;
                    }
                    else
                    {
                        this.updateTable();
                    }
                }
            }
            catch (Exception exc)
            {
                this.handleError(exc);
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
                MessageBox.Show(this,
                    Resources.ViewAppointmentForm_btnOrderTests_Click_Please_select_an_appointment_to_order_tests_for,
                    Resources.ViewAppointmentForm_buttonCheckIn_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var appt = (Appointment) this.dgvAppointment.SelectedRows[0].DataBoundItem;
                var orderLabTestForm = new OrderLabTestForm(appt);
                orderLabTestForm.ShowDialog();
                this.updateTable();
            }
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            if (this.dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show(this,
                    Resources
                        .ViewAppointmentForm_btnDiagnosis_Click_Please_select_an_appointment_to_add_update_diagnosis_to,
                    Resources.ViewAppointmentForm_buttonCheckIn_Click_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var appt = (Appointment) this.dgvAppointment.SelectedRows[0].DataBoundItem;
                var diagnosisForm = new DiagnosisForm(appt);
                diagnosisForm.ShowDialog();
                this.updateTable();
            }
        }

        private void btnViewTests_Click(object sender, EventArgs e)
        {
            if (this.dgvAppointment.SelectedRows.Count == 0)
            {
                MessageBox.Show(this,
                    Resources.ViewAppointmentForm_btnViewTests_Click_Please_select_an_appointment_to_view_lab_tests_for,
                    Resources.ViewAppointmentForm_buttonCheckIn_Click_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var appt = (Appointment) this.dgvAppointment.SelectedRows[0].DataBoundItem;
                var diagnosisForm = new ViewLabTestForm(appt);
                diagnosisForm.ShowDialog();
                this.updateTable();
            }
        }

        private void handleError(Exception e)
        {
            MessageBox.Show(null,
                Resources.ViewAppointmentForm_handleError_Exception_occurred__ + e.Message +
                Resources.ViewAppointmentForm_handleError_, Resources.ViewAppointmentForm_handleError_Error,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }

        #endregion
    }
}