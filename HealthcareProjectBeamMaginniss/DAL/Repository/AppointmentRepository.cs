using System;
using System.Collections.Generic;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;
using System.Data;

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

        public void Update(Appointment appointment)
        {
            var adapter = new appointmentTableAdapter();
            DataRow aptrow = null;
            using (adapter)
            {
                aptrow = adapter.GetData().FirstOrDefault(apt => apt.appointmentID == appointment.AppointmentID);
            }
            if (aptrow != null)
            {
                aptrow[1] = appointment.ReasonForAppointment;
                aptrow[2] = appointment.date;
                aptrow[3] = appointment.nureseID;
                aptrow[4] = appointment.doctorID;
                aptrow[5] = appointment.patientID;
                aptrow[6] = appointment.systolicBP;
                aptrow[7] = appointment.diastolicBP;
                aptrow[8] = appointment.temperature;
                aptrow[9] = appointment.pulse;
                aptrow[10] = appointment.weight;
                aptrow[11] = appointment.symptoms;
                aptrow[12] = appointment.diagnosisID;
                using (adapter)
                {
                    adapter.Update(aptrow);
                }
            }

        }

        public void AddPartial(Appointment appointment)
        {
            var adapter = new appointmentTableAdapter();
            var reasonForAppointment = appointment.ReasonForAppointment;
            var date = appointment.date;
            var doctorId = appointment.doctorID;
            var patientId = appointment.patientID;
            var symptoms = appointment.symptoms;

            int nureseId = 0;
            int systolicBp = 0;
            int diastolicBp = 0;
            int temperature = 0;
            int pulse = 0;
            int weight = 0;
            int diagnosisId = 0;
            using (adapter)
            {
                adapter.Insert(reasonForAppointment, date, nureseId, doctorId, patientId, systolicBp, diastolicBp, temperature, pulse, weight, symptoms, diagnosisId);
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

        public Appointment getAppointmentFromRow(cs3230f16bDataSet.appointmentRow row)
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

        public IList<Appointment> GetAppointmentByPatientDateOfBirth(String dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.Dob.ToShortDateString().Equals(dob))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }

        public IList<Appointment> GetAppointmentByPatientFirstName(String fName)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.FirstName.ToLower().Equals(fName))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }

        public IList<Appointment> GetAppointmentByPatientLastName(String lName)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.LastName.ToLower().Equals(lName))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }

        public IList<Appointment> GetAppointmentByPatientFullName(String fName, String lName)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.FirstName.ToLower().Equals(fName) && patient.LastName.ToLower().Equals(lName))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }

        public IList<Appointment> GetAppointmentByPatientFirstNameAndDob(String fName, String dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.FirstName.ToLower().Equals(fName) && patient.Dob.ToShortDateString().Equals(dob))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }

        public IList<Appointment> GetAppointmentByPatientLastNameAndDob(String lName, String dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.LastName.ToLower().Equals(lName) && patient.Dob.ToShortDateString().Equals(dob))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }


        public IList<Appointment> GetAppointmentByPatientFullNameAndDob(String fName, String lName, String dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var appointment = getAppointmentFromRow((cs3230f16bDataSet.appointmentRow)row);
                    var patient = patientRepository.GetById(appointment.patientID);

                    if (patient.FirstName.ToLower().Equals(fName) && patient.LastName.ToLower().Equals(lName) && patient.Dob.ToShortDateString().Equals(dob))
                    {
                        appointmentList.Add(appointment);
                    }
                }
            }

            return appointmentList;
        }
    }
}