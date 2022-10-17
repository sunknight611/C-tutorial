using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadCastMessage
{
    
    public class HandlerClass
    {
         public int mainMessage { get; set; } = 0;
        public int otherMessage { get; set; } = 0;
         public event Action<int> sendToOther;
         public event Action<int> sendToMain;
         public void FireOhterAction(int value)
        {
            sendToOther(value);
        }

        public void FireMainAction(int value)
        {
            sendToMain(value);
        }

        public void CreateMainFrm()
        {
            MainFrm mainFrm = new MainFrm(this);
            mainFrm.Show();
            sendToMain += mainFrm.showText;
        }

        public void CreateOtherFrm()
        {
            OtherFrm otherFrm = new OtherFrm(this);
            otherFrm.Show();
            sendToOther += otherFrm.showText;
            
        }

    }
}
