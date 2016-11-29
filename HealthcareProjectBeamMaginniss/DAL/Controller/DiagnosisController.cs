using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    public class DiagnosisController
    {
        #region Data members

        private readonly DiagnosisRepository diagnosisReposity;

        #endregion

        #region Constructors

        public DiagnosisController()
        {
            this.diagnosisReposity = new DiagnosisRepository();
        }

        public DiagnosisController(DiagnosisRepository diagnosisRepository)
        {
            this.diagnosisReposity = diagnosisRepository;
        }

        #endregion

        #region Methods

        public void Add(Diagnosis diagnosis)
        {
            this.diagnosisReposity.Add(diagnosis);
        }

        public void Update(Diagnosis diagnosis)
        {
            this.diagnosisReposity.Update(diagnosis);
        }

        public Diagnosis GetById(int id)
        {
            return this.diagnosisReposity.GetById(id);
        }

        public IList<Diagnosis> GetAll()
        {
            return this.diagnosisReposity.GetAll();
        }

        public IList<Diagnosis> GetAllDiagnosisByAptId(int id)
        {
            return this.diagnosisReposity.GetAllDiagnosisByAptId(id);
        }

        public IList<Diagnosis> GetAllDiagnosisByPatientId(int id)
        {
            return this.diagnosisReposity.GetAllDiagnosisByPatientId(id);
        }

        #endregion
    }
}