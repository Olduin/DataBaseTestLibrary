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
    public partial class PersonForm : Form
    {
        private MyAppContext myAppContext;
        private Person person;

        public PersonForm()
        {
            this.myAppContext = myAppContext;
            InitializeComponent();
            this.dataGridView1.DataSource = myAppContext.GetUsers().Tables["Users"];
        }
    }
}
