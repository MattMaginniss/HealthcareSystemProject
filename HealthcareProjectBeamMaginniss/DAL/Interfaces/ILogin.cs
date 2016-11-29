namespace HealthcareProjectBeamMaginniss.DAL.Interfaces
{
    internal interface ILogin
    {
        #region Methods

        bool CheckLogin(string id, string password);

        #endregion
    }
}