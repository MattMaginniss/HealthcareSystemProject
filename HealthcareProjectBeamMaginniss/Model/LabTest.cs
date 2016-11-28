using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.Model
{
    class LabTest
    {
        public int LabTestID { get; }
        public string TestName { get; }

        public LabTest(int labTestId, string testName)
        {
            this.LabTestID = labTestId;
            this.TestName = testName;
        }
    }
}
