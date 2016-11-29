using System;
using System.Linq;
using HealthcareProjectBeamMaginniss.cs3230f16bDataSetTableAdapters;
using HealthcareProjectBeamMaginniss.DAL.Interfaces;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    /// <summary>
    ///     Login class to handle login data requests
    /// </summary>
    /// <seealso cref="HealthcareProjectBeamMaginniss.DAL.Interfaces.ILogin" />
    internal class Login : ILogin
    {
        #region Methods

        /// <summary>
        ///     Checks if the login is valid.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if valid login, false otherwise</returns>
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
                    return pword.Equals(password);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string GetNameByUsername(string userName)
        {
            var loginAdapter = new staff_credentialsTableAdapter();
            using (loginAdapter)
            {
                try
                {
                    var staffCredentialsRow =
                        loginAdapter.GetData().FirstOrDefault(login => login.username.Equals(userName));
                    if (staffCredentialsRow != null)
                    {
                        var id = staffCredentialsRow.staff_staffID;
                        var staffadapter = new staffTableAdapter();
                        using (staffadapter)
                        {
                            var staffRow = staffadapter.GetData().FirstOrDefault(staff => staff.staffID == id);
                            if (staffRow != null)
                            {
                                return staffRow.firstName + " " + staffRow.lastName;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public int GetStaffTypeByUsername(string userName)
        {
            var loginAdapter = new staff_credentialsTableAdapter();
            using (loginAdapter)
            {
                try
                {
                    var staffCredentialsRow =
                        loginAdapter.GetData().FirstOrDefault(login => login.username.Equals(userName));
                    if (staffCredentialsRow != null)
                    {
                        var id = staffCredentialsRow.staff_staffID;
                        var staffadapter = new staffTableAdapter();
                        using (staffadapter)
                        {
                            var staffRow = staffadapter.GetData().FirstOrDefault(staff => staff.staffID == id);
                            if (staffRow != null)
                            {
                                return staffRow.staffType;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return -1;
        }

        #endregion
    }
}