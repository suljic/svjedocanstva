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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            panelMenu.Width = 50;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(labelMenu.Text == "NAZAD")
            {
                panelMenu.Width = 220;
               
                labelMenu.Text = "MENU";
                panel1.Enabled = false;
            }
            else if(labelMenu.Text == "MENU")
            {
                panelMenu.Width = 50;
                
                labelMenu.Text = "NAZAD";
                panel1.Enabled = true;
            }
        }

        private void labelDodajUcenika_Click(object sender, EventArgs e)
        {
            labelDodajUcenika.BackColor = Color.SkyBlue;
        }
    }
}
