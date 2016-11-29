using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    class DiagnosisRepository : IRepository<Diagnosis>
    {
        public void Add(Diagnosis diagnosis)
        {
            var adapter = new diagnosisTableAdapter();
            var diagnosisId = diagnosis.diagnosisId;
            var diagnosisInformation = diagnosis.diagnosisInformation;
            var appointmentId = diagnosis.appointment_id;
            using (adapter)
            {
                adapter.Insert(diagnosisId, diagnosisInformation, appointmentId);
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
                    var appointment = getDiagnosisFromRow((cs3230f16bDataSet.diagnosisRow)row);
                    diagnosisList.Add(appointment);
                }
            }
            return diagnosisList;
        }

        public Diagnosis getDiagnosisFromRow(cs3230f16bDataSet.diagnosisRow row)
        {
            var diagnosisId = row.diagnosisID;
            var diagnosisInformation = row.diagnosisInformation;
            var appointmentId = row.appointment_id;
            return new Diagnosis(diagnosisId, diagnosisInformation, appointmentId);
        }
    }
}
