using FluentValidation.Results;
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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exibe mensagem padrão de erros de validação
        /// </summary>
        protected void ShowValidationErrors(ValidationResult validationResult)
        {
            if (validationResult.IsValid)
                return;

            MessageBox.Show(validationResult.GetErrorMessage(), "Atenção", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void ClearScreen<TControl>(Control control)
            where TControl : Control
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TControl)
                {
                    var textBox = ctrl as TControl;
                    textBox.Text = string.Empty;
                }
                else

                    ClearScreen<TControl>(ctrl);
            }

        }
    }
}
