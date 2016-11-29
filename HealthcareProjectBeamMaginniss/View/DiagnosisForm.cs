using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.Model;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class DiagnosisForm : Form
    {
        public Appointment appt;
        
        public DiagnosisForm(Appointment appt)
        {
            InitializeComponent();

        }
    }
}
