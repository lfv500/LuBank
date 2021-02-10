using LuBank.Application.Interfaces.AppService;
using LuBank.Application.ViewModel.Customers;
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
    public partial class FormCustomerAdd : FormBase
    {
        protected readonly ICustomerAppService _customerAppService;

        public FormCustomerAdd(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
            => Save();

        private void Save()
        {
            using (var lockControl = new LockControl(this))
            {
                var customer = GetCustomerFromForm();
                var validationResult = _customerAppService.Add(customer);

                if (!validationResult.IsValid)
                {
                    MessageBox.Show("Erro de validação a implementar");
                    return;
                }

                MessageBox.Show("Cliente cadastrado com sucesso!");
                Close();
            }
        }

        private CustomerViewModel GetCustomerFromForm()
        {
            int.TryParse(txtNumber.Text, out var number);

            var documents = new List<CustomerDocumentViewModel>();
            documents.Add(new CustomerDocumentViewModel
            {
                Type = Application.Enum.Customers.CustomerDocumentType.Rg,
                Value = txtRg.Text
            });
            documents.Add(new CustomerDocumentViewModel
            {
                Type = Application.Enum.Customers.CustomerDocumentType.Cpf,
                Value = txtCpf.Text
            });

            int.TryParse(txtPhoneArea.Text, out var ddd);
            var phones = new List<CustomerPhoneViewModel>();
            phones.Add(new CustomerPhoneViewModel 
            { 
                Area = 55,
                Ddd = ddd,
                Number = txtPhone.Text
            });

            return new CustomerViewModel
            {
                Name = txtName.Text,
                Documents = documents,
                Phones = phones,
                Address = new CustomerAddressViewModel
                {
                    City = txtCity.Text,
                    Complement = txtComplement.Text,
                    Neighborhood = txtNeighborhood.Text,
                    Number = number,
                    Province = txtProvince.Text,
                    Street = txtStreet.Text,
                    ZipCode = txtZipCode.Text
                }
            };
        }
    }
}
