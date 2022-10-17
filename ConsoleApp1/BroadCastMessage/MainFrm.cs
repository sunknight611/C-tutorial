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
    public partial class MainFrm : Form
    {
        public HandlerClass handler;
 
        public MainFrm(HandlerClass handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            handler.mainMessage += 1;
            handler.FireOhterAction(handler.mainMessage);
        }

        public void showText(int value)
        {
            MainLabel.Text = value.ToString();
        }
    }
}
