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
        int sakriveno = 1;
        int sakriveno2 = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            panelMenu.Width = 50;
            panelPodatci.Height = 0;
            panelUcenik.Height = 75;
            labelDodajUcenika.BackColor = Color.SkyBlue;
            panelDodajUcenika.Visible = true;
            panelUpisaniUcenici.Visible = false;

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
                panelDodajUcenika.Left = panelDodajUcenika.Left + 10;
                panelUpisaniUcenici.Left = panelUpisaniUcenici.Left + 10;
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
                panelDodajUcenika.Left = panelDodajUcenika.Left - 10;
                panelUpisaniUcenici.Left = panelUpisaniUcenici.Left - 10;
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
            labelUpisiOcjene.BackColor = Color.Transparent;
            labelRangLista.BackColor = Color.Transparent;
            labelUpisaniUcenici.BackColor = Color.Transparent;

            panelDodajUcenika.Visible = true;
            panelUpisaniUcenici.Visible = false;
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
            labelUpisaniUcenici.BackColor = Color.Transparent;
            labelRangLista.BackColor = Color.Transparent;
            labelUpisiOcjene.BackColor = Color.SkyBlue;

            panelDodajUcenika.Visible = false;
            panelUpisaniUcenici.Visible = false;

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            labelDodajUcenika.BackColor = Color.Transparent;
            labelUpisiOcjene.BackColor = Color.Transparent;
            labelRangLista.BackColor = Color.Transparent;
            labelUpisaniUcenici.BackColor = Color.SkyBlue;

            panelDodajUcenika.Visible = false;
            panelUpisaniUcenici.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Provjerava da li su podatci uneseni
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                labelWarning.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                labelWarning.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(this.textBox3.Text))
            {
                labelWarning.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                labelWarning.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(this.textBox5.Text))
            {
                labelWarning.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(this.textBox6.Text))
            {
                labelWarning.Visible = true;
            }
            else if(!checkBoxEngleski.Checked && !checkBoxNjemacki.Checked)
            {
                labelWarning.Visible = true;
            }
            else
            {
                labelWarning.Visible = false;
            }
        }




        private void labelPrikaziVise_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sakriveno2 == 1)
            {
                panelPodatci.Height = panelPodatci.Height + 10;
                panelUcenik.Height = panelUcenik.Height + 5;

                if (panelPodatci.Height >= 880)
                {
                    timer2.Stop();
                    sakriveno2 = 0;
                    this.Refresh();
                }

            }
            else if (sakriveno2 == 0)
            {
                panelPodatci.Height = panelPodatci.Height - 10;
                panelUcenik.Height = panelUcenik.Height - 5;

                if (panelPodatci.Height == 0)
                {
                    timer2.Stop();
                    sakriveno2 = 1;
                    this.Refresh();
                }
            }
        }

        private void labelRangLista_Click(object sender, EventArgs e)
        {
            labelDodajUcenika.BackColor = Color.Transparent;
            labelUpisiOcjene.BackColor = Color.Transparent;
            labelUpisaniUcenici.BackColor = Color.Transparent;
            labelRangLista.BackColor = Color.SkyBlue;

            panelDodajUcenika.Visible = false;
            panelUpisaniUcenici.Visible = false;
        }
    }
}
