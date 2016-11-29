using System.Collections.Generic;
using System.Data;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    public class DiagnosisRepository : IRepository<Diagnosis>
    {
        #region Methods

        public void Add(Diagnosis diagnosis)
        {
            var adapter = new diagnosisTableAdapter();
            var diagnosisInformation = diagnosis.DiagnosisInformation;
            var appointmentId = diagnosis.AppointmentId;
            var finalDiagnosis = diagnosis.FinalDiagnosis;
            using (adapter)
            {
                byte finalDiaByte = 0;
                if (finalDiagnosis)
                {
                    finalDiaByte = 1;
                }
                adapter.Insert(diagnosisInformation, appointmentId, finalDiaByte);
            }
        }

        public Diagnosis GetById(int id)
        {
            var adapter = new diagnosisTableAdapter();
            using (adapter)
            {
                var diagnosis = adapter.GetData().FirstOrDefault(dia => dia.diagnosisID == id);
                return this.GetDiagnosisFromRow(diagnosis);
            }
        }

        public IList<Diagnosis> GetAll()
        {
            var diagnosisList = new List<Diagnosis>();
            var adapter = new diagnosisTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var diagnosis = this.GetDiagnosisFromRow((cs3230f16bDataSet.diagnosisRow) row);
                    diagnosisList.Add(diagnosis);
                }
            }
            return diagnosisList;
        }

        public void Update(Diagnosis diagnosis)
        {
            var adapter = new diagnosisTableAdapter();
            DataRow diaRow = null;
            using (adapter)
            {
                diaRow = adapter.GetData().FirstOrDefault(dia => dia.diagnosisID == diagnosis.DiagnosisId);
            }
            if (diaRow != null)
            {
                diaRow[1] = diagnosis.DiagnosisInformation;
                diaRow[3] = diagnosis.FinalDiagnosis;
                using (adapter)
                {
                    adapter.Update(diaRow);
                }
            }
        }

        public IList<Diagnosis> GetAllDiagnosisByAptId(int aptId)
        {
            var diagnosisList = new List<Diagnosis>();
            var adapter = new diagnosisTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var diagnosis = this.GetDiagnosisFromRow((cs3230f16bDataSet.diagnosisRow) row);
                    if (diagnosis.AppointmentId.Equals(aptId))
                    {
                        diagnosisList.Add(diagnosis);
                    }
                }
            }
            return diagnosisList;
        }

        public Diagnosis GetDiagnosisFromRow(cs3230f16bDataSet.diagnosisRow row)
        {
            var diagnosisId = row.diagnosisID;
            var diagnosisInformation = row.diagnosisInformation;
            var appointmentId = row.appointment_id;
            var finalDiagnosis = row.finalDiagnosis;
            return new Diagnosis(diagnosisId, diagnosisInformation, appointmentId, finalDiagnosis);
        }

        #endregion
    }
}