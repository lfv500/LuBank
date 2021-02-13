using LuBank.Application.Interfaces.AppService;
using LuBank.Application.ViewModel.Customers;
using LuBank.Infra.Utils;
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
    public partial class FormCustomerEdit : FormBase
    {
        private Guid _customerId;
        protected readonly ICustomerAppService _customerAppService;

        public FormCustomerEdit(ICustomerAppService customerAppService)
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
                var validationResult = _customerAppService.Update(customer);

                //Caso haja erros de validação
                if (!validationResult.IsValid)
                {
                    ShowValidationErrors(validationResult);
                    return;
                }

                //Caso sucesso
                MessageBox.Show("Cliente alterado com sucesso!");
                Close();
            }
        }

        /// <summary>
        /// Carrega um cliente no form
        /// </summary>
        public void LoadCustomer(Guid id)
        {
            _customerId = id;
            ClearScreen<TextBox>(this);
            var customer = _customerAppService.GetById(id);

            if (customer == null)
                return;

            //Name
            txtName.Text = customer.Name;

            //Documentos
            txtRg.Text = customer.Documents
                .FirstOrDefault(e => e.Type == Application.Enum.Customers.CustomerDocumentType.Rg)?.Value;

            txtCpf.Text = customer.Documents
                .FirstOrDefault(e => e.Type == Application.Enum.Customers.CustomerDocumentType.Cpf)?.Value;

            //Endereço
            txtNumber.Text = customer.Address.Number.ToString();
            txtCity.Text = customer.Address.City;
            txtComplement.Text = customer.Address.Complement;
            txtNeighborhood.Text = customer.Address.Neighborhood;
            txtProvince.Text = customer.Address.Province;
            txtStreet.Text = customer.Address.Street;
            txtZipCode.Text = customer.Address.ZipCode;

            //Telefone
            var phone = customer.Phones.FirstOrDefault();
            txtPhoneArea.Text = phone?.Ddd.ToString();
            txtPhone.Text = phone?.Number.ToString();
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
                Id = _customerId,
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

        private void FormCustomerAdd_FormClosed(object sender, FormClosedEventArgs e)
         => ClearScreen<TextBox>(this);
    }
}
