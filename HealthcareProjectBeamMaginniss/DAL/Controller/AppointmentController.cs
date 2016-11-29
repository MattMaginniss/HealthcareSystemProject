using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    public class AppointmentController
    {
        #region Data members

        private readonly AppointmentRepository appointmentRepository;

        #endregion

        #region Constructors

        public AppointmentController()
        {
            this.appointmentRepository = new AppointmentRepository();
        }

        public AppointmentController(AppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        #endregion

        #region Methods

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

        public IList<Appointment> GetAppointmentByPatientFirstName(string fName)
        {
            return this.appointmentRepository.GetAppointmentByPatientFirstName(fName);
        }

        public IList<Appointment> GetAppointmentByPatientLastName(string lName)
        {
            return this.appointmentRepository.GetAppointmentByPatientLastName(lName);
        }

        public IList<Appointment> GetAppointmentByPatientFullName(string fName, string lName)
        {
            return this.appointmentRepository.GetAppointmentByPatientFullName(fName, lName);
        }

        public IList<Appointment> GetAppointmentByPatientDateOfBirth(string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientDateOfBirth(dob);
        }

        public IList<Appointment> GetAppointmentByPatientFirstNameAndDob(string fName, string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientFirstNameAndDob(fName, dob);
        }

        public IList<Appointment> GetAppointmentByPatientLastNameAndDob(string lName, string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientLastNameAndDob(lName, dob);
        }

        public IList<Appointment> GetAppointmentByPatientFullNameAndDob(string fName, string lName, string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientFullNameAndDob(fName, lName, dob);
        }

        #endregion
    }
}