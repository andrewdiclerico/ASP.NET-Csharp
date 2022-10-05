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
    public class ShowDataAccessLayer
    {

        string connectionString;

        private readonly IConfiguration _configuration;

        public ShowDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;

            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(ShowModel show)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO BL_Shows (username, Show_Title, Show_Director, Show_Seasons, Show_Episodes, Show_Rating, Show_Opinion, Show_Email, Show_Watched, Show_DateWatched) VALUES (@username, @Show_Title, @Show_Director, @Show_Seasons, @Show_Episodes, @Show_Rating, @Show_Opinion, @Show_Email, @Show_Watched, @Show_DateWatched);";

                show.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@username", "andrew");
                        command.Parameters.AddWithValue("@Show_Title", show.Show_Title);
                        command.Parameters.AddWithValue("@Show_Director", show.Show_Director);
                        command.Parameters.AddWithValue("@Show_Seasons", show.Show_Seasons);
                        command.Parameters.AddWithValue("@Show_Episodes", show.Show_Episodes);
                        command.Parameters.AddWithValue("@Show_Rating", show.Show_Rating);
                        command.Parameters.AddWithValue("@Show_Opinion", show.Show_Opinion);
                        command.Parameters.AddWithValue("@Show_Email", show.Show_Email);
                        command.Parameters.AddWithValue("@Show_Watched", show.Show_Watched);
                        command.Parameters.AddWithValue("@Show_DateWatched", show.Show_DateWatched);

                        connection.Open();

                        show.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";


                        connection.Close();

                    }
                }
                catch (Exception err)
                {
                    show.Feedback = "ERROR: " + err.Message;
                }

                //return RedirectToAction("");
            }
        }

        public IEnumerable<ShowModel> GetActiveShows()
        {
            List<ShowModel> lstShow = new List<ShowModel>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM BL_Shows ORDER BY username;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        ShowModel show = new ShowModel();

                        show.Show_ID = Convert.ToInt32(rdr["Show_ID"]);
                        show.User_Name = rdr["username"].ToString();
                        show.Show_Title = (rdr["Show_Title"].ToString());
                        show.Show_Director = (rdr["Show_Director"].ToString());
                        show.Show_Seasons = Convert.ToInt32(rdr["Show_Seasons"]);
                        show.Show_Episodes = Convert.ToInt32(rdr["Show_Episodes"]);
                        show.Show_Rating = Convert.ToInt32(rdr["Show_Rating"]);
                        show.Show_Opinion = (rdr["Show_Opinion"].ToString());
                        show.Show_Email = (rdr["Show_Email"].ToString());
                        show.Show_Watched = Boolean.Parse(rdr["Show_Watched"].ToString());
                        show.Show_DateWatched = DateTime.Parse(rdr["Show_DateWatched"].ToString());

                        lstShow.Add(show);
                    }

                    con.Close();
                }
            }
            catch (Exception err)
            {
                //nothing yet
            }

            return lstShow;

        }

        public ShowModel GetOneRecord(int? id)
        {
            ShowModel show = new ShowModel();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM BL_Shows WHERE Show_ID = @Show_ID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Show_ID", id);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        show.Show_ID = Convert.ToInt32(rdr["Show_ID"]);
                        show.User_Name = rdr["username"].ToString();
                        show.Show_Title = rdr["Show_Title"].ToString();
                        show.Show_Director = rdr["Show_Director"].ToString();
                        show.Show_Seasons = Convert.ToInt32(rdr["Show_Seasons"]);
                        show.Show_Episodes = Convert.ToInt32(rdr["Show_Episodes"]);
                        show.Show_Rating = Convert.ToInt32(rdr["Show_Rating"]);
                        show.Show_Opinion = rdr["Show_Opinion"].ToString();
                        show.Show_Email = rdr["Show_Email"].ToString();
                        show.Show_Watched = Boolean.Parse(rdr["Show_Watched"].ToString());
                        show.Show_DateWatched = DateTime.Parse(rdr["Show_DateWatched"].ToString());


                    }

                    con.Close();

                }
            }
            catch (Exception err)
            {
                show.Feedback = "ERROR: " + err.Message;
            }

            return show;

        }

        public void UpdateShow(ShowModel tShow)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();

                    string strSQL;

                    strSQL = "UPDATE BL_Shows SET username = @username, Show_Title = @Show_Title, Show_Director = @Show_Director, Show_Seasons = @Show_Seasons," +
                        " Show_Episodes = @Show_Episodes, Show_Rating = @Show_Rating," +
                        " Show_Opinion = @Show_Opinion, Show_Email = @Show_Email, Show_Watched = @Show_Watched," +
                        " Show_DateWatched = @Show_DateWatched WHERE Show_ID = @Show_ID;";

                    cmd.CommandText = strSQL;
                    cmd.Connection = con;

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Show_ID", tShow.Show_ID);
                    cmd.Parameters.AddWithValue("@username", "Andrew");
                    cmd.Parameters.AddWithValue("@Show_Title", tShow.Show_Title);
                    cmd.Parameters.AddWithValue("@Show_Director", tShow.Show_Director);
                    cmd.Parameters.AddWithValue("@Show_Seasons", tShow.Show_Seasons);
                    cmd.Parameters.AddWithValue("@Show_Episodes", tShow.Show_Episodes);
                    cmd.Parameters.AddWithValue("@Show_Rating", tShow.Show_Rating);
                    cmd.Parameters.AddWithValue("@Show_Opinion", tShow.Show_Opinion);
                    cmd.Parameters.AddWithValue("@Show_Email", tShow.Show_Email);
                    cmd.Parameters.AddWithValue("@Show_Watched", tShow.Show_Watched);
                    cmd.Parameters.AddWithValue("@Show_DateWatched", tShow.Show_DateWatched);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                }
            }
            catch (Exception err)
            {
                tShow.Feedback = "ERROR: " + err.Message;
            }
        }

        public ShowModel DeleteShow(int? id)
        {
            ShowModel show = new ShowModel();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "DELETE FROM BL_Shows WHERE Show_ID = @Show_ID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Show_ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception err)
            {
                show.Feedback = "ERROR: " + err.Message;
            }

            return show;
        }

    }
}
