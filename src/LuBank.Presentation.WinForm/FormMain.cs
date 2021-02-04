using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuBank.Presentation.WinForm
{
    public partial class FormMain : Form
    {
        protected readonly FormCustomer _formCustomer;

        public FormMain(FormCustomer formCustomer)
        {
            _formCustomer = formCustomer;
            InitializeComponent();
        }

        private void tsmFileClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmRegistrationsCustomer_Click(object sender, EventArgs e)
        {
            _formCustomer.MdiParent = this;
            _formCustomer.Show();
        }
    }
}
