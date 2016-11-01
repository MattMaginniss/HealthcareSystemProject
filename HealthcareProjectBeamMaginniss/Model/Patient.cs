using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    /// <summary>
    ///     Patient class to handle patient data
    /// </summary>
    public class Patient
    {
        #region Properties

        /// <summary>
        ///     Gets the first name.
        /// </summary>
        /// <value>
        ///     The first name.
        /// </value>
        public string FirstName { get; }

        /// <summary>
        ///     Gets the last name.
        /// </summary>
        /// <value>
        ///     The last name.
        /// </value>
        public string LastName { get; }

        /// <summary>
        ///     Gets the dob.
        /// </summary>
        /// <value>
        ///     The dob.
        /// </value>
        public DateTime Dob { get; }

        /// <summary>
        ///     Gets the Date of Birth as string.
        /// </summary>
        /// <value>
        ///     The dob string.
        /// </value>
        public string DobString => this.Dob.ToShortDateString();

        /// <summary>
        ///     Gets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        public string Address { get; }

        /// <summary>
        ///     Gets the phone no.
        /// </summary>
        /// <value>
        ///     The phone no.
        /// </value>
        public string PhoneNo { get; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Patient" /> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dob">The date of birth.</param>
        /// <param name="address">The address.</param>
        /// <param name="phoneNo">The phone no.</param>
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