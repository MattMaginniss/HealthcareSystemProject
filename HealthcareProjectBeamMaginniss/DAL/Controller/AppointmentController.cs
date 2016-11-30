using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    /// <summary>
    ///     Controls interaction between Appointment Repo and View
    /// </summary>
    public class AppointmentController
    {
        #region Data members

        private readonly AppointmentRepository appointmentRepository;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AppointmentController" /> class.
        /// </summary>
        public AppointmentController()
        {
            this.appointmentRepository = new AppointmentRepository();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AppointmentController" /> class.
        /// </summary>
        /// <param name="appointmentRepository">The appointment repository.</param>
        internal AppointmentController(AppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        #endregion

        /// <summary>
        ///     Adds the specified appointment to the Database.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void Add(Appointment appointment)
        {
            this.appointmentRepository.Add(appointment);
        }

        /// <summary>
        ///     Gets the appointment by id.
        /// </summary>
        /// <param name="id">The appointment ID.</param>
        /// <returns>The appropriate appointment</returns>
        public Appointment GetById(int id)
        {
            return this.appointmentRepository.GetById(id);
        }

        /// <summary>
        ///     Gets all appointments.
        /// </summary>
        /// <returns>All Appointments</returns>
        public IList<Appointment> GetAll()
        {
            return this.appointmentRepository.GetAll();
        }

        /// <summary>
        ///     Adds the partially completed appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void AddPartial(Appointment appointment)
        {
            this.appointmentRepository.AddPartial(appointment);
        }

        /// <summary>
        ///     Updates the specified appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void Update(Appointment appointment)
        {
            this.appointmentRepository.Update(appointment);
        }

        /// <summary>
        ///     Gets the appointment by first name of the patient.
        /// </summary>
        /// <param name="fName">Name of the patient.</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientFirstName(string fName)
        {
            return this.appointmentRepository.GetAppointmentByPatientFirstName(fName);
        }

        /// <summary>
        ///     Gets the appointment by last name of the patient.
        /// </summary>
        /// <param name="lName">Name of the patient.</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientLastName(string lName)
        {
            return this.appointmentRepository.GetAppointmentByPatientLastName(lName);
        }

        /// <summary>
        ///     Gets the appointment by full name of the patient.
        /// </summary>
        /// <param name="fName">Patient firstname.</param>
        /// <param name="lName">Patient lastname</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientFullName(string fName, string lName)
        {
            return this.appointmentRepository.GetAppointmentByPatientFullName(fName, lName);
        }

        /// <summary>
        ///     Gets the appointment by patient date of birth.
        /// </summary>
        /// <param name="dob">The dob.</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientDateOfBirth(string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientDateOfBirth(dob);
        }

        /// <summary>
        ///     Gets the appointment by patient first name and dob.
        /// </summary>
        /// <param name="fName">Patient firstname</param>
        /// <param name="dob">Patient dob.</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientFirstNameAndDob(string fName, string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientFirstNameAndDob(fName, dob);
        }

        /// <summary>
        ///     Gets the appointment by patient last name and dob.
        /// </summary>
        /// <param name="lName">Patient firstname</param>
        /// <param name="dob">Patient dob.</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientLastNameAndDob(string lName, string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientLastNameAndDob(lName, dob);
        }

        /// <summary>
        ///     Gets the appointment by patient full name and dob.
        /// </summary>
        /// <param name="fName">Patient firstname.</param>
        /// <param name="lName">Patient lastname</param>
        /// <param name="dob">Patient dob.</param>
        /// <returns>Matching patients</returns>
        public IList<Appointment> GetAppointmentByPatientFullNameAndDob(string fName, string lName, string dob)
        {
            return this.appointmentRepository.GetAppointmentByPatientFullNameAndDob(fName, lName, dob);
        }

        /// <summary>
        ///     Gets the appointments by patient identifier.
        /// </summary>
        /// <param name="patientId">The patient identifier.</param>
        /// <returns></returns>
        public IList<Appointment> GetAppointmentByPatientId(int patientId)
        {
            return this.appointmentRepository.GetAppointmentByPatientId(patientId);
        }
    }
}