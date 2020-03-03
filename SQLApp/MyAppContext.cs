using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SQLApp
{
    enum ContextType { none, Librarian};

    public class MyAppContext : ApplicationContext
    {
        private Form form;

        private User user;

        private Repository repository;

        public MyAppContext(Repository repository)
        {
            this.repository = repository;

            form = new AutorizationForm(this);
            form.FormClosed += OnFormClosed;
            form.Show();
        }
      
        public bool Authorization(AuthInformationDTO authInfo)
        {
            User user = repository.Users.GetUser(authInfo.Login, authInfo.Password);

            if (user != null && user.Password == authInfo.Password)
            {
                this.user = user;
                form.Close();
                return true;
            }
            return false;
        }

        public DataSet GetUsers()
        {
            return repository.Users.GetUsers();
        }

        public DataSet GetUsersLibrarian()
        {
            return repository.Users.GetUserLibrarian();
        }

        private void ChangeContext(ContextType contextType)
        {
            if (contextType == ContextType.Librarian)
            {
                form = new LibrarianForm(this);
                form.FormClosed += OnFormClosed;
                form.Show();
            }
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(AutorizationForm) && user != null)
            {
                ChangeContext(ContextType.Librarian);
            }
            else
                ExitThread();
        }
    }

}

