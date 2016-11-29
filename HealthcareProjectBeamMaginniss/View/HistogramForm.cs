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
            this.setupTrackBar();
            this.getData();
            this.labelYear.Text = "Patients born after: " + this.trackBarYear.Value;

        }

        private void setupTrackBar()
        {
            this.trackBarYear.Maximum = this.pc.getMaxYear();
            this.trackBarYear.Minimum = this.pc.getMinYear();

        }

        private void getData()
        {
            this.chart.Series[0].Points.Clear();
            this.chart.Series[0].Name = "Patient Birth Years";
            var dateDict = this.pc.GetHistogramData(this.trackBarYear.Value);
            foreach(int k in dateDict.Keys)
            {
                var point = this.chart.Series[0].Points.Add(dateDict[k]);
                point.AxisLabel = k+"";
            }

        }

        private void trackBarYear_Scroll(object sender, EventArgs e)
        {
            this.labelYear.Text = "Patients born after: " + this.trackBarYear.Value;
            this.getData();
        }
    }
}
