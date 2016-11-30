using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    /// <summary>
    ///     Controller to handle patient data between <see cref="StaffRepository" /> and the GUI
    /// </summary>
    public class StaffController
    {
        #region Data members

        private readonly StaffRepository staffRepository;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="StaffController" /> class.
        /// </summary>
        public StaffController()
        {
            this.staffRepository = new StaffRepository();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="StaffController" /> class.
        /// </summary>
        /// <param name="staffRepository">The staff repository.</param>
        public StaffController(StaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }

        #endregion

        /// <summary>
        ///     Adds the specified staff.
        /// </summary>
        /// <param name="staff">The staff.</param>
        public void Add(Staff staff)
        {
            this.staffRepository.Add(staff);
        }

        /// <summary>
        ///     Gets the patient by patientID.
        /// </summary>
        /// <param name="id">The patientID.</param>
        /// <returns>Patient with specified patientID</returns>
        public Staff GetById(int id)
        {
            return this.staffRepository.GetById(id);
        }

        /// <summary>
        ///     Gets all patients.
        /// </summary>
        /// <returns>All patients</returns>
        public IList<Staff> GetAll()
        {
            return this.staffRepository.GetAll();
        }

        /// <summary>
        ///     Gets the doctors.
        /// </summary>
        /// <returns>All doctor staff</returns>
        public List<Staff> GetDoctors()
        {
            return this.staffRepository.GetDoctors();
        }

        /// <summary>
        ///     Gets the nurses.
        /// </summary>
        /// <returns>All nurse staff</returns>
        public List<Staff> GetNurses()
        {
            return this.staffRepository.GetNurses();
        }

        /// <summary>
        ///     Gets the name of the supplied staff member.
        /// </summary>
        /// <param name="id">The staffID.</param>
        /// <returns>The staff member's full name if found, or an empty string if not</returns>
        public string GetName(int id)
        {
            var staff = this.staffRepository.GetById(id);
            return staff == null ? "" : staff.FullName;
        }
    }
}