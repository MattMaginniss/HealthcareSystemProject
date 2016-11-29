using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.Model;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class ViewLabTestForm : Form
    {
        private Appointment appt;
        private LabTestOrderedController labTestOrderedController;
        private LabTestResultController labTestResultController;

        public ViewLabTestForm(Appointment appt)
        {
            InitializeComponent();
            this.appt = appt;
            this.labTestOrderedController = new LabTestOrderedController();
            this.labTestResultController = new LabTestResultController();
            this.populateDataView();
        }

        private void populateDataView()
        {
            this.dataGridView.AutoGenerateColumns = false;
            refreshTable();
            this.addTestColumn("TestId", "Test ID");
            this.addTestColumn("DoctorId", "Doctor");
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
            var data = this.labTestOrderedController.GetByAppointmentId(this.appt.AppointmentID);
            this.attachResults(data);
            var bindingSource = new BindingSource { DataSource = data };
            this.dataGridView.DataSource = bindingSource;
        }

        private void attachResults(IList<LabTestOrdered> data)
        {
            foreach(var test in data)
            {
                var result = this.labTestResultController.GetAll().FirstOrDefault(res=>res.TestOrderId == test.TestOrderedId);
                if(result != null)
                {
                    test.TestResultId = result.ResultId;
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
                MessageBox.Show(this, "Please select a test to view the results of", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var test = (LabTestOrdered)this.dataGridView.SelectedRows[0].DataBoundItem;
                if (test.HasResult)
                {
                    var testName = new LabTestController().GetById(test.TestId).TestName;
                    var testResults = this.labTestResultController.GetById(test.TestResultId).TestResults;
                    MessageBox.Show("Test: " + testName + "\nResults: " + testResults);
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
                MessageBox.Show(this, "Please select a test to edit/add the results of", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var test = (LabTestOrdered)this.dataGridView.SelectedRows[0].DataBoundItem;
            
        }
    }
}
