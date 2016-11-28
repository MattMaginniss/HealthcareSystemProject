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
    class LabTestRepository:IRepository<LabTest>
    {
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
                return this.getTestFromRow(test);
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
                    var test = getTestFromRow((cs3230f16bDataSet.lab_testsRow)row);
                    testList.Add(test);
                }
            }
            return testList;
        }

        public LabTest getTestFromRow(cs3230f16bDataSet.lab_testsRow row)
        {
            var testId = row.testCode;
            var testName = row.testName;
            return new LabTest(testId, testName);
        }


    }
}
