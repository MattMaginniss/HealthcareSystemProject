using System;
using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
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

        internal int getMaxYear()
        {
            return this.pr.GetMaxYear();
        }

        internal int getMinYear()
        {
            return this.pr.GetMinYear();
        }

        internal Dictionary<int, int> GetHistogramData(int minYear)
        {
            return this.pr.GetHistogramData(minYear);
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

        public IList<Patient> GetPatientsByFirstName(String fName)
        {
            return this.pr.GetPatientsByFirstName(fName);
        }
        public IList<Patient> GetPatientsByLastName(String lName)
        {
            return this.pr.GetPatientsByLastName(lName);
        }
        public IList<Patient> GetPatientsByFullName(String fName, String lName)
        {
            return this.pr.GetPatientsByFullName(fName, lName);
        }

        public IList<Patient> GetPatientsByDateOfBirth(String dob)
        {
            return this.pr.GetPatientsByDateOfBirth(dob);
        }

        public IList<Patient> GetFirst30()
        {
            return this.pr.GetFirst30();
        }

        public string GetName(int id)
        {
            string name = this.pr.GetById(id).FullName  ?? "";
            return name;
        }
    }
}