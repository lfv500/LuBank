using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LuBank.Presentation.WinForm
{
    public partial class FormMain : FormBase
    {
        protected readonly IServiceProvider _serviceProvider;
        public FormMain(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void tsmFileClose_Click(object sender, EventArgs e)
            => Close();

        private void tsmRegistrationsCustomer_Click(object sender, EventArgs e)
        {
            var formCostumer = _serviceProvider.GetService<FormCustomer>();
            formCostumer.MdiParent = this;
            formCostumer.Show();
        }
    }
}
