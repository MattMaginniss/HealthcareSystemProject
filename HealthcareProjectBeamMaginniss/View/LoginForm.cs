using System;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.DAL.Controller;

namespace HealthcareProjectBeamMaginniss.View
{
    /// <summary>
    ///     Form for login. Serves as main form so is hidden on successful login
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        #region Data members

        private readonly LoginController login;
        private string username;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LoginForm" /> class.
        /// </summary>
        public LoginForm()
        {
            this.InitializeComponent();
            this.login = new LoginController();
        }

        #endregion

        private void attemptLogin()
        {
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            this.passwordTextBox.Text = "";

            if (this.login.CheckLogin(username, password))
            {
                this.successfulLogin();
            }
            else
            {
                this.wrongLoginLabel.Visible = true;
            }
        }

        public void logout()
        {
            this.Show();
        }

        public string getUsername()
        {
            return this.username;
        }

        private void successfulLogin()
        {
            this.username = this.usernameTextBox.Text.Trim();
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
            var mainform = new MainForm(this);
            mainform.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.attemptLogin();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.attemptLogin();
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.attemptLogin();
            }
        }
    }
}