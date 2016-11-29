using System.Data;
using HealthcareProjectBeamMaginniss.DAL.Repository;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    internal class FreeSqlController
    {
        #region Data members

        private readonly FreeSqlRepository fsr;

        #endregion

        #region Constructors

        public FreeSqlController()
        {
            this.fsr = new FreeSqlRepository();
        }

        #endregion

        #region Methods

        public DataTable RunQuery(string query)
        {
            return this.fsr.RunQuery(query);
        }

        #endregion
    }
}