using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    class FreeSqlRepository
    {
        public DataTable RunQuery(string query)
        {
            var conStr = ConfigurationManager.ConnectionStrings["HealthcareProjectBeamMaginniss.Properties.Settings.cs3230f16bConnectionString"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(conStr);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            da.SelectCommand = cmd;
            DataTable ds = new DataTable();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }
    }
}
