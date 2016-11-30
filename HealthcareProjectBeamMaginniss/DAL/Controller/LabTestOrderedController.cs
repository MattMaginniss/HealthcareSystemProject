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

        public void Add(LabTestOrder labTestOrder)
        {
            this.labTestOrderedRepository.Add(labTestOrder);
        }

        public LabTestOrder GetById(int id)
        {
            return this.labTestOrderedRepository.GetById(id);
        }

        public IList<LabTestOrder> GetAll()
        {
            return this.labTestOrderedRepository.GetAll();
        }

        public IList<LabTestOrder> GetByAppointmentId(int appointmentId)
        {
            return this.labTestOrderedRepository.GetByAppointmentId(appointmentId);
        }

        public int GetLastId()
        {
            return this.labTestOrderedRepository.GetLastId();
        }

        public IList<LabTestOrder> GetByPatientId(int patientId)
        {
            return this.labTestOrderedRepository.GetByPatientId(patientId);
        }
    }
}