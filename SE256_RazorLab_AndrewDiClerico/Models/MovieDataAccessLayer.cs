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
    public class MovieDataAccessLayer
    {

        string connectionString;

        private readonly IConfiguration _configuration;

        public MovieDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;

            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public void Create(MovieModel movie)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO BL_Movies (username, Movie_Title, Movie_Director, Movie_Length, Movie_Rating, Movie_Opinion, Movie_Email, Movie_Watched, Movie_DateWatched) VALUES (@username, @Movie_Title, @Movie_Director, @Movie_Length, @Movie_Rating, @Movie_Opinion, @Movie_Email, @Movie_Watched, @Movie_DateWatched);";

                movie.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@username", "andrew");
                        command.Parameters.AddWithValue("@Movie_Title", movie.Movie_Title);
                        command.Parameters.AddWithValue("@Movie_Director", movie.Movie_Director);
                        command.Parameters.AddWithValue("@Movie_Length", movie.Movie_Length);
                        command.Parameters.AddWithValue("@Movie_Rating", movie.Movie_Rating);
                        command.Parameters.AddWithValue("@Movie_Opinion", movie.Movie_Opinion);
                        command.Parameters.AddWithValue("@Movie_Email", movie.Movie_Email);
                        command.Parameters.AddWithValue("@Movie_Watched", movie.Movie_Watched);
                        command.Parameters.AddWithValue("@Movie_DateWatched", movie.Movie_DateWatched);

                        connection.Open();

                        movie.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";


                        connection.Close();

                    }
                }
                catch (Exception err)
                {
                    movie.Feedback = "ERROR: " + err.Message;
                }

                //return RedirectToAction("");

            }
        }

        public IEnumerable<MovieModel> GetActiveMovies()
        {
            List<MovieModel> lstMovie = new List<MovieModel>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM BL_Movies ORDER BY username";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        MovieModel movie = new MovieModel();

                        movie.Movie_ID = Convert.ToInt32(rdr["Movie_ID"]);
                        movie.User_Name = rdr["username"].ToString();
                        movie.Movie_Title = (rdr["Movie_Title"].ToString());
                        movie.Movie_Director = (rdr["Movie_Director"].ToString());
                        movie.Movie_Length = Convert.ToInt32(rdr["Movie_Length"]);
                        movie.Movie_Rating = Convert.ToInt32(rdr["Movie_Rating"]);
                        movie.Movie_Opinion = (rdr["Movie_Opinion"].ToString());
                        movie.Movie_Email = (rdr["Movie_Email"].ToString());
                        movie.Movie_Watched = Boolean.Parse(rdr["Movie_Watched"].ToString());
                        movie.Movie_DateWatched = DateTime.Parse(rdr["Movie_DateWatched"].ToString());

                        lstMovie.Add(movie);
                    }

                    con.Close();
                }
            }
            catch (Exception err)
            {
                //nothing yet
            }

            return lstMovie;

        }

        public MovieModel GetOneRecord(int? id)
        {
            MovieModel movie = new MovieModel();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM BL_Movies WHERE Movie_ID = @Movie_ID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Movie_ID", id);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        movie.Movie_ID = Convert.ToInt32(rdr["Movie_ID"]);
                        movie.User_Name = rdr["username"].ToString();
                        movie.Movie_Title = (rdr["Movie_Title"].ToString());
                        movie.Movie_Director = (rdr["Movie_Director"].ToString());
                        movie.Movie_Length = Convert.ToInt32(rdr["Movie_Length"]);
                        movie.Movie_Rating = Convert.ToInt32(rdr["Movie_Rating"]);
                        movie.Movie_Opinion = (rdr["Movie_Opinion"].ToString());
                        movie.Movie_Email = (rdr["Movie_Email"].ToString());
                        movie.Movie_Watched = Boolean.Parse(rdr["Movie_Watched"].ToString());
                        movie.Movie_DateWatched = DateTime.Parse(rdr["Movie_DateWatched"].ToString());


                    }

                    con.Close();

                }
            }
            catch (Exception err)
            {
                movie.Feedback = "ERROR: " + err.Message;
            }

            return movie;

        }

        public void UpdateMovie(MovieModel tMovie)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();

                    string strSQL;

                    strSQL = "UPDATE BL_Movies SET username = @username, Movie_Title = @Movie_Title," +
                        " Movie_Director = @Movie_Director, Movie_Length = @Movie_Length, Movie_Rating = @Movie_Rating," +
                        " Movie_Opinion = @Movie_Opinion, Movie_Email = @Movie_Email, Movie_Watched = @Movie_Watched," +
                        " Movie_DateWatched = @Movie_DateWatched WHERE Movie_ID = @Movie_ID;";

                    cmd.CommandText = strSQL;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@username", "Andrew");
                    cmd.Parameters.AddWithValue("@Movie_Title", tMovie.Movie_Title);
                    cmd.Parameters.AddWithValue("@Movie_Director", tMovie.Movie_Director);
                    cmd.Parameters.AddWithValue("@Movie_Length", tMovie.Movie_Length);
                    cmd.Parameters.AddWithValue("@Movie_Rating", tMovie.Movie_Rating);
                    cmd.Parameters.AddWithValue("@Movie_Opinion", tMovie.Movie_Opinion);
                    cmd.Parameters.AddWithValue("@Movie_Email", tMovie.Movie_Email);
                    cmd.Parameters.AddWithValue("@Movie_Watched", tMovie.Movie_Watched);
                    cmd.Parameters.AddWithValue("@Movie_DateWatched", tMovie.Movie_DateWatched);
                    cmd.Parameters.AddWithValue("@Movie_ID", tMovie.Movie_ID);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                }
            }
            catch (Exception err)
            {
                tMovie.Feedback = "ERROR: " + err.Message;
            }
        }

        public MovieModel DeleteMovie(int? id)
        {
            MovieModel movie = new MovieModel();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "DELETE FROM BL_Movies WHERE Movie_ID = @Movie_ID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Movie_ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception err)
            {
                movie.Feedback = "ERROR: " + err.Message;
            }

            return movie;
        }
    }
}
