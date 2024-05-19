using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClickme_Click(object sender, EventArgs e)
        {
            lbHello.Text = "Hello";
        }
    }
}
