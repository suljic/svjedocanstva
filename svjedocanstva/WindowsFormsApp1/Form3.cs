using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        int sakriveno = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sakriveno == 1)
            {
                panelMenu.Width = panelMenu.Width + 10;
                
                if (panelMenu.Width >= 220)
                {
                    timer1.Stop();
                    sakriveno = 0;
                    this.Refresh();
                }

            }
            else if (sakriveno == 0)
            {
                panelMenu.Width = panelMenu.Width - 10;
               
                if (panelMenu.Width <= 50)
                {
                    timer1.Stop();
                    sakriveno = 1;
                    this.Refresh();
                }
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelDodajUcenika_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
