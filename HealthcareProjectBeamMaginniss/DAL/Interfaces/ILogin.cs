namespace HealthcareProjectBeamMaginniss.DAL.Interfaces
{
    internal interface ILogin
    {
        bool CheckLogin(string id, string password);
    }
}