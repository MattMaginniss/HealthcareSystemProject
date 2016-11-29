using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    public class DiagnosisRepository : IRepository<Diagnosis>
    {
        public void Add(Diagnosis diagnosis)
        {
            var adapter = new diagnosisTableAdapter();
            var diagnosisId = diagnosis.diagnosisId;
            var diagnosisInformation = diagnosis.diagnosisInformation;
            var appointmentId = diagnosis.appointment_id;
            Boolean finalDiagnosis = diagnosis.finalDiagnosis;
            using (adapter)
            {
                byte finalDiaByte = 0;
                if (finalDiagnosis)
                {
                    finalDiaByte = 1;
                }
                adapter.Insert(diagnosisId, diagnosisInformation, appointmentId, finalDiaByte);
            }
        }

        public void Update(Diagnosis diagnosis)
        {
            var adapter = new diagnosisTableAdapter();
            DataRow diaRow = null;
            using (adapter)
            {
                diaRow = adapter.GetData().FirstOrDefault(dia => dia.diagnosisID == diagnosis.diagnosisId);
            }
            if (diaRow != null)
            {
                diaRow[1] = diagnosis.diagnosisInformation;
                diaRow[3] = diagnosis.finalDiagnosis;
                using (adapter)
                {
                    adapter.Update(diaRow);
                }
            }
        }

        public Diagnosis GetById(int id)
        {
            var adapter = new diagnosisTableAdapter();
            using (adapter)
            {
                var diagnosis = adapter.GetData().FirstOrDefault(dia => dia.diagnosisID == id);
                return this.getDiagnosisFromRow(diagnosis);
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
                    var diagnosis = getDiagnosisFromRow((cs3230f16bDataSet.diagnosisRow)row);
                    diagnosisList.Add(diagnosis);
                }
            }
            return diagnosisList;
        }

        public IList<Diagnosis> GetAllDiagnosisByAptID(int aptID)
        {
            var diagnosisList = new List<Diagnosis>();
            var adapter = new diagnosisTableAdapter();
            using (adapter)
            {
                foreach (var row in adapter.GetData().Rows)
                {
                    var diagnosis = getDiagnosisFromRow((cs3230f16bDataSet.diagnosisRow)row);
                    if (diagnosis.appointment_id.Equals(aptID))
                    {
                        diagnosisList.Add(diagnosis);
                    }
                }
            }
            return diagnosisList;
        }

        public Diagnosis getDiagnosisFromRow(cs3230f16bDataSet.diagnosisRow row)
        {
            var diagnosisId = row.diagnosisID;
            var diagnosisInformation = row.diagnosisInformation;
            var appointmentId = row.appointment_id;
            var finalDiagnosis = row.finalDiagnosis;
            return new Diagnosis(diagnosisId, diagnosisInformation, appointmentId, finalDiagnosis);
        }
    }
}
