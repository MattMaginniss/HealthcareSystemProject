using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace HealthcareProjectBeamMaginniss.DAL.Repository
{
    internal class FreeSqlRepository
    {
        #region Methods

        public DataTable RunQuery(string query)
        {
            var conStr =
                ConfigurationManager.ConnectionStrings[
                    "HealthcareProjectBeamMaginniss.Properties.Settings.cs3230f16bConnectionString"].ConnectionString;
            var conn = new MySqlConnection(conStr);
            var da = new MySqlDataAdapter();
            var cmd = conn.CreateCommand();
            cmd.CommandText = query;
            da.SelectCommand = cmd;
            var ds = new DataTable();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }

        #endregion
    }
}