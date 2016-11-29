using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    /// <summary>
    ///     Controller to handle patient data between <see cref="PatientRepository" /> and the GUI
    /// </summary>
    public class PatientController
    {
        #region Data members

        private readonly PatientRepository pr;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="PatientController" /> class.
        /// </summary>
        public PatientController()
        {
            this.pr = new PatientRepository();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PatientController" /> class.
        /// </summary>
        /// <param name="pr">The PatientReposity to use.</param>
        public PatientController(PatientRepository pr)
        {
            this.pr = pr;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Adds the specified patient to the database
        /// </summary>
        /// <param name="patient">The patient to add.</param>
        public void Add(Patient patient)
        {
            this.pr.Add(patient);
        }

        public void Update(Patient patient)
        {
            this.pr.Update(patient);
        }

        /// <summary>
        ///     Gets the patient by patientID.
        /// </summary>
        /// <param name="id">The patientID.</param>
        /// <returns>The patient with the specified ID</returns>
        public Patient GetById(int id)
        {
            return this.pr.GetById(id);
        }

        /// <summary>
        ///     Gets all patients in the table.
        /// </summary>
        /// <returns>IList of all Patients</returns>
        public IList<Patient> GetAll()
        {
            return this.pr.GetAll();
        }

        public IList<Patient> GetPatientsByFirstName(string fName)
        {
            return this.pr.GetPatientsByFirstName(fName);
        }

        public IList<Patient> GetPatientsByLastName(string lName)
        {
            return this.pr.GetPatientsByLastName(lName);
        }

        public IList<Patient> GetPatientsByFullName(string fName, string lName)
        {
            return this.pr.GetPatientsByFullName(fName, lName);
        }

        public IList<Patient> GetPatientsByDateOfBirth(string dob)
        {
            return this.pr.GetPatientsByDateOfBirth(dob);
        }

        public IList<Patient> GetFirst30()
        {
            return this.pr.GetFirst30();
        }

        public string GetName(int id)
        {
            var name = this.pr.GetById(id).FullName ?? "";
            return name;
        }

        internal int GetMaxYear()
        {
            return this.pr.GetMaxYear();
        }

        internal int GetMinYear()
        {
            return this.pr.GetMinYear();
        }

        internal Dictionary<int, int> GetHistogramData(int minYear)
        {
            return this.pr.GetHistogramData(minYear);
        }

        #endregion
    }
}