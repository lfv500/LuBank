﻿using FluentValidation.Results;
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
    }
}
