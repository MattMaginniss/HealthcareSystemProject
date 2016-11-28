using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.Model
{
    class LabTestOrdered
    {
        public int TestOrderedId { get; }
        public int TestId { get; }

        public int DoctorId { get; }

        public DateTime TestDate { get;  }

        public LabTestOrdered(int testOrderedId, int testId, int doctorId, DateTime testDate)
        {
            this.TestOrderedId = testOrderedId;
            this.TestId = testId;
            this.DoctorId = doctorId;
            this.TestDate = testDate;
        }

        public LabTestOrdered(int testId, int doctorId, DateTime testDate)
        {
            this.TestId = testId;
            this.DoctorId = doctorId;
            this.TestDate = testDate;
        }

    }
}
