using System.Collections.Generic;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class LabTestRepository : IRepository<LabTest>
    {
        #region Methods

        public void Add(LabTest test)
        {
            var adapter = new lab_testsTableAdapter();
            var testName = test.TestName;

            using (adapter)
            {
                adapter.Insert(testName);
            }
        }

        public LabTest GetById(int id)
        {
            var adapter = new lab_testsTableAdapter();

            using (adapter)
            {
                var test = adapter.GetData().FirstOrDefault(tst => tst.testCode == id);
                return this.GetTestFromRow(test);
            }
        }

        public IList<LabTest> GetAll()
        {
            var testList = new List<LabTest>();
            var adapter = new lab_testsTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var test = this.GetTestFromRow((cs3230f16bDataSet.lab_testsRow) row);
                    testList.Add(test);
                }
            }
            return testList;
        }

        public LabTest GetTestFromRow(cs3230f16bDataSet.lab_testsRow row)
        {
            var testId = row.testCode;
            var testName = row.testName;
            return new LabTest(testId, testName);
        }

        #endregion
    }
}