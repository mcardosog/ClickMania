namespace ClickMania
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Blue = new System.Windows.Forms.PictureBox();
            this.pictureBox_Green = new System.Windows.Forms.PictureBox();
            this.pictureBox_Orange = new System.Windows.Forms.PictureBox();
            this.pictureBox_Yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Valor = new System.Windows.Forms.PictureBox();
            this.label_Puntuacion = new System.Windows.Forms.Label();
            this.jUEGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Dificultad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Facil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Media = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Dificil = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label_VPuntuacion = new System.Windows.Forms.Label();
            this.label_TiempoRestante = new System.Windows.Forms.Label();
            this.label_VTiempo = new System.Windows.Forms.Label();
            this.label_ListoTiempo = new System.Windows.Forms.Label();
            this.linkLabel_Listo = new System.Windows.Forms.LinkLabel();
            this.timerTotal = new System.Windows.Forms.Timer(this.components);
            this.timerIntervalos = new System.Windows.Forms.Timer(this.components);
            this.timerDificil = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Valor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Blue
            // 
            this.pictureBox_Blue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Blue.Location = new System.Drawing.Point(235, 84);
            this.pictureBox_Blue.Name = "pictureBox_Blue";
            this.pictureBox_Blue.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Blue.TabIndex = 1;
            this.pictureBox_Blue.TabStop = false;
            this.pictureBox_Blue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox_Blue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox_Green
            // 
            this.pictureBox_Green.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Green.Location = new System.Drawing.Point(235, 392);
            this.pictureBox_Green.Name = "pictureBox_Green";
            this.pictureBox_Green.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Green.TabIndex = 2;
            this.pictureBox_Green.TabStop = false;
            this.pictureBox_Green.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox_Green.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox_Orange
            // 
            this.pictureBox_Orange.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Orange.Location = new System.Drawing.Point(71, 226);
            this.pictureBox_Orange.Name = "pictureBox_Orange";
            this.pictureBox_Orange.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Orange.TabIndex = 3;
            this.pictureBox_Orange.TabStop = false;
            this.pictureBox_Orange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox_Orange.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox_Yellow
            // 
            this.pictureBox_Yellow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Yellow.Location = new System.Drawing.Point(387, 226);
            this.pictureBox_Yellow.Name = "pictureBox_Yellow";
            this.pictureBox_Yellow.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_Yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Yellow.TabIndex = 4;
            this.pictureBox_Yellow.TabStop = false;
            this.pictureBox_Yellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox_Yellow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox_Valor
            // 
            this.pictureBox_Valor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Valor.Location = new System.Drawing.Point(213, 213);
            this.pictureBox_Valor.Name = "pictureBox_Valor";
            this.pictureBox_Valor.Size = new System.Drawing.Size(107, 107);
            this.pictureBox_Valor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Valor.TabIndex = 5;
            this.pictureBox_Valor.TabStop = false;
            // 
            // label_Puntuacion
            // 
            this.label_Puntuacion.AutoSize = true;
            this.label_Puntuacion.BackColor = System.Drawing.Color.Transparent;
            this.label_Puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Puntuacion.ForeColor = System.Drawing.Color.White;
            this.label_Puntuacion.Location = new System.Drawing.Point(356, 504);
            this.label_Puntuacion.Name = "label_Puntuacion";
            this.label_Puntuacion.Size = new System.Drawing.Size(113, 17);
            this.label_Puntuacion.TabIndex = 6;
            this.label_Puntuacion.Text = "PUNTUACION:";
            // 
            // jUEGOToolStripMenuItem
            // 
            this.jUEGOToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jUEGOToolStripMenuItem.BackgroundImage")));
            this.jUEGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.jUEGOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.jUEGOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.jUEGOToolStripMenuItem.Name = "jUEGOToolStripMenuItem";
            this.jUEGOToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.jUEGOToolStripMenuItem.Text = "JUEGO";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.BackgroundImage = global::ClickMania.Properties.Resources.woodBackground;
            this.recordsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.recordsToolStripMenuItem.Text = "Puntuacion";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.BackgroundImage")));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_Dificultad
            // 
            this.toolStripMenuItem_Dificultad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Facil,
            this.toolStripMenuItem_Media,
            this.toolStripMenuItem_Dificil});
            this.toolStripMenuItem_Dificultad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem_Dificultad.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_Dificultad.Name = "toolStripMenuItem_Dificultad";
            this.toolStripMenuItem_Dificultad.Size = new System.Drawing.Size(100, 23);
            this.toolStripMenuItem_Dificultad.Text = "DIFICULTAD";
            // 
            // toolStripMenuItem_Facil
            // 
            this.toolStripMenuItem_Facil.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem_Facil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_Facil.BackgroundImage")));
            this.toolStripMenuItem_Facil.Checked = true;
            this.toolStripMenuItem_Facil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_Facil.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_Facil.Name = "toolStripMenuItem_Facil";
            this.toolStripMenuItem_Facil.Size = new System.Drawing.Size(120, 24);
            this.toolStripMenuItem_Facil.Text = "Facil";
            this.toolStripMenuItem_Facil.Click += new System.EventHandler(this.toolStripMenuItemDificultad_Click);
            // 
            // toolStripMenuItem_Media
            // 
            this.toolStripMenuItem_Media.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem_Media.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_Media.BackgroundImage")));
            this.toolStripMenuItem_Media.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_Media.Name = "toolStripMenuItem_Media";
            this.toolStripMenuItem_Media.Size = new System.Drawing.Size(120, 24);
            this.toolStripMenuItem_Media.Text = "Media";
            this.toolStripMenuItem_Media.Click += new System.EventHandler(this.toolStripMenuItemDificultad_Click);
            // 
            // toolStripMenuItem_Dificil
            // 
            this.toolStripMenuItem_Dificil.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem_Dificil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_Dificil.BackgroundImage")));
            this.toolStripMenuItem_Dificil.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_Dificil.Name = "toolStripMenuItem_Dificil";
            this.toolStripMenuItem_Dificil.Size = new System.Drawing.Size(120, 24);
            this.toolStripMenuItem_Dificil.Text = "Dificil";
            this.toolStripMenuItem_Dificil.Click += new System.EventHandler(this.toolStripMenuItemDificultad_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.comoJugarToolStripMenuItem});
            this.aYUDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.aYUDAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.acercaDeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.BackgroundImage")));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // comoJugarToolStripMenuItem
            // 
            this.comoJugarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.comoJugarToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comoJugarToolStripMenuItem.BackgroundImage")));
            this.comoJugarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comoJugarToolStripMenuItem.Name = "comoJugarToolStripMenuItem";
            this.comoJugarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.comoJugarToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.comoJugarToolStripMenuItem.Text = "Como Jugar?";
            this.comoJugarToolStripMenuItem.Click += new System.EventHandler(this.comoJugarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jUEGOToolStripMenuItem,
            this.toolStripMenuItem_Dificultad,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label_VPuntuacion
            // 
            this.label_VPuntuacion.AutoSize = true;
            this.label_VPuntuacion.BackColor = System.Drawing.Color.Transparent;
            this.label_VPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VPuntuacion.ForeColor = System.Drawing.Color.White;
            this.label_VPuntuacion.Location = new System.Drawing.Point(478, 504);
            this.label_VPuntuacion.Name = "label_VPuntuacion";
            this.label_VPuntuacion.Size = new System.Drawing.Size(17, 17);
            this.label_VPuntuacion.TabIndex = 7;
            this.label_VPuntuacion.Text = "0";
            // 
            // label_TiempoRestante
            // 
            this.label_TiempoRestante.AutoSize = true;
            this.label_TiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.label_TiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TiempoRestante.ForeColor = System.Drawing.Color.White;
            this.label_TiempoRestante.Location = new System.Drawing.Point(23, 504);
            this.label_TiempoRestante.Name = "label_TiempoRestante";
            this.label_TiempoRestante.Size = new System.Drawing.Size(71, 17);
            this.label_TiempoRestante.TabIndex = 8;
            this.label_TiempoRestante.Text = "TIEMPO:";
            // 
            // label_VTiempo
            // 
            this.label_VTiempo.AutoSize = true;
            this.label_VTiempo.BackColor = System.Drawing.Color.Transparent;
            this.label_VTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VTiempo.ForeColor = System.Drawing.Color.White;
            this.label_VTiempo.Location = new System.Drawing.Point(103, 504);
            this.label_VTiempo.Name = "label_VTiempo";
            this.label_VTiempo.Size = new System.Drawing.Size(14, 17);
            this.label_VTiempo.TabIndex = 9;
            this.label_VTiempo.Text = "-";
            // 
            // label_ListoTiempo
            // 
            this.label_ListoTiempo.AutoSize = true;
            this.label_ListoTiempo.BackColor = System.Drawing.Color.Transparent;
            this.label_ListoTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ListoTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_ListoTiempo.Location = new System.Drawing.Point(253, 251);
            this.label_ListoTiempo.Name = "label_ListoTiempo";
            this.label_ListoTiempo.Size = new System.Drawing.Size(25, 26);
            this.label_ListoTiempo.TabIndex = 10;
            this.label_ListoTiempo.Text = "3";
            // 
            // linkLabel_Listo
            // 
            this.linkLabel_Listo.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel_Listo.AutoSize = true;
            this.linkLabel_Listo.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Listo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Listo.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel_Listo.Location = new System.Drawing.Point(222, 194);
            this.linkLabel_Listo.Name = "linkLabel_Listo";
            this.linkLabel_Listo.Size = new System.Drawing.Size(86, 26);
            this.linkLabel_Listo.TabIndex = 11;
            this.linkLabel_Listo.TabStop = true;
            this.linkLabel_Listo.Text = "LISTO!";
            this.linkLabel_Listo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timerTotal
            // 
            this.timerTotal.Tick += new System.EventHandler(this.timerTotal_Tick);
            // 
            // timerIntervalos
            // 
            this.timerIntervalos.Tick += new System.EventHandler(this.timerIntervalos_Tick);
            // 
            // timerDificil
            // 
            this.timerDificil.Tick += new System.EventHandler(this.timerDificil_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClickMania.Properties.Resources.woodBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 532);
            this.Controls.Add(this.pictureBox_Blue);
            this.Controls.Add(this.linkLabel_Listo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox_Green);
            this.Controls.Add(this.label_ListoTiempo);
            this.Controls.Add(this.label_Puntuacion);
            this.Controls.Add(this.pictureBox_Orange);
            this.Controls.Add(this.label_VPuntuacion);
            this.Controls.Add(this.label_VTiempo);
            this.Controls.Add(this.pictureBox_Valor);
            this.Controls.Add(this.pictureBox_Yellow);
            this.Controls.Add(this.label_TiempoRestante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickMania";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Valor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Blue;
        private System.Windows.Forms.PictureBox pictureBox_Green;
        private System.Windows.Forms.PictureBox pictureBox_Orange;
        private System.Windows.Forms.PictureBox pictureBox_Yellow;
        private System.Windows.Forms.PictureBox pictureBox_Valor;
        private System.Windows.Forms.Label label_Puntuacion;
        private System.Windows.Forms.ToolStripMenuItem jUEGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Dificultad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Facil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Media;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Dificil;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoJugarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label_VPuntuacion;
        private System.Windows.Forms.Label label_TiempoRestante;
        private System.Windows.Forms.Label label_VTiempo;
        private System.Windows.Forms.Label label_ListoTiempo;
        private System.Windows.Forms.LinkLabel linkLabel_Listo;
        private System.Windows.Forms.Timer timerTotal;
        private System.Windows.Forms.Timer timerIntervalos;
        private System.Windows.Forms.Timer timerDificil;


    }
}

