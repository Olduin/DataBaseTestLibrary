using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
                        user.Name = dataReader.GetString(dataReader.GetOrdinal("UserName")).TrimEnd();
                        user.Password = dataReader.GetString(dataReader.GetOrdinal("Password")).TrimEnd();
                        user.PersonId = dataReader.GetInt32(dataReader.GetOrdinal("PersonId"));
                        return user;
                    }
                }
                return null;
            }
        }

        public DataSet GetUsers()
        {
            DataSet users = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    @"Select
                        Ua.UserId as [№ сотрудника]
	                    ,Ua.Username as [Имя пользовател]
	                    ,ua.Password as [Пароль]
	                    ,Pr.FirstName as [Имя]
	                    ,Pr.LastName as [Фамилия]
	                    ,Pr.MiddleName as [Отчество]
	                    ,lop.JobTitles as [Должность]
                        ,ua.dismissed as [Уволен]
                    From dbo.User_autorisation ua
                    left join dbo.Person pr on pr.PersonId = ua.PersonID
                    left join dbo.List_Of_Position lop on lop.IDPosition = pr.IdPosition";
                //string query = "Select UserName,Password From dbo.User_autorisation";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(users, "Users");   
            }
            return users;
        }

        public DataSet GetUserLibrarian()
        {
            DataSet users = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                    @"Select
	                    Ua.UserId as [№ сотрудника]
	                    ,Ua.Username as [Имя пользовател]
	                    ,ua.Password as [Пароль]
	                    ,Pr.FirstName as [Имя]
	                    ,Pr.LastName as [Фамилия]
	                    ,Pr.MiddleName as [Отчество]
	                    ,lop.JobTitles as [Должность]
                    From dbo.User_autorisation ua 
                    left join dbo.Person pr on pr.PersonId=ua.PersonID
                    left join dbo.List_Of_Position lop on lop.IDPosition=pr.IdPosition
                    where lop.JobTitles='Библиотекарь'";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query,connectionString);
                adapter.Fill(users, "Users");
            }
            return users;
        }

        public bool UpdateUser(User user)
        {

            throw new NotImplementedException();
        }
    }
}
