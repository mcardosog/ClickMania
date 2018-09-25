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
    public partial class StatusPuntuaciones : Form
    {
        public Records Record { get; set; }
        List<Label> lLabelNombre;
        List<Label> lLabelPuntuacion;
        public StatusPuntuaciones()
        {
            InitializeComponent();
        }

        private void StatusPuntuaciones_Load(object sender, EventArgs e)
        {
            lLabelNombre = new List<Label>();
            lLabelNombre.Add(label_N1);
            lLabelNombre.Add(label_N2);
            lLabelNombre.Add(label_N3);
            lLabelNombre.Add(label_N4);
            lLabelNombre.Add(label_N5);
            lLabelNombre.Add(label_N6);
            lLabelNombre.Add(label_N7);
            lLabelNombre.Add(label_N8);
            lLabelNombre.Add(label_N9);
            lLabelNombre.Add(label_N10);
            lLabelPuntuacion = new List<Label>();
            lLabelPuntuacion.Add(label_P1);
            lLabelPuntuacion.Add(label_P2);
            lLabelPuntuacion.Add(label_P3);
            lLabelPuntuacion.Add(label_P4);
            lLabelPuntuacion.Add(label_P5);
            lLabelPuntuacion.Add(label_P6);
            lLabelPuntuacion.Add(label_P7);
            lLabelPuntuacion.Add(label_P8);
            lLabelPuntuacion.Add(label_P9);
            lLabelPuntuacion.Add(label_P10);

            label_Dificultad.Text = Record.Dific.ToString().ToUpper();

            for (int i = 0; i < Record.NombreActual.Count; i++)
            {
                lLabelNombre[i].Text = Record.NombreActual[i];
                lLabelPuntuacion[i].Text = Record.PuntuacionActual[i].ToString();
            }
        }
    }
}
