using System.Collections.Generic;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class LabTestOrderedRepository : IRepository<LabTestOrdered>
    {
        #region Methods

        public void Add(LabTestOrdered labTestOrdered)
        {
            var adapter = new test_orderedTableAdapter();
            var testId = labTestOrdered.TestId;
            var doctorId = labTestOrdered.DoctorId;
            var testDate = labTestOrdered.TestDate;

            using (adapter)
            {
                adapter.Insert(testId, doctorId, testDate);
            }
        }

        public LabTestOrdered GetById(int id)
        {
            var adapter = new test_orderedTableAdapter();

            using (adapter)
            {
                var labTestOrdered = adapter.GetData().FirstOrDefault(lto => lto.test_ordered_id == id);
                return this.GetTestOrderedFromRow(labTestOrdered);
            }
        }

        public IList<LabTestOrdered> GetAll()
        {
            var testOrderedList = new List<LabTestOrdered>();
            var adapter = new test_orderedTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var test = this.GetTestOrderedFromRow((cs3230f16bDataSet.test_orderedRow) row);
                    testOrderedList.Add(test);
                }
            }
            return testOrderedList;
        }

        public IList<LabTestOrdered> GetByAppointmentId(int appointmentId)
        {
            var testList = new List<LabTestOrdered>();
            var adapter = new appointment_has_lab_orderTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Where(tst => tst.appointment_id == appointmentId))
                {
                    var test = this.GetById(row.lab_order_id);
                    testList.Add(test);
                }
            }
            return testList;
        }

        public LabTestOrdered GetTestOrderedFromRow(cs3230f16bDataSet.test_orderedRow row)
        {
            var testOrderedId = row.test_ordered_id;
            var testId = row.test_id;
            var doctorId = row.doctor_id;
            var testDate = row.test_date;
            return new LabTestOrdered(testOrderedId, testId, doctorId, testDate);
        }

        public int GetLastId()
        {
            var adapter = new test_orderedTableAdapter();
            using (adapter)
            {
                var labTestOrdered = adapter.GetData().LastOrDefault();
                if (labTestOrdered != null)
                {
                    return labTestOrdered.test_ordered_id;
                }
                return -1;
            }
        }

        #endregion
    }
}