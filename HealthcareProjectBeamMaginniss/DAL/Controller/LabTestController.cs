using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    class LabTestController
    {
        private readonly LabTestRepository labTestRepository;


        public LabTestController()
        {
            this.labTestRepository = new LabTestRepository();
        }

        public LabTestController(LabTestRepository labTestRepository)
        {
            this.labTestRepository = labTestRepository;
        }

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
    }
}
