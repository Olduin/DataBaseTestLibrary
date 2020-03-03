using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace SQLApp
{
    static class SQLApp
    {
            public static void Main()
            {
            string connectionString = "Server=localHost\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Library";
            Repository repository = new Repository(connectionString);
            //repository.Users.AddUser(new User {Name="Вася",Password="1234"});
            //var user = repository.Users.GetUser(2);
            //var user = repository.Users.GetUser("Petr", "Petr");
            //repository.Persons.AddPerson(new Person { FirstName = "Гордон", LastName = "freeman", IdPosition = 1,MiddleName="Steam" }) ;
            //var person = repository.Persons.GetPerson(2);
            //var person = repository.Persons.GetPerson("Андрей", "Чижиков", "Михайлович");
            //repository.Genres.AddGenre(new Genre { GenreName = "Сборник стихотворений" });
            //var genre = repository.Genres.GetGenre("Детектив");
            //repository.Authors.AddAuthor(new Author { PersonId = 5, NickName = "BasiK" });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyAppContext(repository));
        }

        public class LibrarianForm
        {
        }
    }
}
