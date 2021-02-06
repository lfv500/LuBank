using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuBank.Presentation.WinForm
{
    public class LockControl : IDisposable
    {
        private readonly Control _control;

        public LockControl(object control)
        {
            _control = (Control)control;
            _control.Enabled = false;
        }

        public void Dispose()
         => _control.Enabled = true;
    }
}
