namespace HealthcareProjectBeamMaginniss.Model
{
    internal class AppointmentLabOrder
    {
        #region Properties

        public int AppointmentId { get; }
        public int LabOrderId { get; }

        #endregion

        #region Constructors

        public AppointmentLabOrder(int apptId, int labOrderId)
        {
            this.AppointmentId = apptId;
            this.LabOrderId = labOrderId;
        }

        #endregion
    }
}