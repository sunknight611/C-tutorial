using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroadCastMessage
{
    public partial class OtherFrm : Form
    {
        public HandlerClass handler;
        public OtherFrm(HandlerClass handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            handler.otherMessage += 1;
            handler.FireMainAction(handler.otherMessage);
        }

        private void OtherLabel_Click(object sender, EventArgs e)
        {

        }

        public void showText(int value)
        {
            OtherLabel.Text = value.ToString();
        }
    }
}
