using System;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class LabTestOrdered
    {
        #region Properties

        public int TestOrderedId { get; }
        public int TestId { get; }
        public string TestName => new LabTestController().GetName(this.TestId);

        public int DoctorId { get; }
        public string DoctorName => new StaffController().GetName(this.DoctorId);

        public DateTime TestDate { get; }

        public int TestResultId { get; set; }

        public bool HasResult => this.TestResultId > 0;

        #endregion

        #region Constructors

        public LabTestOrdered(int testOrderedId, int testId, int doctorId, DateTime testDate)
        {
            this.TestOrderedId = testOrderedId;
            this.TestId = testId;
            this.DoctorId = doctorId;
            this.TestDate = testDate;
            this.TestResultId = -1;
        }

        public LabTestOrdered(int testId, int doctorId, DateTime testDate)
        {
            this.TestId = testId;
            this.DoctorId = doctorId;
            this.TestDate = testDate;
            this.TestResultId = -1;
        }

        #endregion
    }
}