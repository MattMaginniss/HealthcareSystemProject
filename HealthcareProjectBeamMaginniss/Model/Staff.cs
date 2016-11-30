using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    /// <summary>
    ///     Represents a staff member
    /// </summary>
    public class Staff
    {
        #region Properties

        /// <summary>
        ///     Gets the staff identifier.
        /// </summary>
        /// <value>
        ///     The staff identifier.
        /// </value>
        public int StaffId { get; }

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
        ///     Gets the phone no.
        /// </summary>
        /// <value>
        ///     The phone no.
        /// </value>
        public string PhoneNo { get; }

        /// <summary>
        ///     Gets the type of the staff.
        /// </summary>
        /// <value>
        ///     The type of the staff.
        /// </value>
        public int StaffType { get; }

        /// <summary>
        ///     Gets the full name.
        /// </summary>
        /// <value>
        ///     The full name.
        /// </value>
        public string FullName => this.FirstName + " " + this.LastName;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Staff" /> class.
        /// </summary>
        /// <param name="staffId">The staff identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="phoneNo">The phone no.</param>
        /// <param name="staffType">Type of the staff.</param>
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