﻿using System;
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
        int sakriveno = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            panelMenu.Width = 50;
            labelDodajUcenika.BackColor = Color.SkyBlue;

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sakriveno == 1)
            {
                panelMenu.Width = panelMenu.Width + 10;
                panel1.Left = panel1.Left + 10;
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
                panel1.Left = panel1.Left - 10;
                if (panelMenu.Width <= 50)
                {
                    timer1.Stop();
                    sakriveno = 1;
                    this.Refresh();
                }
            }
        }

        private void labelDodajUcenika_Click(object sender, EventArgs e)
        {
            labelDodajUcenika.BackColor = Color.SkyBlue;
            labelRangLista.BackColor = Color.Transparent;
            panel1.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            labelDodajUcenika.BackColor = Color.Transparent;
            labelRangLista.BackColor = Color.SkyBlue;
            panel1.Visible = false;

        }
    }
}
