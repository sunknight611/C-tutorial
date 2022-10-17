namespace BroadCastMessage
{
    public partial class Form1 : Form
    {
        HandlerClass handler;
        public Form1()
        {
            InitializeComponent();
            handler= new HandlerClass();
        }
        private void CreateMainFrm_Click(object sender, EventArgs e)
        {
            //MainFrm mainFrm = new MainFrm(handler);
            //mainFrm.Show();
            //mainFrmList.Add(mainFrm);
            handler.CreateMainFrm();
        }

        private void CreateOtherFrm_Click(object sender, EventArgs e)
        {

            //OtherFrm otherFrm = new OtherFrm(handler);
            //otherFrm.Show();
            //otherFrmList.Add(otherFrm);
            handler.CreateOtherFrm();
        }
    }
}