using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Se256_RazorExam_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;


namespace Se256_RazorExam_AndrewDiClerico.Models
{
    public class AdminLoginDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public AdminLoginDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;

            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<AdminLogin> GetAdminLogin(AdminLogin tAdmin)
        {
            List<AdminLogin> lstAdmin = new List<AdminLogin>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT TOP 1 * FROM Admin_Registry WHERE Admin_Email = @Admin_Email AND Admin_PW = @Admin_PW;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Admin_Email", tAdmin.Admin_Email);
                    cmd.Parameters.AddWithValue("@Admin_PW", tAdmin.Admin_PW);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        AdminLogin tMatch = new AdminLogin();

                        tMatch.Admin_ID = Convert.ToInt32(rdr["Admin_ID"]);
                        tMatch.Admin_Email = rdr["Admin_Email"].ToString();
                        tMatch.Admin_PW = rdr["Admin_PW"].ToString();

                        lstAdmin.Add(tMatch);
                    }

                    con.Close();
                }
            }
            catch (Exception err)
            {
                //
            }
            return lstAdmin;


        }



    }
}
