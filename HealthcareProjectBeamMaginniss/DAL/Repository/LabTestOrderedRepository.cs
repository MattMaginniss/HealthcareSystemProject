using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    class LabTestOrderedRepository: IRepository<LabTestOrdered>
    {
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
                return this.getTestOrderedFromRow(labTestOrdered);
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
                    var test = getTestOrderedFromRow((cs3230f16bDataSet.test_orderedRow)row);
                    testOrderedList.Add(test);
                }
            }
            return testOrderedList;
        }

        public LabTestOrdered getTestOrderedFromRow(cs3230f16bDataSet.test_orderedRow row)
        {
            var testOrderedId = row.test_ordered_id;
            var testId = row.test_id;
            var doctorId = row.doctor_id;
            var testDate = row.test_date;
            return new LabTestOrdered(testOrderedId, testId, doctorId, testDate);
        }


        public int GetLastID()
        {
            var adapter = new test_orderedTableAdapter();
            using (adapter)
            {
                var labTestOrdered = adapter.GetData().LastOrDefault();
                return labTestOrdered.test_ordered_id;
            }
        }
    }
}
