using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.View
{
    public partial class QueryForm : Form
    {
        #region Data members

        private readonly LoginForm form;
        private readonly FreeSqlController fsc;

        #endregion

        #region Constructors

        public QueryForm(LoginForm form)
        {
            this.InitializeComponent();
            this.form = form;
            this.labelWelcome.Text += this.form.GetUsername();
            this.fsc = new FreeSqlController();
        }

        #endregion

        #region Methods

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.form.Show();
            Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = this.fsc.RunQuery(this.textBoxQuery.Text);
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.Show();
        }

        #endregion
    }
}