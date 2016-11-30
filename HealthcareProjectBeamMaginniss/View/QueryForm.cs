using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;
using HealthcareProjectBeamMaginniss.Properties;

namespace HealthcareProjectBeamMaginniss.View
{
    /// <summary>
    ///     Query interface for an administrator to execute queries with.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class QueryForm : Form
    {
        #region Data members

        private readonly LoginForm form;
        private readonly FreeSqlController fsc;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="QueryForm" /> class.
        /// </summary>
        /// <param name="form">The login form.</param>
        public QueryForm(LoginForm form)
        {
            this.InitializeComponent();
            this.form = form;
            this.labelWelcome.Text += this.form.GetUsername();
            this.fsc = new FreeSqlController();
        }

        #endregion

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.form.Show();
            Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView.DataSource = this.fsc.RunQuery(this.textBoxQuery.Text);
            }
            catch (Exception exc)
            {
                this.handleError(exc);
            }
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.Show();
        }

        private void handleError(Exception exc)
        {
            MessageBox.Show(null,
                Resources.QueryForm_handleError_ +
                exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
}