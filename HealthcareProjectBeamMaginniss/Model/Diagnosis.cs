namespace HealthcareProjectBeamMaginniss.Model
{
    /// <summary>
    ///     Represents a diagnosis as made by a doctor or nurse
    /// </summary>
    public class Diagnosis
    {
        #region Properties

        /// <summary>
        ///     Gets the diagnosis identifier.
        /// </summary>
        /// <value>
        ///     The diagnosis identifier.
        /// </value>
        public int DiagnosisId { get; }

        /// <summary>
        ///     Gets the diagnosis information.
        /// </summary>
        /// <value>
        ///     The diagnosis information.
        /// </value>
        public string DiagnosisInformation { get; }

        /// <summary>
        ///     Gets the appointment identifier.
        /// </summary>
        /// <value>
        ///     The appointment identifier.
        /// </value>
        public int AppointmentId { get; }

        /// <summary>
        ///     Gets a value indicating whether [final diagnosis].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [final diagnosis]; otherwise, <c>false</c>.
        /// </value>
        public bool FinalDiagnosis { get; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Diagnosis" /> class.
        /// </summary>
        /// <param name="diagnosisId">The diagnosis identifier.</param>
        /// <param name="diagnosisInformation">The diagnosis information.</param>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="finalDiagnosis">if set to <c>true</c> [final diagnosis].</param>
        public Diagnosis(int diagnosisId, string diagnosisInformation, int appointmentId, bool finalDiagnosis)
        {
            this.DiagnosisId = diagnosisId;
            this.DiagnosisInformation = diagnosisInformation;
            this.AppointmentId = appointmentId;
            this.FinalDiagnosis = finalDiagnosis;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Diagnosis" /> class.
        /// </summary>
        /// <param name="diagnosisInformation">The diagnosis information.</param>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="finalDiagnosis">if set to <c>true</c> [final diagnosis].</param>
        public Diagnosis(string diagnosisInformation, int appointmentId, bool finalDiagnosis)
        {
            this.DiagnosisInformation = diagnosisInformation;
            this.AppointmentId = appointmentId;
            this.FinalDiagnosis = finalDiagnosis;
        }

        #endregion
    }
}