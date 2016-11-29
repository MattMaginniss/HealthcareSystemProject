using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;
using System.Data;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    class LabTestResultRepository:IRepository<LabTestResult>
    {
        public void Add(LabTestResult result)
        {
            var adapter = new test_resultsTableAdapter();
            var testOrderedId = result.TestOrderId;
            var results = result.TestResults;

            using (adapter)
            {
                adapter.Insert(testOrderedId,results);
            }
        }

        public LabTestResult GetById(int id)
        {
            var adapter = new test_resultsTableAdapter();

            using (adapter)
            {
                var result = adapter.GetData().FirstOrDefault(res => res.test_result_id == id);
                return this.getTestFromRow(result);
            }
        }

        public IList<LabTestResult> GetAll()
        {
            var testList = new List<LabTestResult>();
            var adapter = new test_resultsTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var test = getTestFromRow((cs3230f16bDataSet.test_resultsRow)row);
                    testList.Add(test);
                }
            }
            return testList;
        }

 

        public LabTestResult getTestFromRow(cs3230f16bDataSet.test_resultsRow row)
        {
            var resultId = row.test_result_id;
            var diagnosisID = row.lab_tests_diagnosisID;
            var testOrderedId = row.lab_tests_orderedID;
            var results = row.testResults;
            return new LabTestResult(resultId, testOrderedId, results);
        }

        public void Update(LabTestResult result)
        {
            var adapter = new test_resultsTableAdapter();
            DataRow resRow = null;
            using (adapter)
            {
                resRow = adapter.GetData().FirstOrDefault(res => res.test_result_id == result.ResultId);
            }
            if (resRow != null)
            {
                resRow[2] = result.TestResults;
                using (adapter)
                {
                    adapter.Update(resRow);
                }
            }
        }


    }
}
