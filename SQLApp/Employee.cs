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
    public partial class Employee : Form
    {
        private MyAppContext myAppContext;
        private EditUserForm editUserForm;
        private User user;

        public Employee(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
            InitializeComponent();
            this.dataGridView1.DataSource = myAppContext.GetUsers().Tables["Users"];
        }
      
        private void cbFilterPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectFlag = cbFilterPosition.SelectedItem.ToString();
            this.dataGridView1.DataSource = myAppContext.GetUsersLibrarian(SelectFlag).Tables["Users"];
           
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            user = new User();
            editUserForm = new EditUserForm(myAppContext, user);
            editUserForm.UserAction += OnUserAction_EditUserForm;
            editUserForm.ShowDialog();
        }
      
        private void OnUserAction_EditUserForm(object sender, EventArgsUserAction e)
        {
            if (e.Action == FormUserAction.Save)
                myAppContext.AddUser(user);
                editUserForm.Close();
        }
    }
}
