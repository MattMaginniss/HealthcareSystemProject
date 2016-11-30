using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    public partial class ViewLabTestForm : Form
    {
        #region Data members

        private readonly Appointment appt;
        private readonly LabTestOrderedController labTestOrderedController;
        private readonly LabTestResultController labTestResultController;
        private readonly int patientId;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ViewLabTestForm" /> class. Use to view tests for a single appointment
        /// </summary>
        /// <param name="appt">The appointment.</param>
        public ViewLabTestForm(Appointment appt)
        {
            this.InitializeComponent();
            this.appt = appt;
            this.patientId = 0;
            this.labTestOrderedController = new LabTestOrderedController();
            this.labTestResultController = new LabTestResultController();
            this.populateDataView();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ViewLabTestForm" /> class. Use to view tests for a single patient
        /// </summary>
        /// <param name="patientId">The patient identifier.</param>
        public ViewLabTestForm(int patientId)
        {
            this.InitializeComponent();
            this.appt = null;
            this.patientId = patientId;
            this.labTestOrderedController = new LabTestOrderedController();
            this.labTestResultController = new LabTestResultController();
            this.populateDataView();
        }

        #endregion

        private void populateDataView()
        {
            this.dataGridView.AutoGenerateColumns = false;
            this.refreshTable();
            this.addTestColumn("TestName", "Test ID");
            this.addTestColumn("DoctorName", "Doctor");
            this.addTestColumn("TestDate", "Date");
            var column = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "HasResult",
                Name = "Has Result?"
            };
            this.dataGridView.Columns.Add(column);
        }

        private void refreshTable()
        {
            try
            {
                IList<LabTestOrder> data;
                if (this.appt == null)
                {
                    data = this.labTestOrderedController.GetByPatientId(this.patientId);
                }
                else
                {
                    data = this.labTestOrderedController.GetByAppointmentId(this.appt.AppointmentId);
                }
                this.attachResults(data);
                var bindingSource = new BindingSource {DataSource = data};
                this.dataGridView.DataSource = bindingSource;
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
        }

        private void attachResults(IList<LabTestOrder> data)
        {
            foreach (var test in data)
            {
                try
                {
                    var result =
                        this.labTestResultController.GetAll()
                            .FirstOrDefault(res => res.TestOrderId == test.TestOrderedId);
                    if (result != null)
                    {
                        test.TestResultId = result.ResultId;
                    }
                }
                catch (Exception exc)
                {
                    this.handleError(exc);
                }
            }
        }

        private void addTestColumn(string testProperty, string columnTitle)
        {
            var column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = testProperty,
                Name = columnTitle
            };
            this.dataGridView.Columns.Add(column);
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this,
                    Resources.ViewLabTestForm_btnViewResult_Click_Please_select_a_test_to_view_the_results_of,
                    Resources.ViewLabTestForm_btnViewResult_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var test = (LabTestOrder) this.dataGridView.SelectedRows[0].DataBoundItem;
                if (test.HasResult)
                {
                    try
                    {
                        var testName = new LabTestController().GetById(test.TestId).TestName;
                        var testResults = this.labTestResultController.GetById(test.TestResultId).TestResults;
                        MessageBox.Show(Resources.ViewLabTestForm_btnViewResult_Click_Test__ + testName +
                                        Resources.ViewLabTestForm_btnViewResult_Click_ + testResults);
                    }
                    catch (Exception exc)
                    {
                        this.handleError(exc);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.ViewLabTestForm_btnViewResult_Click_No_result_);
                }
            }
        }

        private void btnOrderTest_Click(object sender, EventArgs e)
        {
            var orderLabTestForm = new OrderLabTestForm(this.appt);
            orderLabTestForm.ShowDialog();
            this.refreshTable();
        }

        private void btnAddUpdateResult_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(this,
                    Resources.ViewLabTestForm_btnAddUpdateResult_Click_Please_select_a_test_to_edit_add_the_results_of,
                    Resources.ViewLabTestForm_btnViewResult_Click_Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var test = (LabTestOrder) this.dataGridView.SelectedRows[0].DataBoundItem;
            var labResultForm = new LabResultForm(test);
            labResultForm.ShowDialog();
            this.refreshTable();
        }

        private void handleError(Exception exc)
        {
            MessageBox.Show(null, Resources.ViewLabTestForm_handleError_ + exc.Message, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Close();
        }
    }
}