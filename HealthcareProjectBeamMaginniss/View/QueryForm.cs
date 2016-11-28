using HealthcareProjectBeamMaginniss.DAL.Controller;
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
    public partial class QueryForm : Form
    {
        LoginForm form;
        FreeSqlController fsc;
        public QueryForm(LoginForm form)
        {
            InitializeComponent();
            this.form = form;
            this.labelWelcome.Text += this.form.GetUsername();
            this.fsc = new FreeSqlController();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.form.Show();
            this.Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = fsc.RunQuery(this.textBoxQuery.Text);
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.Show();
        }
    }
}
