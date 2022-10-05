using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using SE256_RazorLab_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;



namespace SE256_RazorLab_AndrewDiClerico.Models
{
    public class BacklogAdminDataAccessLayer
    {

        string connectionString;

        private readonly IConfiguration _configuration;

        public BacklogAdminDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;

            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<BacklogAdmin> getAdminLogin(BacklogAdmin bAdmin)
        {
            List<BacklogAdmin> lstBacklogAdmin = new List<BacklogAdmin>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT TOP 1 * FROM BLAdmin_Registry WHERE BLAdmin_Email = @BLAdmin_Email AND BLAdmin_PW = @BLAdmin_PW;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@BLAdmin_Email", bAdmin.BLAdmin_Email);
                    cmd.Parameters.AddWithValue("@BLAdmin_PW", bAdmin.BLAdmin_PW);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        BacklogAdmin bMatch = new BacklogAdmin();

                        bMatch.BLAdmin_ID = Convert.ToInt32(rdr["BLAdmin_ID"]);
                        bMatch.BLAdmin_Email = rdr["BLAdmin_Email"].ToString();
                        bMatch.BLAdmin_PW = rdr["BLAdmin_PW"].ToString();

                        lstBacklogAdmin.Add(bMatch);

                    }

                    con.Close();

                }

            }
            catch(Exception err)
            {
                //nothing
            }

            return lstBacklogAdmin;

        }

    }
}
