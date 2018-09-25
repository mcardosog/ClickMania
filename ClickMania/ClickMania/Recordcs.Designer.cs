namespace ClickMania
{
    partial class Recordcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recordcs));
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_TiempoRestante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Putuacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(36, 38);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(186, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // label_TiempoRestante
            // 
            this.label_TiempoRestante.AutoSize = true;
            this.label_TiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.label_TiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TiempoRestante.ForeColor = System.Drawing.Color.White;
            this.label_TiempoRestante.Location = new System.Drawing.Point(9, 18);
            this.label_TiempoRestante.Name = "label_TiempoRestante";
            this.label_TiempoRestante.Size = new System.Drawing.Size(79, 17);
            this.label_TiempoRestante.TabIndex = 9;
            this.label_TiempoRestante.Text = "NOMBRE:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "PUNTUACION:";
            // 
            // label_Putuacion
            // 
            this.label_Putuacion.AutoSize = true;
            this.label_Putuacion.BackColor = System.Drawing.Color.Transparent;
            this.label_Putuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Putuacion.ForeColor = System.Drawing.Color.Yellow;
            this.label_Putuacion.Location = new System.Drawing.Point(128, 75);
            this.label_Putuacion.Name = "label_Putuacion";
            this.label_Putuacion.Size = new System.Drawing.Size(17, 17);
            this.label_Putuacion.TabIndex = 12;
            this.label_Putuacion.Text = "0";
            // 
            // Recordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClickMania.Properties.Resources.woodBackground;
            this.ClientSize = new System.Drawing.Size(266, 150);
            this.Controls.Add(this.label_Putuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_TiempoRestante);
            this.Controls.Add(this.textBox_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recordcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO RECORD";
            this.Load += new System.EventHandler(this.Recordcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_TiempoRestante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Putuacion;
    }
}