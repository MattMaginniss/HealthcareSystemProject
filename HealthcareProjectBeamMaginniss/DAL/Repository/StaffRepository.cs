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
        #region Methods

        /// <summary>
        ///     Adds the specified staff to the database.
        /// </summary>
        /// <param name="staff">The staff to add.</param>
        public void Add(Staff staff)
        {
            var adapter = new staffTableAdapter();
            var fname = staff.FirstName;
            var lname = staff.LastName;
            var bdate = staff.Dob;
            var phoneNo = staff.PhoneNo;
            var staffType = staff.StaffType;
            try
            {
                using (adapter)
                {
                    adapter.Insert(fname, lname, bdate, phoneNo, staffType);
                }
            }
            catch (Exception e)
            {
                throw e;
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
            try
            {
                using (adapter)
                {
                    try
                    {
                        var staff = adapter.GetData().Where(st => st.staffID == id).First();
                        return this.getStaffFromRow(staff);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
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
            try
            {
                using (adapter)
                {
                    foreach (var row in adapter.GetData().Rows)
                    {
                        var staff = this.getStaffFromRow((cs3230f16bDataSet.staffRow) row);
                        staffList.Add(staff);
                    }
                }
                return staffList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private Staff getStaffFromRow(cs3230f16bDataSet.staffRow row)
        {
            if (row == null)
            {
                return null;
            }
            var staffId = row.staffID;
            var fname = row.firstName ?? "";
            var lname = row.lastName ?? "";
            var bdate = row.dateOfBirth;
            var phoneNo = row._phone_ ?? "";
            var staffType = row.staffType;
            return new Staff(staffId, fname, lname, bdate, phoneNo, staffType);
        }

        public List<Staff> GetDoctors()
        {
            var staffList = new List<Staff>();
            var adapter = new staffTableAdapter();
            try
            {
                using (adapter)
                {
                    var doctors = adapter.GetData().Where(st => st.staffType == 3);
                    foreach (var doctor in doctors)
                    {
                        var staff = this.getStaffFromRow(doctor);
                        staffList.Add(staff);
                    }
                }
                return staffList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Staff> GetNurses()
        {
            var staffList = new List<Staff>();
            var adapter = new staffTableAdapter();
            try
            {
                using (adapter)
                {
                    var nurses = adapter.GetData().Where(st => st.staffType == 2);
                    foreach (var nurse in nurses)
                    {
                        var staff = this.getStaffFromRow(nurse);
                        staffList.Add(staff);
                    }
                }
                return staffList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}