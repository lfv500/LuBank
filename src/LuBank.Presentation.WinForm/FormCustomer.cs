using LuBank.Application.Interfaces.AppService;
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
    public partial class FormCustomer : Form
    {
        protected readonly ICustomerAppService _customerAppService;

        public FormCustomer(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
            => DoSearch();

        private void DoSearch()
        {
            using (var control = new LockControl(this))
            {
                var searchText = txtSearch.Text;
                var result = string.IsNullOrWhiteSpace(searchText)
                    ? _customerAppService.GetAll()
                    : _customerAppService.GetAllByName(searchText);

                dgvCustomers.DataSource = result;
            }
        }
    }
}
