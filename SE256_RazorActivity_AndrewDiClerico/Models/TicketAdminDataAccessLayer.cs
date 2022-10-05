using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using SE256_RazorActivity_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorActivity_AndrewDiClerico.Models
{
    public class TicketAdminDataAccessLayer
    {

        string connectionString;

        private readonly IConfiguration _configuration;

        public TicketAdminDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;

            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<TicketAdmin> GetAdminLogin(TicketAdmin tAdmin)
        {
            List<TicketAdmin> lstTicketAdmin = new List<TicketAdmin>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT TOP 1 * FROM TicketAdmin_Registry WHERE TicketAdmin_Email = @TicketAdmin_Email AND TicketAdmin_PW = @TicketAdmin_PW;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@TicketAdmin_Email", tAdmin.TicketAdmin_Email);
                    cmd.Parameters.AddWithValue("@TicketAdmin_PW", tAdmin.TicketAdmin_PW);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        TicketAdmin tMatch = new TicketAdmin();

                        tMatch.TicketAdmin_ID = Convert.ToInt32(rdr["TicketAdmin_ID"]);
                        tMatch.TicketAdmin_Email = rdr["TicketAdmin_Email"].ToString();
                        tMatch.TicketAdmin_PW = rdr["TicketAdmin_PW"].ToString();

                        lstTicketAdmin.Add(tMatch);
                    }

                    con.Close();

                }
            }
            catch (Exception err)
            {
                //nothing atm
            }

            return lstTicketAdmin;

        }

    }
}
