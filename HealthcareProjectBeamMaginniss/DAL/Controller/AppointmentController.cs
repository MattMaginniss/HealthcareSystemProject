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

    }
}