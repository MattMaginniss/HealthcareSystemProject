using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    public class PatientController
    {
        private readonly PatientRepository pr;

        public PatientController()
        {
            this.pr = new PatientRepository();
        }

        public PatientController(PatientRepository pr)
        {
            this.pr = pr;
        }

        public void Add(Patient patient)
        {
            this.pr.Add(patient);
        }

        public Patient GetById(int id)
        {
            return this.pr.GetById(id);
        }

        public IList<Patient> GetAll()
        {
            return this.pr.GetAll();
        }
    }
}
