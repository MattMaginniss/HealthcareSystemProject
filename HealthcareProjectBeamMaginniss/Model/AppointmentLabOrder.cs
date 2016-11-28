using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.Model
{
    class AppointmentLabOrder
    {
        public int AppointmentId { get; }
        public int LabOrderId { get; }

        public AppointmentLabOrder(int apptId, int labOrderId)
        {
            this.AppointmentId = apptId;
            this.LabOrderId = labOrderId;
        }
    }
}
