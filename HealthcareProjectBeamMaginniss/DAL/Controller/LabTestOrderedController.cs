using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    class LabTestOrderedController
    {
        private readonly LabTestOrderedRepository labTestOrderedRepository;
        
        public LabTestOrderedController()
        {
            this.labTestOrderedRepository = new LabTestOrderedRepository();
        }

        public LabTestOrderedController(LabTestOrderedRepository labTestOrderedRepository)
        {
            this.labTestOrderedRepository = labTestOrderedRepository;
        }


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

        public int GetLastID()
        {
            return this.labTestOrderedRepository.GetLastID();
        }
    }
}
