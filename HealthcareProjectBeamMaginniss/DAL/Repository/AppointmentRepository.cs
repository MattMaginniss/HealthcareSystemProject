using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    public class AppointmentRepository : IRepository<Appointment>
    {
        #region Methods

        public void Add(Appointment appointment)
        {
            var adapter = new appointmentTableAdapter();
            var reasonForAppointment = appointment.ReasonForAppointment;
            var date = appointment.Date;
            var nureseId = appointment.NureseId;
            var doctorId = appointment.DoctorId;
            var patientId = appointment.PatientId;
            var systolicBp = appointment.SystolicBp;
            var diastolicBp = appointment.DiastolicBp;
            var temperature = appointment.Temperature;
            var pulse = appointment.Pulse;
            var weight = appointment.Weight;
            var symptoms = appointment.Symptoms;
            try
            {
                using (adapter)
                {
                    adapter.Insert(reasonForAppointment, date, nureseId, doctorId, patientId, systolicBp, diastolicBp,
                        temperature, pulse, weight, symptoms);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Appointment GetById(int id)
        {
            var adapter = new appointmentTableAdapter();
            try
            {
                using (adapter)
                {
                    var appointment = adapter.GetData().FirstOrDefault(apt => apt.appointmentID == id);
                    return this.GetAppointmentFromRow(appointment);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAll()
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        appointmentList.Add(appointment);
                    }
                }
                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Appointment appointment)
        {
            var adapter = new appointmentTableAdapter();
            DataRow aptrow = null;
            try
            {
                using (adapter)
                {
                    aptrow = adapter.GetData().FirstOrDefault(apt => apt.appointmentID == appointment.AppointmentId);
                }
                if (aptrow == null)
                {
                    return;
                }
                aptrow[1] = appointment.ReasonForAppointment;
                aptrow[2] = appointment.Date;
                aptrow[3] = appointment.NureseId;
                aptrow[4] = appointment.DoctorId;
                aptrow[5] = appointment.PatientId;
                aptrow[6] = appointment.SystolicBp;
                aptrow[7] = appointment.DiastolicBp;
                aptrow[8] = appointment.Temperature;
                aptrow[9] = appointment.Pulse;
                aptrow[10] = appointment.Weight;
                aptrow[11] = appointment.Symptoms;
                using (adapter)
                {
                    adapter.Update(aptrow);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddPartial(Appointment appointment)
        {
            var adapter = new appointmentTableAdapter();
            var reasonForAppointment = appointment.ReasonForAppointment;
            var date = appointment.Date;
            var doctorId = appointment.DoctorId;
            var patientId = appointment.PatientId;
            var symptoms = appointment.Symptoms;

            var nureseId = 0;
            var systolicBp = 0;
            var diastolicBp = 0;
            var temperature = 0;
            var pulse = 0;
            var weight = 0;
            try
            {
                using (adapter)
                {
                    adapter.Insert(reasonForAppointment, date, nureseId, doctorId, patientId, systolicBp, diastolicBp,
                        temperature, pulse, weight, symptoms);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Appointment GetAppointmentFromRow(cs3230f16bDataSet.appointmentRow row)
        {
            if (row == null)
            {
                return null;
            }
            var appointmentId = row.appointmentID;
            var reasonForAppointment = row.IsreasonForAppointmentNull()? " ":row.reasonForAppointment;
            var date = row.IsdateScheduledNull() ? DateTime.MinValue : row.dateScheduled;
            var nureseId = row.nurse_StaffID;
            var doctorId = row.doctor_StaffID;
            var patientId = row.patientID;
            var systolicBp = row.IssystolicBPNull() ? 0 : row.systolicBP;
            var diastolicBp = row.IsdiastolicBPNull() ? 0 : row.diastolicBP;
            var temperature = row.IstemperatureNull() ? 0 : row.temperature;
            var pulse = row.IspulseNull() ? 0 : row.pulse;
            var weight = row.IsweightNull() ? 0 : row.weight;
            var symptoms = row.IssymptomsNull()? " ":row.symptoms;
            return new Appointment(appointmentId, reasonForAppointment, date, nureseId, doctorId,
                patientId, systolicBp, diastolicBp, temperature, pulse, weight,
                symptoms);
        }

        public IList<Appointment> GetAppointmentByPatientDateOfBirth(string dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.Dob.ToShortDateString().Equals(dob))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientFirstName(string fName)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.FirstName.ToLower().Equals(fName))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientLastName(string lName)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.LastName.ToLower().Equals(lName))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientFullName(string fName, string lName)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.FirstName.ToLower().Equals(fName) && patient.LastName.ToLower().Equals(lName))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientFirstNameAndDob(string fName, string dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.FirstName.ToLower().Equals(fName) && patient.Dob.ToShortDateString().Equals(dob))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientLastNameAndDob(string lName, string dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.LastName.ToLower().Equals(lName) && patient.Dob.ToShortDateString().Equals(dob))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientFullNameAndDob(string fName, string lName, string dob)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            var patientRepository = new PatientRepository();
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var appointment = this.GetAppointmentFromRow((cs3230f16bDataSet.appointmentRow) row);
                        var patient = patientRepository.GetById(appointment.PatientId);

                        if (patient.FirstName.ToLower().Equals(fName) && patient.LastName.ToLower().Equals(lName) &&
                            patient.Dob.ToShortDateString().Equals(dob))
                        {
                            appointmentList.Add(appointment);
                        }
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Appointment> GetAppointmentByPatientId(int patientId)
        {
            var appointmentList = new List<Appointment>();
            var adapter = new appointmentTableAdapter();

            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Where(apt => apt.patientID == patientId))
                    {
                        var appointment = this.GetAppointmentFromRow(row);
                        appointmentList.Add(appointment);
                    }
                }

                return appointmentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}