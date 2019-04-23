namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelRangLista = new System.Windows.Forms.Label();
            this.labelDodajUcenika = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonX = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // labelRangLista
            // 
            this.labelRangLista.AutoSize = true;
            this.labelRangLista.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRangLista.ForeColor = System.Drawing.Color.White;
            this.labelRangLista.Location = new System.Drawing.Point(50, 99);
            this.labelRangLista.Name = "labelRangLista";
            this.labelRangLista.Size = new System.Drawing.Size(101, 23);
            this.labelRangLista.TabIndex = 15;
            this.labelRangLista.Text = "RANG LISTA";
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
            this.labelDodajUcenika.Text = "DODAJ UČENIKA";
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
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.buttonX.Location = new System.Drawing.Point(768, 12);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(20, 20);
            this.buttonX.TabIndex = 16;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelRangLista;
        private System.Windows.Forms.Label labelDodajUcenika;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonX;
    }
}