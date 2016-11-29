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
    public class StaffRepository : IRepository<Staff>
    {
        private Staff getStaffFromRow(cs3230f16bDataSet.staffRow row)
        {
            if(row == null)
            {
                return null;
            }
            var staffId = row.staffID;
            var fname = row.firstName ?? "";
            var lname = row.lastName ?? "";
            var bdate = row.dateOfBirth;
            var phoneNo = row._phone_?? "";
            var staffType = row.staffType;
            return new Staff(staffId, fname, lname, bdate, phoneNo, staffType);
        }

        #region Methods

        /// <summary>
        ///     Adds the specified patient to the database.
        /// </summary>
        /// <param name="patient">The patient to add.</param>
        public void Add(Staff staff)
        {
            var adapter = new staffTableAdapter();
            var fname = staff.FirstName;
            var lname = staff.LastName;
            var bdate = staff.Dob;
            var phoneNo = staff.PhoneNo;
            var staffType = staff.staffType;
            using (adapter)
            {
                adapter.Insert(fname, lname, bdate, phoneNo, staffType);
            }
        }

        /// <summary>
        ///     Gets the patient by patientID.
        /// </summary>
        /// <param name="id">The patientID.</param>
        /// <returns>Patient with specified patientID</returns>
        public Staff GetById(int id)
        {
            var adapter = new staffTableAdapter();
            using (adapter)
            {
                var staff = adapter.GetData().FirstOrDefault(st => st.staffID == id);
                return getStaffFromRow(staff);
            }
        }

        /// <summary>
        ///     Gets all patients.
        /// </summary>
        /// <returns>All patients</returns>
        public IList<Staff> GetAll()
        {
            var staffList = new List<Staff>();
            var adapter = new staffTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var staff = getStaffFromRow((cs3230f16bDataSet.staffRow) row);
                    staffList.Add(staff);
                }
            }
            return staffList;
        }

        public List<Staff> GetDoctors()
        {
            var staffList = new List<Staff>();
            var adapter = new staffTableAdapter();
            using (adapter)
            {
                var doctors = adapter.GetData().Where(st => st.staffType == 3);
                foreach (var doctor in doctors)
                {
                    var staff = getStaffFromRow((cs3230f16bDataSet.staffRow)doctor);
                    staffList.Add(staff);
                }
            }
            return staffList;
        }

        public List<Staff> GetNurses()
        {
            var staffList = new List<Staff>();
            var adapter = new staffTableAdapter();
            using (adapter)
            {
                var nurses = adapter.GetData().Where(st => st.staffType == 2);
                foreach (var nurse in nurses)
                {
                    var staff = getStaffFromRow((cs3230f16bDataSet.staffRow)nurse);
                    staffList.Add(staff);
                }
            }
            return staffList;
        }

        #endregion
    }
}