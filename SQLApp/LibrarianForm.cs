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
    public partial class LibrarianForm : Form
    {
        private MyAppContext myAppContext;
        public LibrarianForm(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
            InitializeComponent();
        }
    }
}
