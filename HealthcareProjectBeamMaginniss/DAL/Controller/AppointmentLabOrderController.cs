using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    class AppointmentLabOrderController
    {
        private readonly AppointmentLabOrderRepository apptLabTestOrderedRepository;

        public AppointmentLabOrderController()
        {
            this.apptLabTestOrderedRepository = new AppointmentLabOrderRepository();
        }

        public AppointmentLabOrderController(AppointmentLabOrderRepository apptLabTestOrderedRepository)
        {
            this.apptLabTestOrderedRepository = apptLabTestOrderedRepository;
        }


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
