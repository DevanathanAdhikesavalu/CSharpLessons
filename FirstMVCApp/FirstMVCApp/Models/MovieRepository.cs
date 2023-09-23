using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml;

namespace FirstMVCApp.Models
{
    public class MovieRepository
    {
        public static List<Movie> GetMovieDetailsList()
        {
            List<Movie> list = new List<Movie>();

            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if(cn.State != ConnectionState.Open) 
                {
                    cn.Open();
                }
                SqlCommand cmd = cn.CreateCommand();
                string SelectAllMovies = "SELECT * FROM movietbl";
                cmd.CommandText = SelectAllMovies;
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Movie movie = new Movie()
                    {
                        MovieId = sqlDataReader.GetInt32(0),
                        MovieTitle = sqlDataReader.GetString(1),
                        MovieLanguage = sqlDataReader.GetString(2),
                        MovieHero = sqlDataReader.GetString(3),
                        MovieDirector = sqlDataReader.GetString(4),
                        MusicDirector = sqlDataReader.GetString(5),
                        MovieReleaseDate = sqlDataReader.GetDateTime(6),
                        ProductionCost = sqlDataReader.GetDecimal(7),
                        BoxOffice = sqlDataReader.GetDecimal(8),
                        MovieReview = sqlDataReader.GetString(9),
                    };
                    list.Add(movie);
                }
            }
            return list;
        }
        public static Movie FindMovieById(int id)
        {
            Movie movie = null;

            using (SqlConnection sn = SqlHelper.CreateConnection())
            {
                if (sn.State != ConnectionState.Open)
                {
                    sn.Open();
                }
                SqlCommand selectmovcmd = sn.CreateCommand();
                String selectEmps = "Select * from movietbl where ID=@id";
                selectmovcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmovcmd.CommandText = selectEmps;
                SqlDataReader sqlReader = selectmovcmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    movie = new Movie()
                    {
                        MovieId = sqlReader.GetInt32(0),
                        MovieTitle = sqlReader.GetString(1),
                        MovieLanguage = sqlReader.GetString(2),
                        MovieHero = sqlReader.GetString(3),
                        MovieDirector = sqlReader.GetString(4),
                        MusicDirector = sqlReader.GetString(5),
                        MovieReleaseDate = sqlReader.GetDateTime(6),
                        ProductionCost = sqlReader.GetDecimal(7),
                        BoxOffice = sqlReader.GetDecimal(8),
                        MovieReview = sqlReader.GetString(9),
                    };
                }
            }
            return movie;
        }
        public static int AddNewMovieDetails(Movie movie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                SqlCommand insertMoviecmd = cn.CreateCommand();

                String insertNewMovQuery = "insert into movietbl values( @ID,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review )";

                insertMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = movie.MovieId;
                
                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = movie.MovieTitle;
                
                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = movie.MovieLanguage;
                
                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = movie.MovieHero;

                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = movie.MovieDirector;

                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = movie.MusicDirector;

                insertMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = movie.MovieReleaseDate;

                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = movie.ProductionCost;

                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = movie.BoxOffice;

                insertMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = movie.MovieReview;

                insertMoviecmd.CommandText = insertNewMovQuery;

                query_result = insertMoviecmd.ExecuteNonQuery();

            }
            return query_result;
        }
        public static int UpdateMovieDetails(Movie movie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updatemoviecmd = cn.CreateCommand();
                String updateNewMovQuery = "Update movietbl set ID=@id,Title=@title,Language=@language,Hero=@hero,Director=@director,MusicDirector=@musicDirector,ReleaseDate=@releaseDate,Cost=@cost,Collection=@collection,Review=@review where ID=@id";
                updatemoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = movie.MovieId;

                updatemoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = movie.MovieTitle;

                updatemoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = movie.MovieLanguage;

                updatemoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = movie.MovieHero;

                updatemoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = movie.MovieDirector;

                updatemoviecmd.Parameters.Add("@musicDirector", SqlDbType.NVarChar).Value = movie.MusicDirector;

                updatemoviecmd.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = movie.MovieReleaseDate;

                updatemoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = movie.ProductionCost;

                updatemoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = movie.BoxOffice;

                updatemoviecmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = movie.MovieReview;

                updatemoviecmd.CommandText = updateNewMovQuery;

                query_result = updatemoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteMovieDetails(int id)
        {
            int query_Result = 0;
            using (SqlConnection sn=SqlHelper.CreateConnection())
            {
                if(sn.State != ConnectionState.Open) 
                {
                    sn.Open();
                }
                SqlCommand DeleteCmd = sn.CreateCommand();
                string SqlDeleteQuery = "delete from movietbl where ID=@id";
                DeleteCmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
                DeleteCmd.CommandText = SqlDeleteQuery;
                query_Result = DeleteCmd.ExecuteNonQuery();
            }
            return query_Result;
        }
    }
}
