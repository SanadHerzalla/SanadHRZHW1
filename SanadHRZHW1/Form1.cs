namespace SanadHRZHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += PressEnter_KeyDown;
            textBox2.KeyDown += PressEnter_KeyDown;
            textBox3.KeyDown += PressEnter_KeyDown;
            textBox4.KeyDown += PressEnter_KeyDown;
        }

        

        private void PressEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;
                if (sender == textBox1)
                {
                    textBox2.Focus();
                }
                if (sender == textBox2)
                {
                    textBox3.Focus();
                }
                if(sender == textBox3)
                {
                    textBox4.Focus();
                }
                if(sender == textBox4)
                {
                    textBox1.Focus();
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
