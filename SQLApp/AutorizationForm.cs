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
    public partial class AutorizationForm : Form
    {
        private MyAppContext myAppContext;

        public AutorizationForm(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
            InitializeComponent();
        }

        private void btnAuhorization_Click(object sender, EventArgs e)
        {
            AuthInformationDTO authInformation = new AuthInformationDTO();
            authInformation.Login = tbLogin.Text;
            authInformation.Password = tbPassword.Text;

            if (myAppContext.Authorization(authInformation) != true)
                toolStripStatusLabel1.Text = "Ошибка авторизации";
            else
                toolStripStatusLabel1.Text = "Авторизация успешна";
        }
    }
}