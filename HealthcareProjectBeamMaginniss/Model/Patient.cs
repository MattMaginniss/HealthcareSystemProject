using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Patient
    {
        #region Properties

        public string FirstName { get; }

        public string LastName { get; }

        public DateTime Dob { get; }

        public string DobString => this.Dob.ToShortDateString();

        public string Address { get; }

        public string PhoneNo { get; }

        #endregion

        #region Constructors

        public Patient(string firstName, string lastName, DateTime dob, string address, string phoneNo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.Address = address;
            this.PhoneNo = phoneNo;
        }

        #endregion
    }
}