using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formReconocimientoAZ
{
    public partial class Form1 : Form
    {
        //El panel de control está redibujando siempre su contenido
        //pero si lo queremos guardar, vamos a obtener una imagen vacía
        //Por eso debemos usar Bitmap, para dibujar ahí y guardarlo
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 20);
        public Graphics g;

        Bitmap surface;
        Graphics graph;
        string nombreImagen = "LetraDeEntrada";

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            //Vuelve la linea más suave
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(surface);
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                graph.DrawLine(p, old, current);
                old = current;
                panel1.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            surface.Save(nombreImagen + ".png");
        }
    }
}
