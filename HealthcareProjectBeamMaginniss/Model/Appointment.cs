using HealthcareProjectBeamMaginniss.DAL.Controller;
using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Appointment
    {
        public int AppointmentID { get; }
        public string ReasonForAppointment { get; }
        public DateTime date { get; }
        public int nureseID { get; }
        public string nurseName => new StaffController().GetName(this.nureseID);
        public int doctorID { get; }
        public string doctorName => new StaffController().GetName(this.doctorID);
        public int patientID { get; }
        public string patientName => new PatientController().GetName(this.patientID);
        public int systolicBP { get; }
        public int diastolicBP { get; }
        public decimal temperature { get; }
        public int pulse { get; }
        public decimal weight { get; }
        public string symptoms { get; }

        public Appointment(int appointmentId, string reasonForAppointment, DateTime date, int nureseId, int doctorId,
            int patientId, int systolicBp, int diastolicBp, decimal temperature, int pulse, decimal weight,
            string symptoms)
        {
            this.AppointmentID = appointmentId;
            this.ReasonForAppointment = reasonForAppointment;
            this.date = date;
            this.nureseID = nureseId;
            this.doctorID = doctorId;
            this.patientID = patientId;
            this.systolicBP = systolicBp;
            this.diastolicBP = diastolicBp;
            this.temperature = temperature;
            this.pulse = pulse;
            this.weight = weight;
            this.symptoms = symptoms;
        }

        public Appointment(string reasonForAppointment, DateTime date, int doctorId, int patientId, string symptoms)
        {
            this.ReasonForAppointment = reasonForAppointment;
            this.date = date;
            this.doctorID = doctorId;
            this.patientID = patientId;
            this.symptoms = symptoms;
        }
    }
}