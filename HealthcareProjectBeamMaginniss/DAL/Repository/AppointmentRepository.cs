using System.Collections.Generic;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    public class AppointmentRepository:IRepository<Appointment>
    {
        public void Add(Appointment appointment)
        {
            var adapter = new appointmentTableAdapter();
            var reasonForAppointment = appointment.ReasonForAppointment;
            var date = appointment.date;
            var nureseId = appointment.nureseID;
            var doctorId = appointment.doctorID;
            var patientId = appointment.patientID;
            var systolicBp = appointment.systolicBP;
            var diastolicBp = appointment.diastolicBP;
            var temperature = appointment.temperature;
            var pulse = appointment.pulse;
            var weight = appointment.weight;
            var symptoms = appointment.symptoms;
            var diagnosisId = appointment.diagnosisID;
            using (adapter)
            {
                adapter.Insert(reasonForAppointment, date, nureseId, doctorId, patientId,systolicBp, diastolicBp, temperature, pulse, weight, symptoms, diagnosisId);
            }
        }

        public Appointment GetById(int id)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();
            using (adapter)
            {
                var patient = adapter.GetData().FirstOrDefault(pat => pat.patientID == id);
                return this.getAppointmentFromRow(patient);
            }
        }

        public IList<Appointment> GetAll()
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    appointmentList.Add(appointment);
                }
            }
            return appointmentList;
        }

        private Appointment getAppointmentFromRow(cs3230f16bDataSet.appointmentRow row)
        {
            var appointmentId = row.appointmentID;
            var reasonForAppointment = row.reasonForAppointment;
            var date = row.dateScheduled;
            var nureseId = row.nurse_StaffID;
            var doctorId = row.doctor_StaffID;
            var patientId = row.patientID;
            var systolicBp = row.systolicBP;
            var diastolicBp = row.diastolicBP;
            var temperature = row.temperature;
            var pulse = row.pulse;
            var weight = row.weight;
            var symptoms = row.symptoms;
            var diagnosisId = row.diagnosis_diagnosisID;
            return new Appointment(appointmentId, reasonForAppointment, date, nureseId, doctorId,
            patientId, systolicBp, diastolicBp, temperature, pulse, weight,
            symptoms, diagnosisId);
        }
    }
}