using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class EditUserForm : Form
    {
        private User user;
        private MyAppContext myAppContext;
        public delegate void UserActionHandler(object sender, EventArgsUserAction e);

        public EditUserForm(MyAppContext myAppContext, User user)
        {
            this.myAppContext = myAppContext;
            this.user = user;

            InitializeComponent();
        }

        public event UserActionHandler UserAction;

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.Name = tbUserName.Text;
            user.Password = tbPassword.Text;

            if (UserAction == null)
                return;
            UserAction(this, new EventArgsUserAction(FormUserAction.Save));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UserAction == null)
                return;
            UserAction(this, new EventArgsUserAction(FormUserAction.Cansel));
        }
    }
}
