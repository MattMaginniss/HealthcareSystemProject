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

        /// <summary>
        ///     Adds the specified patient to the database
        /// </summary>
        /// <param name="patient">The patient to add.</param>
        public void Add(Patient patient)
        {
            this.pr.Add(patient);
        }

        /// <summary>
        ///     Updates the specified patient.
        /// </summary>
        /// <param name="patient">The patient.</param>
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

        /// <summary>
        ///     Gets the patients by the first name.
        /// </summary>
        /// <param name="fName">First name</param>
        /// <returns>The matching patients</returns>
        public IList<Patient> GetPatientsByFirstName(string fName)
        {
            return this.pr.GetPatientsByFirstName(fName);
        }

        /// <summary>
        ///     Gets the patients by the last name.
        /// </summary>
        /// <param name="lName">Last name</param>
        /// <returns>The matching patients</returns>
        public IList<Patient> GetPatientsByLastName(string lName)
        {
            return this.pr.GetPatientsByLastName(lName);
        }

        /// <summary>
        ///     Gets the patients by both names.
        /// </summary>
        /// <param name="fName">First name</param>
        /// <param name="lName">Last name</param>
        /// <returns>The matching patients</returns>
        public IList<Patient> GetPatientsByFullName(string fName, string lName)
        {
            return this.pr.GetPatientsByFullName(fName, lName);
        }

        /// <summary>
        ///     Gets the patients by date of birth.
        /// </summary>
        /// <param name="dob">The dob.</param>
        /// <returns></returns>
        public IList<Patient> GetPatientsByDateOfBirth(string dob)
        {
            return this.pr.GetPatientsByDateOfBirth(dob);
        }

        /// <summary>
        ///     Gets the first 30 patients for display purposes.
        /// </summary>
        /// <returns>First 30 patients</returns>
        public IList<Patient> GetFirst30()
        {
            return this.pr.GetFirst30();
        }

        /// <summary>
        ///     Gets the name of the patient by ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The patient's full name if found, or an empty string if not</returns>
        public string GetName(int id)
        {
            var name = this.pr.GetById(id).FullName ?? "";
            return name;
        }

        /// <summary>
        ///     Gets the largest year as pertains to patient DOB.
        /// </summary>
        /// <returns>The year of the DOB of the youngest patient</returns>
        public int GetMaxYear()
        {
            return this.pr.GetMaxYear();
        }

        /// <summary>
        ///     Gets the smallest year as pertains to patient DOB.
        /// </summary>
        /// <returns>The year of the DOB of the oldest patient</returns>
        public int GetMinYear()
        {
            return this.pr.GetMinYear();
        }

        /// <summary>
        ///     Gets the data for a birth by years histogram
        /// </summary>
        /// <param name="minYear">The oldest year to include in the histogram, eclusive.</param>
        /// <returns>(int,int) typed Dictionary representing (year, # of patients born in that year)</returns>
        public Dictionary<int, int> GetHistogramData(int minYear)
        {
            return this.pr.GetHistogramData(minYear);
        }

        /// <summary>
        ///     Gets the patients by country.
        /// </summary>
        /// <param name="countryQuery">The country to query for.</param>
        /// <returns></returns>
        public IList<Patient> GetPatientsByCountry(string countryQuery)
        {
            return this.pr.GetPatientsByCountry(countryQuery);
        }
    }
}