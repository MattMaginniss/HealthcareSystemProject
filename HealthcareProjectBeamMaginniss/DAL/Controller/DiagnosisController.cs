using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    /// <summary>
    ///     Controls interaction between Diagnosis Repo and View
    /// </summary>
    public class DiagnosisController
    {
        #region Data members

        private readonly DiagnosisRepository diagnosisReposity;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DiagnosisController" /> class.
        /// </summary>
        public DiagnosisController()
        {
            this.diagnosisReposity = new DiagnosisRepository();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DiagnosisController" /> class.
        /// </summary>
        /// <param name="diagnosisRepository">The diagnosis repository.</param>
        internal DiagnosisController(DiagnosisRepository diagnosisRepository)
        {
            this.diagnosisReposity = diagnosisRepository;
        }

        #endregion

        /// <summary>
        ///     Adds the specified diagnosis.
        /// </summary>
        /// <param name="diagnosis">The diagnosis.</param>
        public void Add(Diagnosis diagnosis)
        {
            this.diagnosisReposity.Add(diagnosis);
        }

        /// <summary>
        ///     Updates the specified diagnosis.
        /// </summary>
        /// <param name="diagnosis">The diagnosis.</param>
        public void Update(Diagnosis diagnosis)
        {
            this.diagnosisReposity.Update(diagnosis);
        }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The Identified Diagnosis</returns>
        public Diagnosis GetById(int id)
        {
            return this.diagnosisReposity.GetById(id);
        }

        /// <summary>
        ///     Gets all diagnoses.
        /// </summary>
        /// <returns>All diagnoses</returns>
        public IList<Diagnosis> GetAll()
        {
            return this.diagnosisReposity.GetAll();
        }

        /// <summary>
        ///     Gets all diagnosis by apt identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Diagnoses with the supplied appointment ID</returns>
        public IList<Diagnosis> GetAllDiagnosisByAptId(int id)
        {
            return this.diagnosisReposity.GetAllDiagnosisByAptId(id);
        }

        /// <summary>
        ///     Gets all diagnosis by patient identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Diagnoses with the supplied patient ID</returns>
        public IList<Diagnosis> GetAllDiagnosisByPatientId(int id)
        {
            return this.diagnosisReposity.GetAllDiagnosisByPatientId(id);
        }
    }
}