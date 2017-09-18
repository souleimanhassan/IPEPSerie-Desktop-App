using IPEPSerie.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPEPSerie.WinForms
{
    public partial class FLogin : Form
    {
        BizLogin _bizLogin;

        public FLogin()
        {
            InitializeComponent();
            _bizLogin = new BizLogin();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            tbHello.Text = _bizLogin.CallHelloIPEPS();
        }
    }
}
