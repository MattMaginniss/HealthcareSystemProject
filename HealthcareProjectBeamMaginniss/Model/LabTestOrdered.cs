using HealthcareProjectBeamMaginniss.DAL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class LabTestOrdered
    {
        public int TestOrderedId { get; }
        public int TestId { get; }
        public string TestName => new LabTestController().GetName(this.TestId);

        public int DoctorId { get; }
        public string DoctorName => new StaffController().GetName(this.DoctorId);


        public DateTime TestDate { get;  }

        public int TestResultId { get; set; }

        public bool HasResult => TestResultId > 0;

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

    }
}
