namespace HealthcareProjectBeamMaginniss.Model
{
    internal class LabTest
    {
        #region Properties

        public int LabTestId { get; }
        public string TestName { get; }

        #endregion

        #region Constructors

        public LabTest(int labTestId, string testName)
        {
            this.LabTestId = labTestId;
            this.TestName = testName;
        }

        public LabTest(string testName)
        {
            this.TestName = testName;
        }

        #endregion
    }
}