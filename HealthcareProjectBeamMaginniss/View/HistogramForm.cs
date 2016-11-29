using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class HistogramForm : Form
    {
        #region Data members

        private readonly PatientController pc;

        #endregion

        #region Constructors

        public HistogramForm()
        {
            this.InitializeComponent();
            this.pc = new PatientController();
            this.setupTrackBar();
            this.getData();
            this.labelYear.Text = Resources.HistogramForm_HistogramForm_Patients_born_after__ + this.trackBarYear.Value;
        }

        #endregion

        #region Methods

        private void setupTrackBar()
        {
            this.trackBarYear.Maximum = this.pc.GetMaxYear();
            this.trackBarYear.Minimum = this.pc.GetMinYear();
        }

        private void getData()
        {
            this.chart.Series[0].Points.Clear();
            this.chart.Series[0].Name = "Patient Birth Years";
            var dateDict = this.pc.GetHistogramData(this.trackBarYear.Value);
            foreach (var k in dateDict.Keys)
            {
                var point = this.chart.Series[0].Points.Add(dateDict[k]);
                point.AxisLabel = k + "";
            }
        }

        private void trackBarYear_Scroll(object sender, EventArgs e)
        {
            this.labelYear.Text = Resources.HistogramForm_HistogramForm_Patients_born_after__ + this.trackBarYear.Value;
            this.getData();
        }

        #endregion
    }
}