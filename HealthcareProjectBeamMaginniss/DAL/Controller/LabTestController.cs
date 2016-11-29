using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    internal class LabTestController
    {
        #region Data members

        private readonly LabTestRepository labTestRepository;

        #endregion

        #region Constructors

        public LabTestController()
        {
            this.labTestRepository = new LabTestRepository();
        }

        public LabTestController(LabTestRepository labTestRepository)
        {
            this.labTestRepository = labTestRepository;
        }

        #endregion

        #region Methods

        public void Add(LabTest labTest)
        {
            this.labTestRepository.Add(labTest);
        }

        public LabTest GetById(int id)
        {
            return this.labTestRepository.GetById(id);
        }

        public IList<LabTest> GetAll()
        {
            return this.labTestRepository.GetAll();
        }

        public string GetName(int id)
        {
            var name = this.labTestRepository.GetById(id).TestName ?? "";
            return name;
        }

        #endregion
    }
}