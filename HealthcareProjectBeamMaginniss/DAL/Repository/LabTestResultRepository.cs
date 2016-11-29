using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class LabTestResultRepository : IRepository<LabTestResult>
    {
        #region Methods

        public void Add(LabTestResult result)
        {
            var adapter = new test_resultsTableAdapter();
            var testOrderedId = result.TestOrderId;
            var results = result.TestResults;
            try
            {
                using (adapter)
                {
                    adapter.Insert(testOrderedId, results);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public LabTestResult GetById(int id)
        {
            var adapter = new test_resultsTableAdapter();
            try
            {
                using (adapter)
                {
                    var result = adapter.GetData().FirstOrDefault(res => res.test_result_id == id);
                    return this.GetTestFromRow(result);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<LabTestResult> GetAll()
        {
            var testList = new List<LabTestResult>();
            var adapter = new test_resultsTableAdapter();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var test = this.GetTestFromRow((cs3230f16bDataSet.test_resultsRow) row);
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

        public LabTestResult GetTestFromRow(cs3230f16bDataSet.test_resultsRow row)
        {
            if (row == null)
            {
                return null;
            }
            var resultId = row.test_result_id;
            var testOrderedId = row.lab_tests_orderedID;
            var results = row.testResults;
            return new LabTestResult(resultId, testOrderedId, results);
        }

        public void Update(LabTestResult result)
        {
            var adapter = new test_resultsTableAdapter();
            DataRow resRow = null;
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}