namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class LabTestResult
    {
        public int ResultId { get; }
        public int DiagnosisId { get; }
        public int TestOrderId { get; }

        public string TestResults { get; set; }

        public LabTestResult(int resultId, int diagnosisId, int testOrderId, string testResults)
        {
            this.ResultId = resultId;
            this.DiagnosisId = diagnosisId;
            this.TestOrderId = testOrderId;
            this.TestResults = testResults;

        }

        public LabTestResult(int diagnosisId, int testOrderId, string testResults)
        {
            this.DiagnosisId = diagnosisId;
            this.TestOrderId = testOrderId;
            this.TestResults = testResults;

    }
}
}