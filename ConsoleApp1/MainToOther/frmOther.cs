using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainToOther
{
    public partial class frmOther : Form
    {
        public frmOther()
        {
            InitializeComponent();
        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        public string Message
        {
            set
            {
                message.Text = value;
            }
        }
    }
}
