using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Staff
    {
        #region Properties

        public int StaffId { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public DateTime Dob { get; }

        public string PhoneNo { get; }

        public int StaffType { get; }

        public string FullName => this.FirstName + " " + this.LastName;

        #endregion

        #region Constructors

        public Staff(int staffId, string firstName, string lastName, DateTime dob, string phoneNo, int staffType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.PhoneNo = phoneNo;
            this.StaffType = staffType;
            this.StaffId = staffId;
        }

        #endregion
    }
}