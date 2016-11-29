using System;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Appointment
    {
        #region Properties

        public int AppointmentId { get; }
        public string ReasonForAppointment { get; }
        public DateTime Date { get; }
        public int NureseId { get; }
        public string NurseName => new StaffController().GetName(this.NureseId);
        public int DoctorId { get; }
        public string DoctorName => new StaffController().GetName(this.DoctorId);
        public int PatientId { get; }
        public string PatientName => new PatientController().GetName(this.PatientId);
        public int SystolicBp { get; }
        public int DiastolicBp { get; }
        public decimal Temperature { get; }
        public int Pulse { get; }
        public decimal Weight { get; }
        public string Symptoms { get; }

        #endregion

        #region Constructors

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