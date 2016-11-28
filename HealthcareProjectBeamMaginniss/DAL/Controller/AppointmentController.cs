using System;
using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    public class AppointmentController
    {
        private readonly AppointmentRepository appointmentRepository;

        public AppointmentController()
        {
            this.appointmentRepository = new AppointmentRepository();
        }

        public AppointmentController(AppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        public void Add(Appointment appointment)
        {
            this.appointmentRepository.Add(appointment);

        }

        public Appointment GetById(int id)
        {
            return this.appointmentRepository.GetById(id);
        }

        public IList<Appointment> GetAll()
        {
           
            return this.appointmentRepository.GetAll();
        }

        public void AddPartial(Appointment appointment)
        {
            this.appointmentRepository.AddPartial(appointment);
        }

        public void Update(Appointment appointment)
        {
            this.appointmentRepository.Update(appointment);
        }

        public IList<Appointment> GetAppointmentByPatientFirstName(String fName)
        {
            return this.appointmentRepository.GetAppointmentByPatientFirstName(fName);
        }
        public IList<Appointment> GetAppointmentByPatientLastName(String lName)
        {
            return this.appointmentRepository.GetAppointmentByPatientLastName(lName);
        }
        public IList<Appointment> GetAppointmentByPatientFullName(String fName, String lName)
        {
            return this.appointmentRepository.GetAppointmentByPatientFullName(fName, lName);
        }

        public IList<Appointment> GetAppointmentByPatientDateOfBirth(String dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientDateOfBirth(dob);
        }

        public IList<Appointment> GetAppointmentByPatientFirstNameAndDob(String fName, String dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientFirstNameAndDob(fName, dob);
        }
        public IList<Appointment> GetAppointmentByPatientLastNameAndDob(String lName, String dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientLastNameAndDob(lName, dob);
        }
        public IList<Appointment> GetAppointmentByPatientFullNameAndDob(String fName, String lName, String dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientFullNameAndDob(fName, lName, dob);
        }
    }
}