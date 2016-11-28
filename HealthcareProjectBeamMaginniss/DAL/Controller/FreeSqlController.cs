using HealthcareProjectBeamMaginniss.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareProjectBeamMaginniss.DAL.Controller
{
    class FreeSqlController
    {
        private readonly FreeSqlRepository fsr;

        public FreeSqlController()
        {
            this.fsr = new FreeSqlRepository();
        }

        public DataTable RunQuery(string query)
        {
            return fsr.RunQuery(query);
        }
    }
}
