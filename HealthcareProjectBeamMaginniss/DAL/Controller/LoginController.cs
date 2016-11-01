using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthcareProjectBeamMaginniss.DAL.Repository;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    internal class LoginController
    {
        private readonly Login login;

        public LoginController(Login login)
        {
            this.login = login;
        }

        public LoginController()
        {
            this.login = new Login();
        }

        public bool CheckLogin(string userName, string password)
        {
            return this.login.CheckLogin(userName, password);
        }
    }
}
