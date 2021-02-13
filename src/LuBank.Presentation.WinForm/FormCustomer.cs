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
    public partial class FormCustomer : FormBase
    {
        protected readonly ICustomerAppService _customerAppService;
        protected readonly FormCustomerAdd _formCustomerAdd;
        protected readonly FormCustomerEdit _formCustomerEdit;

        public FormCustomer(ICustomerAppService customerAppService,
            FormCustomerAdd formCustomerAdd,
            FormCustomerEdit formCustomerEdit)
        {
            _customerAppService = customerAppService;
            _formCustomerAdd = formCustomerAdd;
            _formCustomerEdit = formCustomerEdit;
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

        private void dgvCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            //Se tecla apertada em cima do grid
            if (sender == dgvCustomers && dgvCustomers.SelectedRows.Count > 0)
            {
                Guid.TryParse(dgvCustomers.SelectedRows[0].Cells["Id"].Value.ToString(), out var id);

                switch (e.KeyCode)
                {
                    case Keys.Delete: DeleteCustomer(id); break;
                    case Keys.Enter: EditCustomer(id); break;
                }
            }
        }

        private void EditCustomer(Guid id)
        {
            _formCustomerEdit.LoadCustomer(id);
            _formCustomerEdit.ShowDialog(this);
            DoSearch();
        }

        private void DeleteCustomer(Guid id)
        {
            using (new LockControl(this))
            {
                var result = _customerAppService.Remove(id);

                if (!result.IsValid)
                {
                    ShowValidationErrors(result);
                    return;
                }

                DoSearch();
            }
        }

        private void dgvCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sender == dgvCustomers && dgvCustomers.SelectedRows.Count > 0)
            {
                if(Guid.TryParse(dgvCustomers.SelectedRows[0].Cells["Id"].Value.ToString(), out var id))
                    EditCustomer(id);
            }
        }
    }
}
