using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base
{
    public partial class Error : Form
    {
        public Error(string error)
        {
            InitializeComponent();
            richTextBox1.Text = error;
            Icon = Main.appIcon;
            Region = Region.FromHrgn(Main.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        private void ThemeCreator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Main.FormMove(Handle);
        }
        private void button1_Click(object sender, EventArgs e) => Environment.Exit(0);
    }
}
