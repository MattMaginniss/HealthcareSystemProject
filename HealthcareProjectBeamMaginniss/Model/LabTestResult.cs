namespace HealthcareProjectBeamMaginniss.Model
{
    internal class LabTestResult
    {
        #region Properties

        public int ResultId { get; }
        public int TestOrderId { get; }

        public string TestResults { get; set; }

        #endregion

        #region Constructors

        public LabTestResult(int resultId, int testOrderId, string testResults)
        {
            this.ResultId = resultId;
            this.TestOrderId = testOrderId;
            this.TestResults = testResults;
        }

        public LabTestResult(int testOrderId, string testResults)
        {
            this.TestOrderId = testOrderId;
            this.TestResults = testResults;
        }

        #endregion
    }
}