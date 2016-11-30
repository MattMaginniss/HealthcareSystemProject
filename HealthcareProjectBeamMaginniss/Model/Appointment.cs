using System;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.Model
{
    /// <summary>
    ///     Represents a patient's appointment with a medical specialist
    /// </summary>
    public class Appointment
    {
        #region Properties

        /// <summary>
        ///     Gets the appointment identifier.
        /// </summary>
        /// <value>
        ///     The appointment identifier.
        /// </value>
        public int AppointmentId { get; }

        /// <summary>
        ///     Gets the reason for appointment.
        /// </summary>
        /// <value>
        ///     The reason for appointment.
        /// </value>
        public string ReasonForAppointment { get; }

        /// <summary>
        ///     Gets the date.
        /// </summary>
        /// <value>
        ///     The date.
        /// </value>
        public DateTime Date { get; }

        /// <summary>
        ///     Gets the nurese identifier.
        /// </summary>
        /// <value>
        ///     The nurese identifier.
        /// </value>
        public int NureseId { get; }

        /// <summary>
        ///     Gets the name of the nurse.
        /// </summary>
        /// <value>
        ///     The name of the nurse.
        /// </value>
        public string NurseName => new StaffController().GetName(this.NureseId);

        /// <summary>
        ///     Gets the doctor identifier.
        /// </summary>
        /// <value>
        ///     The doctor identifier.
        /// </value>
        public int DoctorId { get; }

        /// <summary>
        ///     Gets the name of the doctor.
        /// </summary>
        /// <value>
        ///     The name of the doctor.
        /// </value>
        public string DoctorName => new StaffController().GetName(this.DoctorId);

        /// <summary>
        ///     Gets the patient identifier.
        /// </summary>
        /// <value>
        ///     The patient identifier.
        /// </value>
        public int PatientId { get; }

        /// <summary>
        ///     Gets the name of the patient.
        /// </summary>
        /// <value>
        ///     The name of the patient.
        /// </value>
        public string PatientName => new PatientController().GetName(this.PatientId);

        /// <summary>
        ///     Gets the systolic bp.
        /// </summary>
        /// <value>
        ///     The systolic bp.
        /// </value>
        public int SystolicBp { get; }

        /// <summary>
        ///     Gets the diastolic bp.
        /// </summary>
        /// <value>
        ///     The diastolic bp.
        /// </value>
        public int DiastolicBp { get; }

        /// <summary>
        ///     Gets the temperature.
        /// </summary>
        /// <value>
        ///     The temperature.
        /// </value>
        public decimal Temperature { get; }

        /// <summary>
        ///     Gets the pulse.
        /// </summary>
        /// <value>
        ///     The pulse.
        /// </value>
        public int Pulse { get; }

        /// <summary>
        ///     Gets the weight.
        /// </summary>
        /// <value>
        ///     The weight.
        /// </value>
        public decimal Weight { get; }

        /// <summary>
        ///     Gets the symptoms.
        /// </summary>
        /// <value>
        ///     The symptoms.
        /// </value>
        public string Symptoms { get; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Appointment" /> class.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="reasonForAppointment">The reason for appointment.</param>
        /// <param name="date">The date.</param>
        /// <param name="nureseId">The nurese identifier.</param>
        /// <param name="doctorId">The doctor identifier.</param>
        /// <param name="patientId">The patient identifier.</param>
        /// <param name="systolicBp">The systolic bp.</param>
        /// <param name="diastolicBp">The diastolic bp.</param>
        /// <param name="temperature">The temperature.</param>
        /// <param name="pulse">The pulse.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="symptoms">The symptoms.</param>
        public Appointment(int appointmentId, string reasonForAppointment, DateTime date, int nureseId, int doctorId,
            int patientId, int systolicBp, int diastolicBp, decimal temperature, int pulse, decimal weight,
            string symptoms)
        {
            this.AppointmentId = appointmentId;
            this.ReasonForAppointment = reasonForAppointment;
            this.Date = date;
            this.NureseId = nureseId;
            this.DoctorId = doctorId;
            this.PatientId = patientId;
            this.SystolicBp = systolicBp;
            this.DiastolicBp = diastolicBp;
            this.Temperature = temperature;
            this.Pulse = pulse;
            this.Weight = weight;
            this.Symptoms = symptoms;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Appointment" /> class.
        /// </summary>
        /// <param name="reasonForAppointment">The reason for appointment.</param>
        /// <param name="date">The date.</param>
        /// <param name="doctorId">The doctor identifier.</param>
        /// <param name="patientId">The patient identifier.</param>
        /// <param name="symptoms">The symptoms.</param>
        public Appointment(string reasonForAppointment, DateTime date, int doctorId, int patientId, string symptoms)
        {
            this.ReasonForAppointment = reasonForAppointment;
            this.Date = date;
            this.DoctorId = doctorId;
            this.PatientId = patientId;
            this.Symptoms = symptoms;
        }

        #endregion
    }
}