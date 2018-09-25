using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickMania
{
    public partial class Recordcs : Form
    {
        public Form1 Principal { get; set; }
        
        public Recordcs()
        {
            InitializeComponent();
        }

        private void Recordcs_Load(object sender, EventArgs e)
        {
            label_Putuacion.Text = Principal.Puntuacion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox_Nombre.Text;
            if (temp == "")
                temp = "SinNombre";
            Principal.RecordNombre = temp;
            this.Close();            
        }
    }
}
