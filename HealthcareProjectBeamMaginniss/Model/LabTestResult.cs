namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class LabTestResult
    {
        public int ResultId { get; }
        public int TestOrderId { get; }

        public string TestResults { get; set; }

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
}
}