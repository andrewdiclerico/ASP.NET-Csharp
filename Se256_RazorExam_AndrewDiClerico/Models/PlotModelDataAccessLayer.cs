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
    public class PlotModelDataAccessLayer
    {

        string connectionString;

        private readonly IConfiguration _configuration;

        public PlotModelDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;

            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(PlotModel tPlot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sql = "INSERT INTO CemPlots (plotNumber, firstName, middleName, lastName, dob, dod, stoneCondition, plotCondition, needsAttention, revEmail, doLastRev) " +
                    "VALUES (@plotNumber, @firstName, @middleName, @lastName, @dob, @dod, @stoneCondition, @plotCondition, @needsAttention, @revEmail, @doLastRev);";

                tPlot.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@plotNumber", tPlot.PlotNumber);
                        command.Parameters.AddWithValue("@firstName", tPlot.FirstName);
                        
                        if (tPlot.MiddleName is null)
                        {
                            command.Parameters.AddWithValue("@middleName", "    ");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@middleName", tPlot.MiddleName);
                        }

                        command.Parameters.AddWithValue("@lastName", tPlot.LastName);
                        command.Parameters.AddWithValue("@dob", tPlot.DOB);
                        command.Parameters.AddWithValue("@dod", tPlot.DOD);
                        command.Parameters.AddWithValue("@stoneCondition", tPlot.StoneCondition);
                        command.Parameters.AddWithValue("@plotCondition", tPlot.PlotCondition);
                        command.Parameters.AddWithValue("@needsAttention", tPlot.NeedsAttention);
                        command.Parameters.AddWithValue("@revEmail", tPlot.RevEmail);
                        command.Parameters.AddWithValue("@doLastRev", tPlot.DOLastRev);

                        connection.Open();

                        tPlot.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";

                        connection.Close();


                    }
                }
                catch (Exception err)
                {
                    tPlot.Feedback = "ERROR: " + err.Message;
                }


            }


        }

        public IEnumerable<PlotModel> GetActiveRecords()
        {
            List<PlotModel> lstRec = new List<PlotModel>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM CemPlots ORDER BY plotNumber;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        PlotModel plot = new PlotModel();

                        plot.PlotID = Convert.ToInt32(rdr["plotID"]);
                        plot.PlotNumber = Convert.ToInt32(rdr["plotNumber"]);
                        plot.FirstName = rdr["firstName"].ToString();
                        plot.MiddleName = rdr["middleName"].ToString();
                        plot.LastName = rdr["lastName"].ToString();
                        plot.DOB = Convert.ToDateTime(rdr["dob"].ToString());
                        plot.DOD = Convert.ToDateTime(rdr["dod"].ToString());
                        plot.StoneCondition = Convert.ToDouble(rdr["stoneCondition"]);
                        plot.PlotCondition = Convert.ToDouble(rdr["plotCondition"]);
                        plot.NeedsAttention = Convert.ToBoolean(rdr["needsAttention"]);
                        plot.RevEmail = rdr["revEmail"].ToString();
                        plot.DOLastRev = Convert.ToDateTime(rdr["doLastRev"].ToString());

                        lstRec.Add(plot);

                    }

                    con.Close();

                }
            }
            catch (Exception err)
            {
                //
            }

            return lstRec;
        }

        public PlotModel GetOneRecord(int? id)
        {
            PlotModel plot = new PlotModel();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string strSQL = "SELECT * FROM CemPlots WHERE plotID = @plotID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@plotID", id);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        plot.PlotID = Convert.ToInt32(rdr["plotID"]);
                        plot.PlotNumber = Convert.ToInt32(rdr["plotNumber"]);
                        plot.FirstName = rdr["firstName"].ToString();
                        plot.MiddleName = rdr["middleName"].ToString();
                        plot.LastName = rdr["lastName"].ToString();
                        plot.DOB = Convert.ToDateTime(rdr["dob"].ToString());
                        plot.DOD = Convert.ToDateTime(rdr["dod"].ToString());
                        plot.StoneCondition = Convert.ToDouble(rdr["stoneCondition"]);
                        plot.PlotCondition = Convert.ToDouble(rdr["plotCondition"]);
                        plot.NeedsAttention = Convert.ToBoolean(rdr["needsAttention"]);
                        plot.RevEmail = rdr["revEmail"].ToString();
                        plot.DOLastRev = Convert.ToDateTime(rdr["doLastRev"].ToString());


                    }

                    con.Close();

                }
            }
            catch (Exception err)
            {
                plot.Feedback = "ERROR: " + err.Message;
            }

            return plot;

        }

        public void UpdatePlot(PlotModel tPlot)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();

                    string strSQL = "UPDATE CemPlots SET plotNumber = @plotNumber, firstName = @firstName, " +
                        "middleName = @middleName, lastName = @lastName, dob = @dob, dod = @dod, " +
                        "stoneCondition = @stoneCondition, plotCondition = @plotCondition, " +
                        "needsAttention = @needsAttention, revEmail = @revEmail, doLastRev = @doLastRev " +
                        "WHERE plotID = @plotID;";

                    cmd.CommandText = strSQL;

                    cmd.Connection = con;

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@plotID", tPlot.PlotID);
                    cmd.Parameters.AddWithValue("@plotNumber", tPlot.PlotNumber);
                    cmd.Parameters.AddWithValue("@firstName", tPlot.FirstName);
                    cmd.Parameters.AddWithValue("@middleName", tPlot.MiddleName);
                    cmd.Parameters.AddWithValue("@lastName", tPlot.LastName);
                    cmd.Parameters.AddWithValue("@dob", tPlot.DOB);
                    cmd.Parameters.AddWithValue("@dod", tPlot.DOD);
                    cmd.Parameters.AddWithValue("@stoneCondition", tPlot.StoneCondition);
                    cmd.Parameters.AddWithValue("@plotCondition", tPlot.PlotCondition);
                    cmd.Parameters.AddWithValue("@needsAttention", tPlot.NeedsAttention);
                    cmd.Parameters.AddWithValue("@revEmail", tPlot.RevEmail);
                    cmd.Parameters.AddWithValue("@doLastRev", tPlot.DOLastRev);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                }
            }
            catch(Exception err)
            {
                tPlot.Feedback = "ERROR: " + err.Message;
            }
        }

        public PlotModel DeletePlot(int? id)
        {
            PlotModel plot = new PlotModel();

            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "DELETE FROM CemPlots WHERE plotID = @plotID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("plotID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch(Exception err)
            {
                plot.Feedback = "ERROR: " + err.Message;
            }

            return plot;
        }
    }
}
