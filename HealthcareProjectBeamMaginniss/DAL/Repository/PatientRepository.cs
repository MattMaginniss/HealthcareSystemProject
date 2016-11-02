using System;
using System.Collections.Generic;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    /// <summary>
    ///     Patient repository to interface directly with the datasource
    /// </summary>
    /// <seealso cref="HealthcareProjectBeamMaginniss.DAL.Interfaces.IRepository{Patient}" />
    public class PatientRepository : IRepository<Patient>
    {
        private Patient getPatientFromRow(cs3230f16bDataSet.patientRow row)
        {
            var fname = row.IsfirstNameNull() ? "" : row.firstName;
            var lname = row.IslastNameNull() ? "" : row.lastName;
            var bdate = row.IsdateOfBirthNull() ? DateTime.MinValue : row.dateOfBirth;
            var sex = row.IssexNull() ? ' ' : row.sex[0];
            var street1 = row.Isstreet1Null() ? "" : row.street1;
            var street2 = row.Isstreet2Null() ? "" : row.street2;
            var city = row.IscityNull() ? "" : row.city;
            var state = row.IsstateNull() ? "" : row.state;
            var zip = row.IszipNull() ? "" : row.zip;
            var country = row.IscountryNull() ? "" : row.country;
            var phoneNo = row.Is_phone_Null() ? "" : row._phone_;
            return new Patient(fname, lname, bdate, sex, street1, street2, city, state, zip, country, phoneNo);
        }

        #region Methods

        /// <summary>
        ///     Adds the specified patient to the database.
        /// </summary>
        /// <param name="patient">The patient to add.</param>
        public void Add(Patient patient)
        {
            var adapter = new patientTableAdapter();
            var fname = patient.FirstName;
            var lname = patient.LastName;
            var bdate = patient.Dob;
            var sex = patient.sex.ToString();
            var street1 = patient.Street1;
            var street2 = patient.Street2;
            var city = patient.City;
            var state = patient.State;
            var zip = patient.Zip;
            var country = patient.Country;
            var phoneNo = patient.PhoneNo;
            using (adapter)
            {
                adapter.Insert(fname, lname, bdate, sex, street1, street2, city, state, zip, country, phoneNo);
            }
        }

        /// <summary>
        ///     Gets the patient by patientID.
        /// </summary>
        /// <param name="id">The patientID.</param>
        /// <returns>Patient with specified patientID</returns>
        public Patient GetById(int id)
        {
            var adapter = new patientTableAdapter();
            using (adapter)
            {
                var patient = adapter.GetData().FirstOrDefault(pat => pat.patientID == id);
                return getPatientFromRow(patient);
            }
        }

        /// <summary>
        ///     Gets all patients.
        /// </summary>
        /// <returns>All patients</returns>
        public IList<Patient> GetAll()
        {
            var patientList = new List<Patient>();
            var adapter = new patientTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var patient = getPatientFromRow((cs3230f16bDataSet.patientRow) row);
                    patientList.Add(patient);
                }
            }
            return patientList;
        }

        #endregion
    }
}