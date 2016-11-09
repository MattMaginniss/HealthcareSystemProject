using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Staff
    {
        public int StaffId { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public DateTime Dob { get; }

        public string PhoneNo { get; }

        public int staffType { get;  }

        public string FullName => this.FirstName + " " + this.LastName;

        public Staff(int staffID, string firstName, string lastName, DateTime dob, string phoneNo, int staffType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.PhoneNo = phoneNo;
            this.staffType = staffType;
            this.StaffId = staffID;
        }

    }
}