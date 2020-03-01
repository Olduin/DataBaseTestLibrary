using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLApp
{
    public class Persons
    {
        private string connectionString;
        public Persons(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddPerson(Person person)
        {
            string query = String.Format("insert Person(FirstName,Lastname,idPosition,MiddleName) values('{0}', '{1}','{2}','{3}');", person.FirstName, person.LastName, person.IdPosition, person.MiddleName);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var cnt = command.ExecuteNonQuery();
                if (cnt == 1) return true;
            }

            return false;
        }

        public Person GetPerson(Int32 id)
        {
            string query = String.Format("select personId,FirstName,Lastname,idPosition,MiddleName from person AS PN where PN.personId = {0}", id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        Person person = new Person();
                        person.PersonId = dataReader.GetInt32(dataReader.GetOrdinal("PersonId"));
                        person.FirstName = dataReader.GetString(dataReader.GetOrdinal("FirstName"));
                        person.LastName = dataReader.GetString(dataReader.GetOrdinal("LastName"));
                        person.IdPosition = dataReader.GetInt32(dataReader.GetOrdinal("IdPosition"));
                        person.MiddleName = dataReader.GetString(dataReader.GetOrdinal("MiddleName"));
                        return person;
                    }
                }
            }
            return null;
        }

        public Person GetPerson(string firstName, string lastName, string middleName)
        {
            string query = String.Format("select PersonID,FirstName,Lastname,idPosition,MiddleName from person AS PN where PN.Firstname='{0}' and PN.LastName='{1}' and PN.MiddleName='{2}'",firstName,lastName,middleName);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        Person person = new Person();
                        person.PersonId = dataReader.GetInt32(dataReader.GetOrdinal("PersonID"));
                        person.FirstName = dataReader.GetString(dataReader.GetOrdinal("FirstName"));
                        person.LastName = dataReader.GetString(dataReader.GetOrdinal("LastName"));
                        person.IdPosition = dataReader.GetInt32(dataReader.GetOrdinal("IdPosition"));
                        person.MiddleName = dataReader.GetString(dataReader.GetOrdinal("MiddleName"));
                        return person;
                    }
                }
            }
            return null;
        }
    }
}
