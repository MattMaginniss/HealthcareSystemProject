using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    internal class LabTestResultController
    {
        #region Data members

        private readonly LabTestResultRepository labTestResultRepository;

        #endregion

        #region Constructors

        public LabTestResultController()
        {
            this.labTestResultRepository = new LabTestResultRepository();
        }

        public LabTestResultController(LabTestResultRepository labTestResultRepository)
        {
            this.labTestResultRepository = labTestResultRepository;
        }

        #endregion

        public void Add(LabTestResult labTestOrdered)
        {
            this.labTestResultRepository.Add(labTestOrdered);
        }

        public LabTestResult GetById(int id)
        {
            return this.labTestResultRepository.GetById(id);
        }

        public IList<LabTestResult> GetAll()
        {
            return this.labTestResultRepository.GetAll();
        }

        public void Update(LabTestResult result)
        {
            this.labTestResultRepository.Update(result);
        }
    }
}