using System;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.Model
{
    /// <summary>
    ///     Represents a lab test order made by a doctor
    /// </summary>
    public class LabTestOrder
    {
        #region Properties

        /// <summary>
        ///     Gets the test ordered identifier.
        /// </summary>
        /// <value>
        ///     The test ordered identifier.
        /// </value>
        public int TestOrderedId { get; }

        /// <summary>
        ///     Gets the test identifier.
        /// </summary>
        /// <value>
        ///     The test identifier.
        /// </value>
        public int TestId { get; }

        /// <summary>
        ///     Gets the name of the test.
        /// </summary>
        /// <value>
        ///     The name of the test.
        /// </value>
        public string TestName => new LabTestController().GetName(this.TestId);

        /// <summary>
        ///     Gets the doctor identifier.
        /// </summary>
        /// <value>
        ///     The doctor identifier.
        /// </value>
        public int DoctorId { get; }

        /// <summary>
        ///     Gets the name of the doctor.
        /// </summary>
        /// <value>
        ///     The name of the doctor.
        /// </value>
        public string DoctorName => new StaffController().GetName(this.DoctorId);

        /// <summary>
        ///     Gets the test date.
        /// </summary>
        /// <value>
        ///     The test date.
        /// </value>
        public DateTime TestDate { get; }

        /// <summary>
        ///     Gets or sets the test result identifier.
        /// </summary>
        /// <value>
        ///     The test result identifier.
        /// </value>
        public int TestResultId { get; set; }

        /// <summary>
        ///     Gets a value indicating whether this instance has result.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance has result; otherwise, <c>false</c>.
        /// </value>
        public bool HasResult => this.TestResultId > 0;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LabTestOrder" /> class.
        /// </summary>
        /// <param name="testOrderedId">The test ordered identifier.</param>
        /// <param name="testId">The test identifier.</param>
        /// <param name="doctorId">The doctor identifier.</param>
        /// <param name="testDate">The test date.</param>
        public LabTestOrder(int testOrderedId, int testId, int doctorId, DateTime testDate)
        {
            this.TestOrderedId = testOrderedId;
            this.TestId = testId;
            this.DoctorId = doctorId;
            this.TestDate = testDate;
            this.TestResultId = -1;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LabTestOrder" /> class.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        /// <param name="doctorId">The doctor identifier.</param>
        /// <param name="testDate">The test date.</param>
        public LabTestOrder(int testId, int doctorId, DateTime testDate)
        {
            this.TestId = testId;
            this.DoctorId = doctorId;
            this.TestDate = testDate;
            this.TestResultId = -1;
        }

        #endregion
    }
}