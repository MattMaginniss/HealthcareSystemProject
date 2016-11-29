using System;

namespace HealthcareProjectBeamMaginniss.Model
{
    /// <summary>
    ///     Patient class to handle patient data
    /// </summary>
    public class Patient
    {
        #region Properties

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

        public Patient(int pid, string firstName, string lastName, DateTime dob, char sex, string street1,
            string street2, string city, string state, string zip, string country, string phoneNo)
        {
            this.PatientId = pid;
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