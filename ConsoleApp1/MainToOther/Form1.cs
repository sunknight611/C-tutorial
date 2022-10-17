namespace MainToOther
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            other = new frmOther();
            other.Show();
        }
        private frmOther other;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string Input = userInput.Text.Trim();
            if (string.IsNullOrEmpty(Input))
            {
                return; 
            }
            else
            {
                other.Message = Input;
            }
        }
    }
}