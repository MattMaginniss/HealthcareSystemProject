using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    class DiagnosisController
    {
        private readonly DiagnosisRepository diagnosisReposity;

        public DiagnosisController()
        {
            this.diagnosisReposity = new DiagnosisRepository();
        }

        public DiagnosisController(DiagnosisRepository diagnosisRepository)
        {
            this.diagnosisReposity = diagnosisRepository;
        }

        public void Add(Diagnosis diagnosis)
        {
            this.diagnosisReposity.Add(diagnosis);
        }

        public Diagnosis GetById(int id)
        {
            return this.diagnosisReposity.GetById(id);
        }

        public IList<Diagnosis> GetAll()
        {
            return this.diagnosisReposity.GetAll();
        }

        public IList<Diagnosis> GetAllDiagnosisByAptID(int id)
        {
            return this.diagnosisReposity.GetAllDiagnosisByAptID(id);
        }
    }
}
