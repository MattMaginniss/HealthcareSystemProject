using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Diagnosis
    {
        public int diagnosisId { get; }
        public string diagnosisInformation { get; }

        public int appointment_id { get; }

        public Boolean finalDiagnosis { get; }

        public Diagnosis(int diagnosisId, string diagnosisInformation, int appointment_id, Boolean finalDiagnosis)
        {
            this.diagnosisId = diagnosisId;
            this.diagnosisInformation = diagnosisInformation;
            this.appointment_id = appointment_id;
            this.finalDiagnosis = finalDiagnosis;
        }
    }
}
