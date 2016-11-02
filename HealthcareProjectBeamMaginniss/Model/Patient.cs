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
        /// Gets the sex.
        /// </summary>
        /// <value>
        /// The sex.
        /// </value>
        public char sex { get; }

        /// <summary>
        ///     Gets the first line of the address.
        /// </summary>
        /// <value>
        ///     The first line of the address.
        /// </value>
        public string Street1 { get; }

        /// <summary>
        ///     Gets the second line of the address.
        /// </summary>
        /// <value>
        ///     The second line of the address.
        /// </value>
        public string Street2 { get; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; }

        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string Zip { get;  }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; }

        /// <summary>
        ///     Gets the phone no.
        /// </summary>
        /// <value>
        ///     The phone no.
        /// </value>
        public string PhoneNo { get; }

        #endregion

        #region Constructors

        public Patient(string firstName, string lastName, DateTime dob, char sex, string street1, string street2, string city, string state, string zip, string country, string phoneNo)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            this.sex = sex;
            Street1 = street1;
            Street2 = street2;
            City = city;
            State = state;
            this.Zip = zip;
            Country = country;
            PhoneNo = phoneNo;
        }

        #endregion
    }
}