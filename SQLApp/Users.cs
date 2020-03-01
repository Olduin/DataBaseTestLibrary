using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLApp
{
    public class Users
    {
        private string connectionString;
        
        /// <summary>
        ///Конструктор 
        /// </summary>
        /// <param name="connectionString"> строка подключения </param>
        public Users(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Добавляет пользователя
        /// </summary>
        /// <param name="user">Добавляемый пользователь</param>
        /// <returns>true, если добавилось</returns>
        public bool AddUser(User user) 
        {
            string query = String.Format("insert User_autorisation(Username,Password) values('{0}', '{1}'); ", user.Name, user.Password);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 
                command.Connection.Open();
                var cnt = command.ExecuteNonQuery();
                if (cnt == 1) return true; 
            }   

            return false;
        } 

        public User GetUser(long id)
        {
            string query = String.Format("select UA.UserID, UA.Username, UA.Password, UA.PersonID from User_autorisation AS UA where Ua.UserID = {0}",id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        User user = new User();
                        user.Id = dataReader.GetInt32(dataReader.GetOrdinal("UserId"));
                        user.Name = dataReader.GetString(dataReader.GetOrdinal("UserName"));
                        user.Password = dataReader.GetString(dataReader.GetOrdinal("Password"));
                        user.PersonId = dataReader.GetInt32(dataReader.GetOrdinal("PersonId"));
                        return user;
                    }
                }
            }
            return null;
        }

        public User GetUser(string UserName, string Passwrowd)
        {
            string query = String.Format("select UA.UserID, UA.UserName, UA.Password, Ua.PersonID from User_autorisation AS UA where UA.Username = '{0}' and UA.Password = '{1}'", UserName, Passwrowd);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        User user = new User();
                        user.Id = dataReader.GetInt32(dataReader.GetOrdinal("UserId"));
                        user.Name = dataReader.GetString(dataReader.GetOrdinal("UserName"));
                        user.Password = dataReader.GetString(dataReader.GetOrdinal("Password"));
                        user.PersonId = dataReader.GetInt32(dataReader.GetOrdinal("PersonId"));
                        return user;
                    }
                }
                return null;
            }
        }
    }
}
