using System;
using System.Collections.Generic;
using System.Data;
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
            var pid = row.patientID;
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
            return new Patient(pid, fname, lname, bdate, sex, street1, street2, city, state, zip, country, phoneNo);
        }

        internal Dictionary<int,int> GetHistogramData(int minYear)
        {
            var adapter = new histogramOfPatientBirthYearTableAdapter();
            Dictionary<int, int> dateDict = new Dictionary<int, int>();
            foreach (cs3230f16bDataSet.histogramOfPatientBirthYearRow row in adapter.GetData(minYear).Rows) 
            {
                var year = row.Year;
                var count = (int)row._Patients_born_;
                dateDict.Add(year, count);
            }
            return dateDict;
        }

        internal int GetMinYear()
        {
            var adapter = new patientTableAdapter();
            using (adapter)
            {
                var oldest = adapter.GetData().Min(pat => pat.dateOfBirth);
                return oldest.Year;
            }
        }

        internal int GetMaxYear()
        {
            var adapter = new patientTableAdapter();
            using (adapter)
            {
                var youngest = adapter.GetData().Max(pat => pat.dateOfBirth);
                return youngest.Year;
            }
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
            var sex = patient.Sex.ToString();
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

        public void Update(Patient patient)
        {
            var adapter = new patientTableAdapter();
            DataRow patRow = null;
            using (adapter)
            {
                patRow = adapter.GetData().FirstOrDefault(pat => pat.patientID == patient.PatientId);
            }
            if (patRow != null)
            {
                patRow[1] = patient.FirstName;
                patRow[2] = patient.LastName;
                patRow[3] = patient.Dob;
                patRow[4] = patient.Sex.ToString();
                patRow[5] = patient.Street1;
                patRow[6] = patient.Street2;
                patRow[7] = patient.City;
                patRow[8] = patient.State;
                patRow[9] = patient.Zip;
                patRow[10] = patient.Country;
                patRow[11] = patient.PhoneNo;
                using (adapter)
                {
                    adapter.Update(patRow);
                }
            }
        }

        internal IList<Patient> GetFirst30()
        {
              var patientList = new List<Patient>();
            var adapter = new patientTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var patient = getPatientFromRow((cs3230f16bDataSet.patientRow) row);
                    patientList.Add(patient);
                    if(patientList.Count >= 30)
                    {
                        return patientList;
                    }
                }
            }
            return patientList;
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

        public IList<Patient> GetPatientsByFirstName(String fName)
        {
            var patientList = new List<Patient>();
            var adapter = new patientTableAdapter();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var patient = getPatientFromRow((cs3230f16bDataSet.patientRow)row);
                    if (patient.FirstName.ToLower().Equals(fName))
                    {
                        patientList.Add(patient);
                    }
                }
            }

            return patientList;
        }
        public IList<Patient> GetPatientsByLastName(String lName)
        {
            var patientList = new List<Patient>();
            var adapter = new patientTableAdapter();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var patient = getPatientFromRow((cs3230f16bDataSet.patientRow)row);
                    if (patient.LastName.ToLower().Equals(lName))
                    {
                        patientList.Add(patient);
                    }
                }
            }

            return patientList;
        }


        public IList<Patient> GetPatientsByFullName(String fName, String lName)
        {
            var patientList = new List<Patient>();
            var adapter = new patientTableAdapter();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var patient = getPatientFromRow((cs3230f16bDataSet.patientRow)row);
                    if (patient.FirstName.ToLower().Equals(fName) && patient.LastName.ToLower().Equals(lName))
                    {
                        patientList.Add(patient);
                    }
                }
            }

            return patientList;
        }

        public IList<Patient> GetPatientsByDateOfBirth(String dob)
        {
            var patientList = new List<Patient>();
            var adapter = new patientTableAdapter();

            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var patient = getPatientFromRow((cs3230f16bDataSet.patientRow)row);
                    if (patient.Dob.ToShortDateString().Equals(dob))
                    {
                        patientList.Add(patient);
                    }
                }
            }

            return patientList;
        }

        #endregion
    }
}