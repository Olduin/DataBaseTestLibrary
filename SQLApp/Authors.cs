using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLApp
{
    public class Authors
    {
        private string connectionString;

        /// <summary>
        ///Конструктор 
        /// </summary>
        /// <param name="connectionString"> строка подключения </param>
        public Authors(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddAuthor(Author author)
        {
            string query = String.Format("insert Author(PersonId, Authorid) values('{0}', '{1}'); ", author.PersonId, author.NickName);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var cnt = command.ExecuteNonQuery();
                if (cnt == 1) return true;
            }
            return false;
        }

        public Author GetAuthor(long id)
        {
            string query = String.Format("select Atr.AuthorId, Atr.PersonId, Atr.NickName from Aurhor AS Atr where Atr.AuthorId = {0}", id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        Author author = new Author();
                        author.AuthorId = dataReader.GetInt32(dataReader.GetOrdinal("AuthorId"));
                        author.PersonId = dataReader.GetInt32(dataReader.GetOrdinal("PersonId"));
                        author.NickName = dataReader.GetString(dataReader.GetOrdinal("NickName"));
                        return author;
                    }
                }
            }
            return null;
        }
    }
}
