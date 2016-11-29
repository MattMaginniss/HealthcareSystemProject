using System.Collections.Generic;
using HealthcareProjectBeamMaginniss.DAL.Repository;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    public class StaffController
    {
        private readonly StaffRepository staffRepository;

        public StaffController()
        {
            this.staffRepository = new StaffRepository();
        }

        public StaffController(StaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }

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

        public List<Staff> GetDoctors()
        {
            return this.staffRepository.GetDoctors();
        }

        public List<Staff> GetNurses()
        {
            return this.staffRepository.GetNurses();
        }

        public string GetName(int id)
        {
            var staff = this.staffRepository.GetById(id);
            if(staff == null)
            {
                return "";
            }
            return staff.FullName;
        }
    }
}