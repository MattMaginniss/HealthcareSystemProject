using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    class LabTestResultController
    {
        private readonly LabTestResultRepository labTestResultRepository;
        
        public LabTestResultController()
        {
            this.labTestResultRepository = new LabTestResultRepository();
        }

        public LabTestResultController(LabTestResultRepository labTestResultRepository)
        {
            this.labTestResultRepository = labTestResultRepository;
        }

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
    }
}
