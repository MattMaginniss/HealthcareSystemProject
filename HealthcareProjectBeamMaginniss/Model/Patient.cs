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
        ///     Gets the patient identifier.
        /// </summary>
        /// <value>
        ///     The patient identifier.
        /// </value>
        public int PatientId { get; }

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
        ///     Gets the full name.
        /// </summary>
        /// <value>
        ///     The full name.
        /// </value>
        public string FullName => this.FirstName + " " + this.LastName;

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
        ///     Gets the sex.
        /// </summary>
        /// <value>
        ///     The sex.
        /// </value>
        public char Sex { get; }

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
        ///     Gets the city.
        /// </summary>
        /// <value>
        ///     The city.
        /// </value>
        public string City { get; }

        /// <summary>
        ///     Gets the state.
        /// </summary>
        /// <value>
        ///     The state.
        /// </value>
        public string State { get; }

        /// <summary>
        ///     Gets the zip.
        /// </summary>
        /// <value>
        ///     The zip.
        /// </value>
        public string Zip { get; }

        /// <summary>
        ///     Gets the country.
        /// </summary>
        /// <value>
        ///     The country.
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

        /// <summary>
        ///     Initializes a new instance of the <see cref="Patient" /> class.
        /// </summary>
        /// <param name="pid">The pid.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="sex">The sex.</param>
        /// <param name="street1">The street1.</param>
        /// <param name="street2">The street2.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="country">The country.</param>
        /// <param name="phoneNo">The phone no.</param>
        public Patient(int pid, string firstName, string lastName, DateTime dob, char sex, string street1,
            string street2, string city, string state, string zip, string country, string phoneNo)
            : this(firstName, lastName, dob, sex, street1, street2, city, state, zip, country, phoneNo)
        {
            this.PatientId = pid;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Patient" /> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="sex">The sex.</param>
        /// <param name="street1">The street1.</param>
        /// <param name="street2">The street2.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="country">The country.</param>
        /// <param name="phoneNo">The phone no.</param>
        public Patient(string firstName, string lastName, DateTime dob, char sex, string street1, string street2,
            string city, string state, string zip, string country, string phoneNo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.Sex = sex;
            this.Street1 = street1;
            this.Street2 = street2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
            this.PhoneNo = phoneNo;
        }

        #endregion
    }
}