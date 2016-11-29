using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    internal class LabTestOrderedController
    {
        #region Data members

        private readonly LabTestOrderedRepository labTestOrderedRepository;

        #endregion

        #region Constructors

        public LabTestOrderedController()
        {
            this.labTestOrderedRepository = new LabTestOrderedRepository();
        }

        public LabTestOrderedController(LabTestOrderedRepository labTestOrderedRepository)
        {
            this.labTestOrderedRepository = labTestOrderedRepository;
        }

        #endregion

        #region Methods

        public void Add(LabTestOrdered labTestOrdered)
        {
            this.labTestOrderedRepository.Add(labTestOrdered);
        }

        public LabTestOrdered GetById(int id)
        {
            return this.labTestOrderedRepository.GetById(id);
        }

        public IList<LabTestOrdered> GetAll()
        {
            return this.labTestOrderedRepository.GetAll();
        }

        public IList<LabTestOrdered> GetByAppointmentId(int appointmentId)
        {
            return this.labTestOrderedRepository.GetByAppointmentId(appointmentId);
        }

        public int GetLastId()
        {
            return this.labTestOrderedRepository.GetLastId();
        }

        #endregion
    }
}