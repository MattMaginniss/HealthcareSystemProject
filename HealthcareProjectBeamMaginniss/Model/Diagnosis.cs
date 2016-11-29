namespace HealthcareProjectBeamMaginniss.Model
{
    public class Diagnosis
    {
        #region Properties

        public int DiagnosisId { get; }
        public string DiagnosisInformation { get; }

        public int AppointmentId { get; }

        public bool FinalDiagnosis { get; }

        #endregion

        #region Constructors

        public Diagnosis(int diagnosisId, string diagnosisInformation, int appointmentId, bool finalDiagnosis)
        {
            this.DiagnosisId = diagnosisId;
            this.DiagnosisInformation = diagnosisInformation;
            this.AppointmentId = appointmentId;
            this.FinalDiagnosis = finalDiagnosis;
        }

        public Diagnosis(string diagnosisInformation, int appointmentId, bool finalDiagnosis)
        {
            this.DiagnosisInformation = diagnosisInformation;
            this.AppointmentId = appointmentId;
            this.FinalDiagnosis = finalDiagnosis;
        }

        #endregion
    }
}