using HealthcareProjectBeamMaginniss.DAL.Repository;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    /// <summary>
    ///     Controller for the Login class to handle login requests
    /// </summary>
    internal class LoginController
    {
        #region Data members

        private readonly Login login;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LoginController" /> class.
        /// </summary>
        /// <param name="login">The login.</param>
        public LoginController(Login login)
        {
            this.login = login;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LoginController" /> class.
        /// </summary>
        public LoginController()
        {
            this.login = new Login();
        }

        #endregion

        /// <summary>
        ///     Checks if the login is valid.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if username and password are a valid login</returns>
        public bool CheckLogin(string userName, string password)
        {
            return this.login.CheckLogin(userName, password);
        }

        public string GetName(string userName)
        {
            return this.login.GetNameByUsername(userName);
        }
    }
}