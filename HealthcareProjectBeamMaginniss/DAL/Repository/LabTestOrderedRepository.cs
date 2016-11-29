using System;
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
            try
            {
                using (adapter)
                {
                    adapter.Insert(testId, doctorId, testDate);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public LabTestOrdered GetById(int id)
        {
            var adapter = new test_orderedTableAdapter();
            try
            {
                using (adapter)
                {
                    var labTestOrdered = adapter.GetData().FirstOrDefault(lto => lto.test_ordered_id == id);
                    return this.GetTestOrderedFromRow(labTestOrdered);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<LabTestOrdered> GetAll()
        {
            var testOrderedList = new List<LabTestOrdered>();
            var adapter = new test_orderedTableAdapter();
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<LabTestOrdered> GetByAppointmentId(int appointmentId)
        {
            var testList = new List<LabTestOrdered>();
            var adapter = new appointment_has_lab_orderTableAdapter();
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
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
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}