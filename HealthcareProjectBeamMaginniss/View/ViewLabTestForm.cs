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
            var data = this.labTestOrderedController.GetByAppointmentId(this.appt.AppointmentID);
            data = this.attachResults(data);
            var bindingSource = new BindingSource { DataSource = data };
            this.dataGridView.DataSource = bindingSource;
            this.addTestColumn("TestId", "Test ID");
            this.addTestColumn("DoctorId", "Doctor");
            this.addTestColumn("TestDate", "Date");
        }

        private IList<LabTestOrdered> attachResults(IList<LabTestOrdered> data)
        {
            foreach(var test in data)
            {
                var result = this.labTestResultController.GetById(test.TestOrderedId);
                if(result != null)
                {
                  //  test.TestResultId = result.
                }
            }
            return null;
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
    }
}
