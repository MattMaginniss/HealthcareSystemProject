using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.Model
{
    class LabTest
    {
        public int LabTestId { get; }
        public string TestName { get; }

        public LabTest(int labTestId, string testName)
        {
            this.LabTestId = labTestId;
            this.TestName = testName;
        }
        public LabTest(string testName)
        {
            this.TestName = testName;
        }
    }
}
