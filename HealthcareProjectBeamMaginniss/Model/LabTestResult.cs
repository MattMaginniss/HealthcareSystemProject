namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class LabTestResult
    {

        public int DiagnosisId { get; }
        public int TestOrderId { get; }

        public string TestResults { get; set; }

        public LabTestResult(int diagnosisId, int testOrderId, string testResults)
        {
            this.DiagnosisId = diagnosisId;
            this.TestOrderId = testOrderId;
            this.TestResults = testResults;

    }
}
}