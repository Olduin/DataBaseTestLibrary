using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLApp
{
    public class Genres
    {
        private string connectionString;

        /// <summary>
        ///Конструктор 
        /// </summary>
        /// <param name="connectionString"> строка подключения </param>
        public Genres(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddGenre(Genre genre)
        {
            string query = String.Format("insert Genre(GenreName) values('{0}'); ", genre.GenreName);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var cnt = command.ExecuteNonQuery();
                if (cnt == 1) return true;
            }
            return false;
        }

         public Genre GetGenre(long id)
        {
            string query = String.Format("select  Gnr.GenreId, Gnr.GenreName from Genre AS Gnr where genreId = {0}", id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        Genre genre = new Genre();
                        genre.GenreId = dataReader.GetInt32(dataReader.GetOrdinal("GenreId"));
                        genre.GenreName= dataReader.GetString(dataReader.GetOrdinal("GenreName"));
                        return genre;
                    }
                }
            }
            return null;
        }

        public Genre GetGenre(string GenreName)
        {
            string query = String.Format("select Gnr.GenreId, Gnr.GenreName from Genre AS Gnr where Gnr.GenreName = '{0}'", GenreName);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        Genre genre = new Genre();
                        genre.GenreId = dataReader.GetInt32(dataReader.GetOrdinal("GenreId"));
                        genre.GenreName= dataReader.GetString(dataReader.GetOrdinal("GenreName"));
                        return genre;
                    }
                }
                return null;
            }
        }
    }
}

