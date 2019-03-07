namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelDodajUcenika = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonX = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelRangLista = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(131)))), ((int)(((byte)(213)))));
            this.panelMenu.Controls.Add(this.labelRangLista);
            this.panelMenu.Controls.Add(this.labelDodajUcenika);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(50, 920);
            this.panelMenu.TabIndex = 0;
            // 
            // labelDodajUcenika
            // 
            this.labelDodajUcenika.AutoSize = true;
            this.labelDodajUcenika.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodajUcenika.ForeColor = System.Drawing.Color.White;
            this.labelDodajUcenika.Location = new System.Drawing.Point(50, 62);
            this.labelDodajUcenika.Name = "labelDodajUcenika";
            this.labelDodajUcenika.Size = new System.Drawing.Size(138, 23);
            this.labelDodajUcenika.TabIndex = 12;
            this.labelDodajUcenika.Text = "DODAJ UCENIKA";
            this.labelDodajUcenika.Click += new System.EventHandler(this.labelDodajUcenika_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(131)))), ((int)(((byte)(213)))));
            this.labelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Image = ((System.Drawing.Image)(resources.GetObject("labelMenu.Image")));
            this.labelMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMenu.Location = new System.Drawing.Point(3, 9);
            this.labelMenu.MinimumSize = new System.Drawing.Size(200, 20);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(200, 23);
            this.labelMenu.TabIndex = 11;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prezime (očevo ime) i ime učenika";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum rođenja\r\n\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(536, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime i ime oca i majke, zanimanje";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(537, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Državljanin\r\n";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(536, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresa stanovanja, ulica, broj, mjesto, općina\r\n";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(536, 232);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Broj telefona";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(537, 277);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(267, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prvi strani jezik koji je učenik učio u osnovnoj školi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fakultativna nastava";
            // 
            // buttonX
            // 
            this.buttonX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(131)))), ((int)(((byte)(213)))));
            this.buttonX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(131)))), ((int)(((byte)(213)))));
            this.buttonX.Location = new System.Drawing.Point(1064, 12);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(20, 20);
            this.buttonX.TabIndex = 9;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.checkedListBox3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.checkedListBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 885);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Tehničar računarstva",
            "Tehničar elektronike",
            "Tehničar elektroenergetike",
            "Tehničar mehatronike",
            "Elektroničar telekomunikacija",
            "Autoelektričar",
            "Električar"});
            this.checkedListBox3.Location = new System.Drawing.Point(66, 683);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(164, 112);
            this.checkedListBox3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 653);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Želja 2";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Tehničar računarstva",
            "Tehničar elektronike",
            "Tehničar elektroenergetike",
            "Tehničar mehatronike",
            "Elektroničar telekomunikacija",
            "Autoelektričar",
            "Električar"});
            this.checkedListBox2.Location = new System.Drawing.Point(66, 512);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(164, 112);
            this.checkedListBox2.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Želja 1";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Religijska kultura",
            "Islamski vjeronauk",
            "Katolički vjeronauk",
            "Pravoslavni vjeronauk"});
            this.checkedListBox1.Location = new System.Drawing.Point(66, 404);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(146, 64);
            this.checkedListBox1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(62, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(261, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Mjesto rođenja,općina,republika";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(536, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(537, 337);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Engleski Jezik";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(706, 337);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Njemacki Jezik";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // labelRangLista
            // 
            this.labelRangLista.AutoSize = true;
            this.labelRangLista.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRangLista.ForeColor = System.Drawing.Color.White;
            this.labelRangLista.Location = new System.Drawing.Point(63, 112);
            this.labelRangLista.Name = "labelRangLista";
            this.labelRangLista.Size = new System.Drawing.Size(101, 23);
            this.labelRangLista.TabIndex = 13;
            this.labelRangLista.Text = "RANG LISTA";
            this.labelRangLista.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 920);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelDodajUcenika;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelRangLista;
    }
}