using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClickMania
{
    public partial class Form1 : Form
    {
        public Dificultad Dificult { get; set; }
        public string RecordNombre { get; set; }

        int intervalo;
        int final;

        bool jugando;
        Records record;

        List<Image> imagenes;
        Image selecImagen;
        public int Puntuacion { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        int pbXBlueH;
        int pbXBlueW;
        int pbXYellowH;
        int pbXYellowW;
        int pbXGreenH;
        int pbXGreenW;
        int pbXOrangeH;
        int pbXOrangeW;

        private void Form1_Load(object sender, EventArgs e)
        {
            pbXBlueH = pictureBox_Blue.Height;
            pbXBlueW = pictureBox_Blue.Width;
            pbXYellowH = pictureBox_Yellow.Height;
            pbXYellowW = pictureBox_Yellow.Width;
            pbXGreenH = pictureBox_Green.Height;
            pbXGreenW = pictureBox_Green.Width;
            pbXOrangeH = pictureBox_Orange.Height;
            pbXOrangeW = pictureBox_Orange.Width;
            
            InicializaRecord();
            Dificult = Dificultad.Facil;
            label_ListoTiempo.Hide();
            Puntuacion = 0;
            imagenes = new List<Image>();
            Image tempImg = Properties.Resources.Bluet;
            tempImg.Tag = "Blue";
            pictureBox_Blue.Image = tempImg;
            imagenes.Add(tempImg);            
            //
            tempImg = Properties.Resources.GreenT;
            tempImg.Tag = "Green";
            pictureBox_Green.Image = tempImg;
            imagenes.Add(tempImg);          
            //
            tempImg = Properties.Resources.OrangeT;
            tempImg.Tag = "Orange";
            pictureBox_Orange.Image = tempImg;
            imagenes.Add(tempImg);
            //
            tempImg = Properties.Resources.Yellowt;
            tempImg.Tag = "Yellow";
            pictureBox_Yellow.Image = tempImg;
            imagenes.Add(tempImg);
            //
            selecImagen = imagenes[new Random().Next(imagenes.Count)];
            intervalo = 3;
            final = 20;
            jugando = false;
        }       

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!jugando)
                return;
            SystemSounds.Asterisk.Play();
            PictureBox pbxTemp = sender as PictureBox;
            if (pbxTemp.Image.Tag == pictureBox_Valor.Image.Tag)
                Puntuacion++;
            else if (Puntuacion > 0)
                Puntuacion--;
            label_VPuntuacion.Text = Puntuacion.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_Listo.Hide();
            label_ListoTiempo.Show();
            timerIntervalos.Interval=1000;
            timerIntervalos.Start();
            menuStrip1.Hide();
        }

        private void timerIntervalos_Tick(object sender, EventArgs e)
        {
            if (!jugando)
            {
                //SystemSounds.Question.Play();
                SystemSounds.Exclamation.Play();
                
                //SystemSounds.Asterisk.Play();
                //SystemSounds.Beep.Play();
                
                intervalo--;
                if (intervalo == 0)
                {
                    SystemSounds.Hand.Play();
                    label_ListoTiempo.Hide();
                    jugando = true;
                    intervalo = 0;
                    timerTotal.Interval = timerIntervalos.Interval;
                    pictureBox_Valor.Image = selecImagen;
                    timerTotal.Start();
                }
                else
                    label_ListoTiempo.Text = intervalo.ToString();
            }
            //---------------------------------------------------------//
            else
            {
                
                if (Dificult == Dificultad.Dificil)
                    timerDificil.Start();
                intervalo++;
                if (intervalo % 5 == 0 && (Dificult == Dificultad.Medio || Dificult == Dificultad.Dificil))
                    Medio();
                if (intervalo % 2 == 0 && Dificult!=Dificultad.Dificil)
                {
                    int local = imagenes.IndexOf(selecImagen);
                    imagenes.Add(selecImagen);
                    imagenes.RemoveAt(local);
                    selecImagen = imagenes[new Random().Next(imagenes.Count-1)];
                    pictureBox_Valor.Image = selecImagen;
                }
            }
        }

        private List<Image> GeneradorLista()
        {
            List<Image> randTemp = new List<Image>();
            Image tempImg = Properties.Resources.Bluet;
            tempImg.Tag = "Blue";
            randTemp.Add(tempImg);
            //
            tempImg = Properties.Resources.GreenT;
            tempImg.Tag = "Green";
            randTemp.Add(tempImg);
            //
            tempImg = Properties.Resources.OrangeT;
            tempImg.Tag = "Orange";
            randTemp.Add(tempImg);
            //
            tempImg = Properties.Resources.Yellowt;
            tempImg.Tag = "Yellow";
            randTemp.Add(tempImg);
            return randTemp;
        }

        private void Medio()
        {
            List<Image> randTemp = GeneradorLista();
            Image temp = randTemp.FindAll(x => x.Tag != pictureBox_Blue.Image.Tag)[new Random().Next(3)] ;
            pictureBox_Blue.Image = temp;
            randTemp.Remove(temp);
            //
            temp = randTemp.FindAll(x => x.Tag != pictureBox_Yellow.Image.Tag)[new Random().Next(2)];
            pictureBox_Yellow.Image = temp;
            randTemp.Remove(temp);            
            //
            temp = randTemp.Find(x => x.Tag != pictureBox_Orange.Image.Tag);
            pictureBox_Orange.Image = temp;
            randTemp.Remove(temp);

            pictureBox_Green.Image = randTemp[0];
            
        }      

        private void timerTotal_Tick(object sender, EventArgs e)
        {
            final--;
            label_VTiempo.Text = final.ToString();
            if(final<5)
                SystemSounds.Exclamation.Play();

            if (final == 0)
            {
                menuStrip1.Show();
                timerTotal.Stop();
                timerIntervalos.Stop();
                timerDificil.Stop();

                pictureBox_Blue.Height = pbXBlueH;
                pictureBox_Blue.Width = pbXBlueW;
                pictureBox_Yellow.Height = pbXYellowH;
                pictureBox_Yellow.Width = pbXYellowW;
                pictureBox_Green.Height = pbXGreenH;
                pictureBox_Green.Width = pbXGreenW;
                pictureBox_Orange.Height = pbXOrangeH;
                pictureBox_Orange.Width = pbXOrangeW;

                if (record.PusoRecord(Puntuacion))
                {
                    MessageBox.Show("Juego Terminado. Su puntuacion fue de " + Puntuacion + " puntos.", "Infomacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Recordcs rec = new Recordcs();
                    rec.Principal = this;
                    rec.ShowDialog();
                    record.AnadeRecord(RecordNombre, Puntuacion);                    
                }
                else
                    MessageBox.Show("Juego Terminado. Su puntuacion fue de "+Puntuacion+" puntos.", "Infomacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                final = 20;
                intervalo = 3;                
                pictureBox_Valor.Image = null;
                label_VTiempo.Text = "";
                label_VPuntuacion.Text = "";
                label_ListoTiempo.Text = "3";
                label_ListoTiempo.Hide();
                linkLabel_Listo.Show();
                selecImagen = imagenes[new Random().Next(imagenes.Count)];
                jugando = false;
                Puntuacion = 0;
                
            }            
        }

        private void InicializaRecord()
        {
            if (File.Exists("records.rec"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("records.rec", FileMode.Open, FileAccess.Read);
                record = (Records)bf.Deserialize(fs);
                fs.Close();
                record.Dific = Dificultad.Facil;
            }
            else
                record = new Records();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ClickMania 1.0 \nCreador: Marco A. Cardoso \n\t\t 2013", "Acerda de ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusPuntuaciones sPuntuaciones = new StatusPuntuaciones();
            sPuntuaciones.Record = record;
            sPuntuaciones.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("records.rec", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, record);
            fs.Close();
        }

        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ay = new Ayuda();
            ay.ShowDialog();
        }

        private void toolStripMenuItemDificultad_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = sender as ToolStripMenuItem;
            toolStripMenuItem_Facil.Checked = false;
            toolStripMenuItem_Media.Checked = false;
            toolStripMenuItem_Dificil.Checked = false;
            temp.Checked = true;
            switch (temp.Text)
            {
                case "Facil":
                    {
                        record.Dific = Dificultad.Facil;
                        Dificult = Dificultad.Facil; 
                        break;
                    }
                case "Media":
                    {
                        record.Dific = Dificultad.Medio;
                        Dificult = Dificultad.Medio; 
                        break;
                    }
                case "Dificil":
                    {
                        record.Dific = Dificultad.Dificil;
                        Dificult = Dificultad.Dificil; 
                        break;
                    }
                default:
                    break;
            }
        }

        private void timerDificil_Tick(object sender, EventArgs e)
        {
            timerDificil.Interval = new Random().Next(500, 2500);
            int local = imagenes.IndexOf(selecImagen);
            imagenes.Add(selecImagen);
            imagenes.RemoveAt(local);
            selecImagen = imagenes[new Random().Next(imagenes.Count - 1)];
            pictureBox_Valor.Image = selecImagen;
        }              

    }

    [Serializable]
    public enum Dificultad { Facil, Medio, Dificil }

    [Serializable]
    public class Records
    {
        private Dificultad dific;

        public Dificultad Dific
        {
            get { return dific; }
            set 
            { 
                dific = value;
                switch (value)
                {
                    case Dificultad.Facil:
                        {
                            NombreActual = NombreF;
                            PuntuacionActual = PuntuacionF;
                            break;
                        }
                    case Dificultad.Medio:
                        {
                            NombreActual = NombreM;
                            PuntuacionActual = PuntuacionM;
                            break;
                        }
                    case Dificultad.Dificil:
                        {
                            NombreActual = NombreD;
                            PuntuacionActual = PuntuacionD;
                            break;
                        }
                }
            }
        }
        
        public List<string> NombreF { get; private set; }
        public List<int> PuntuacionF { get; private set; }

        public List<string> NombreM { get; private set; }
        public List<int> PuntuacionM { get; private set; }

        public List<string> NombreD { get; private set; }
        public List<int> PuntuacionD { get; private set; }

        public List<string> NombreActual { get; private set; }
        public List<int> PuntuacionActual { get; private set; }

        public Records()
        {            
            NombreF = new List<string>();
            PuntuacionF = new List<int>();
            NombreM = new List<string>();
            PuntuacionM = new List<int>();
            NombreD = new List<string>();
            PuntuacionD = new List<int>();
            Dific = Dificultad.Facil;
        }

        public bool PusoRecord(int puntos)
        {
            if (PuntuacionActual.Count < 10)
                return true;
            foreach (var item in PuntuacionActual)
            {
                if (item < puntos)
                    return true;
            }
            return false;
        }

        public void AnadeRecord(string jugador, int puntos)
        {
            bool puse = false;
            foreach (var item in PuntuacionActual)
            {
                if (puntos > item)
                {
                    int pos = PuntuacionActual.IndexOf(item);
                    PuntuacionActual.Insert(pos, puntos);
                    NombreActual.Insert(pos, jugador);
                    puse = true;
                    break;
                }
            }
            if (!puse)
            {
                PuntuacionActual.Add(puntos);
                NombreActual.Add(jugador);
            }

            if (PuntuacionActual.Count > 10)
            {
                PuntuacionActual.RemoveAt(PuntuacionActual.Count-1);
                NombreActual.RemoveAt(NombreActual.Count - 1);
            }
        }
    }
}
