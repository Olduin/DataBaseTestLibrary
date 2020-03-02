using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLApp
{
    public class Repository
    {
        private string connectionString;


        public Repository(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new Exception("Строка подключения к базе не может быть пустой!");

            this.connectionString = connectionString;
        }   
        
        public Users Users
        {
            get
            {
                return new Users(connectionString);
            }
        }

        public Persons Persons
        {
            get
            {
                return new Persons(connectionString);
            }
        }

        public Genres Genres
        {
            get
            {
                return new Genres(connectionString);
            }
        }

        public Authors Authors
        {
            get
            {
                return new Authors(connectionString);
            }
        }
    }
}
