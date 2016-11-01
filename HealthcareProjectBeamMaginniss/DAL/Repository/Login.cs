using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;
using MySql.Data.MySqlClient;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class Login : ILogin
    {
        #region Data members

        private readonly string connectionLabel;

        #endregion

        #region Constructors

        public Login(string connLabel = "MySqlDbConnection")
        {
            this.connectionLabel = connLabel;
        }

        #endregion

        #region Methods

        public bool CheckLogin(string userName, string password)
        {
            var adapter = new staff_credentialsTableAdapter();
            using (adapter)
            {
                try
                {
                    var staffCredentialsRow = adapter.GetData().FirstOrDefault(login => login.username.Equals(userName));
                    if (staffCredentialsRow == null)
                    {
                        return false;
                    }
                    var pword = staffCredentialsRow.password;
                    return (pword.Equals(password));
                }
                catch (Exception)
                { 
                    return false;
                }
            }
        }

        #endregion
    }
}