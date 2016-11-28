using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class HistogramForm : Form
    {
        private readonly PatientController pc;

        public HistogramForm()
        {
            InitializeComponent();
            this.pc = new PatientController();
            this.getData();
        }

        private void getData()
        {
            this.chart.Series[0].Name = "Patient Birth Years";
            var patients = this.pc.GetAll();
            Dictionary<int, int> dateDict = new Dictionary<int, int>();
            foreach(Patient p in patients)
            {
                DateTime dob = p.Dob;
                var year = dob.Year;
                if (dateDict.Keys.Contains(year))
                {
                    dateDict[year]++;
                }
                else
                {
                    dateDict.Add(year, 1);
                }
            }

            foreach(int k in dateDict.Keys)
            {
                var point = this.chart.Series[0].Points.Add(dateDict[k]);
                point.AxisLabel = k+"";
            }

        }
    }
}
