using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    internal class AppointmentLabOrderController
    {
        #region Data members

        private readonly AppointmentLabOrderRepository apptLabTestOrderedRepository;

        #endregion

        #region Constructors

        public AppointmentLabOrderController()
        {
            this.apptLabTestOrderedRepository = new AppointmentLabOrderRepository();
        }

        public AppointmentLabOrderController(AppointmentLabOrderRepository apptLabTestOrderedRepository)
        {
            this.apptLabTestOrderedRepository = apptLabTestOrderedRepository;
        }

        #endregion

        public void Add(AppointmentLabOrder aptLabTestOrdered)
        {
            this.apptLabTestOrderedRepository.Add(aptLabTestOrdered);
        }

        public AppointmentLabOrder GetById(int id)
        {
            return this.apptLabTestOrderedRepository.GetById(id);
        }

        public IList<AppointmentLabOrder> GetAll()
        {
            return this.apptLabTestOrderedRepository.GetAll();
        }
    }
}