﻿using LuBank.Application.Interfaces.AppService;
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
    public partial class FormCustomer : FormBase
    {
        protected readonly ICustomerAppService _customerAppService;
        protected readonly FormCustomerAdd _formCustomerAdd;

        public FormCustomer(ICustomerAppService customerAppService,
            FormCustomerAdd formCustomerAdd)
        {
            _customerAppService = customerAppService;
            _formCustomerAdd = formCustomerAdd;
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

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            _formCustomerAdd.ShowDialog(this);
        }
    }
}
