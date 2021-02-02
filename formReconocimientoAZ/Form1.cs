using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
        string ruta = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\LetrasUsuario\";
        string nombreImagen = "ImagenUsuario";
        int numeroDeImagen = 1;

        int ASCII;
        //Objeto para guardar los valors de 0 y 1 
        //de las letras que marcan la salida que las neuronas deben tener 
        matrizCaracteres letrasIdeal = new matrizCaracteres();
        //Objeto para leer las letras del dataBase 
        matrizCaracteres letraUsuario = new matrizCaracteres();

        double[][] dataIdealA;
        double[][] dataIdealB;
        double[][] dataIdealC;
        double[][] dataIdealD;
        double[][] dataIdealE;
        double[][] dataIdealF;
        double[][] dataIdealG;
        double[][] dataIdealH;
        double[][] dataIdealI;
        double[][] dataIdealJ;
        double[][] dataIdealK;
        double[][] dataIdealL;
        double[][] dataIdealM;
        double[][] dataIdealN;
        double[][] dataIdealO;
        double[][] dataIdealP;
        double[][] dataIdealQ;
        double[][] dataIdealR;
        double[][] dataIdealS;
        double[][] dataIdealT;
        double[][] dataIdealU;
        double[][] dataIdealV;
        double[][] dataIdealW;
        double[][] dataIdealX;
        double[][] dataIdealY;
        double[][] dataIdealZ;
        double[][] dataUsuario;
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

        private void button2_Click(object sender, EventArgs e)
        {
            surface.Save(ruta+nombreImagen+Convert.ToString(numeroDeImagen)+".png");
            Bitmap orig = new Bitmap(ruta + nombreImagen+ Convert.ToString(numeroDeImagen) + ".png");
            Bitmap bmp = new Bitmap(redimensionarImagen(orig));
            bmp.Save(ruta+nombreImagen+"bitMap.png");
            numeroDeImagen = numeroDeImagen + 1;

            //Limpiar el panel
            graph.Clear(Color.White);
            panel1.Invalidate();

            letraUsuario.aMatriz = matrizCaracteres.lecturaDataUsuario(ruta + nombreImagen + "bitMap.png");
            dataUsuario = matrizCaracteres.creacionDataSet(letraUsuario.aMatriz);


            letraUsuario.similitudConLetraA = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealA),2);
            letraUsuario.similitudConLetraB = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealB), 2);
            letraUsuario.similitudConLetraC = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealC), 2);
            letraUsuario.similitudConLetraD = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealD), 2);
            letraUsuario.similitudConLetraE = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealE), 2);

            letraUsuario.similitudConLetraF = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealF), 2);
            letraUsuario.similitudConLetraG = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealG), 2);
            letraUsuario.similitudConLetraH = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealH), 2);
            letraUsuario.similitudConLetraI = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealI), 2);
            letraUsuario.similitudConLetraJ = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealJ), 2);

            letraUsuario.similitudConLetraK = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealK), 2);
            letraUsuario.similitudConLetraL = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealL), 2);
            letraUsuario.similitudConLetraM = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealM), 2);
            letraUsuario.similitudConLetraN = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealN), 2);
            letraUsuario.similitudConLetraO = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealO), 2);

            letraUsuario.similitudConLetraP = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealP), 2);
            letraUsuario.similitudConLetraQ = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealQ), 2);
            letraUsuario.similitudConLetraR = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealR), 2);
            letraUsuario.similitudConLetraS = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealS), 2);
            letraUsuario.similitudConLetraT = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealT), 2);

            letraUsuario.similitudConLetraU = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealU), 2);
            letraUsuario.similitudConLetraV = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealV), 2);
            letraUsuario.similitudConLetraW = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealW), 2);
            letraUsuario.similitudConLetraX = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealX), 2);
            letraUsuario.similitudConLetraY = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealY), 2);
            letraUsuario.similitudConLetraZ = Math.Round(matrizCaracteres.redNeuronal(dataUsuario, dataIdealZ), 2);

            labelA.Text = "A = " + Convert.ToString(letraUsuario.similitudConLetraA) + "%";
            labelB.Text = "B = " + Convert.ToString(letraUsuario.similitudConLetraB) + "%";
            labelC.Text = "C = " + Convert.ToString(letraUsuario.similitudConLetraC) + "%";
            labelD.Text = "D = " + Convert.ToString(letraUsuario.similitudConLetraD) + "%";
            labelE.Text = "E = " + Convert.ToString(letraUsuario.similitudConLetraE) + "%";
            labelF.Text = "F = " + Convert.ToString(letraUsuario.similitudConLetraF) + "%";
            labelG.Text = "G = " + Convert.ToString(letraUsuario.similitudConLetraG) + "%";
            labelH.Text = "H = " + Convert.ToString(letraUsuario.similitudConLetraH) + "%";
            labelI.Text = "I = " + Convert.ToString(letraUsuario.similitudConLetraI) + "%";
            labelJ.Text = "J = " + Convert.ToString(letraUsuario.similitudConLetraJ) + "%";
            labelK.Text = "K = " + Convert.ToString(letraUsuario.similitudConLetraK) + "%";
            labelL.Text = "L = " + Convert.ToString(letraUsuario.similitudConLetraL) + "%";
            labelM.Text = "M = " + Convert.ToString(letraUsuario.similitudConLetraM) + "%";
            labelN.Text = "N = " + Convert.ToString(letraUsuario.similitudConLetraN) + "%";
            labelO.Text = "O = " + Convert.ToString(letraUsuario.similitudConLetraO) + "%";
            labelP.Text = "P = " + Convert.ToString(letraUsuario.similitudConLetraP) + "%";
            labelQ.Text = "Q = " + Convert.ToString(letraUsuario.similitudConLetraQ) + "%";
            labelR.Text = "R = " + Convert.ToString(letraUsuario.similitudConLetraR) + "%";
            labelS.Text = "S = " + Convert.ToString(letraUsuario.similitudConLetraS) + "%";
            labelT.Text = "T = " + Convert.ToString(letraUsuario.similitudConLetraT) + "%";
            labelU.Text = "U = " + Convert.ToString(letraUsuario.similitudConLetraU) + "%";
            labelV.Text = "V = " + Convert.ToString(letraUsuario.similitudConLetraV) + "%";
            labelW.Text = "W = " + Convert.ToString(letraUsuario.similitudConLetraW) + "%";
            labelX.Text = "X = " + Convert.ToString(letraUsuario.similitudConLetraX) + "%";
            labelY.Text = "Y = " + Convert.ToString(letraUsuario.similitudConLetraY) + "%";
            labelZ.Text = "Z = " + Convert.ToString(letraUsuario.similitudConLetraZ) + "%";

            List<Letras> listaLetras = new List<Letras>()
            {
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraA, letra = "A" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraB, letra = "B" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraC, letra = "C" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraD, letra = "D" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraE, letra = "E" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraF, letra = "F" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraG, letra = "G" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraH, letra = "H" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraI, letra = "I" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraJ, letra = "J" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraK, letra = "K" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraL, letra = "L" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraM, letra = "M" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraN, letra = "N" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraO, letra = "O" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraP, letra = "P" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraQ, letra = "Q" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraR, letra = "R" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraS, letra = "S" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraT, letra = "T" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraU, letra = "U" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraV, letra = "V" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraW, letra = "W" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraX, letra = "X" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraY, letra = "Y" },
                new Letras() { coincidenciaConLetra = letraUsuario.similitudConLetraZ, letra = "Z" },
            };

            List<Letras> letrasOrdenadas = listaLetras.OrderByDescending(numero => numero.coincidenciaConLetra).ToList();

            labelResultado.Text = "La letra es = " + letrasOrdenadas.First().letra;

        }

        class Letras
        {
            public double coincidenciaConLetra { get; set; }
            public string letra { get; set; }
        }

        public static Bitmap redimensionarImagen (Image imagenEntrada)
        {
            //Creamos el bitmap con el ancho y alto
            var imagenRedimencionada = new Bitmap(30, 23);
            //La imagen de entrada la convertimos en bitmap
            Graphics.FromImage(imagenRedimencionada).DrawImage(imagenEntrada, 0, 0, 30, 23);
            Bitmap imagenFinal = new Bitmap(imagenRedimencionada);
            return imagenFinal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Lectura y registro de las letras ideales 
            //Lectura de las letras ideales
            for (ASCII = 65; ASCII < 91; ASCII++)
            {
                char letra = (char)(ASCII);
                switch (letra)
                {
                    case 'A':
                        letrasIdeal.aMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'B':
                        letrasIdeal.bMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'C':
                        letrasIdeal.cMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'D':
                        letrasIdeal.dMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'E':
                        letrasIdeal.eMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'F':
                        letrasIdeal.fMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'G':
                        letrasIdeal.gMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'H':
                        letrasIdeal.hMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'I':
                        letrasIdeal.iMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'J':
                        letrasIdeal.jMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'K':
                        letrasIdeal.kMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'L':
                        letrasIdeal.lMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'M':
                        letrasIdeal.mMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'N':
                        letrasIdeal.nMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'O':
                        letrasIdeal.oMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'P':
                        letrasIdeal.pMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'Q':
                        letrasIdeal.qMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'R':
                        letrasIdeal.rMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'S':
                        letrasIdeal.sMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'T':
                        letrasIdeal.tMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'U':
                        letrasIdeal.uMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'V':
                        letrasIdeal.vMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'W':
                        letrasIdeal.wMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'X':
                        letrasIdeal.xMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'Y':
                        letrasIdeal.yMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                    case 'Z':
                        letrasIdeal.zMatriz = matrizCaracteres.lecturaLetrasIdeales(letra);
                        break;
                }
            }
            #endregion

            graph.Clear(Color.White);
            panel1.Invalidate();

            dataIdealA = matrizCaracteres.creacionDataSet(letrasIdeal.aMatriz);
            dataIdealB = matrizCaracteres.creacionDataSet(letrasIdeal.bMatriz);
            dataIdealC = matrizCaracteres.creacionDataSet(letrasIdeal.cMatriz);
            dataIdealD = matrizCaracteres.creacionDataSet(letrasIdeal.dMatriz);
            dataIdealE = matrizCaracteres.creacionDataSet(letrasIdeal.eMatriz);
            dataIdealF = matrizCaracteres.creacionDataSet(letrasIdeal.fMatriz);
            dataIdealG = matrizCaracteres.creacionDataSet(letrasIdeal.gMatriz);
            dataIdealH = matrizCaracteres.creacionDataSet(letrasIdeal.hMatriz);
            dataIdealI = matrizCaracteres.creacionDataSet(letrasIdeal.iMatriz);
            dataIdealJ = matrizCaracteres.creacionDataSet(letrasIdeal.jMatriz);
            dataIdealK = matrizCaracteres.creacionDataSet(letrasIdeal.kMatriz);
            dataIdealL = matrizCaracteres.creacionDataSet(letrasIdeal.lMatriz);
            dataIdealM = matrizCaracteres.creacionDataSet(letrasIdeal.mMatriz);
            dataIdealN = matrizCaracteres.creacionDataSet(letrasIdeal.nMatriz);
            dataIdealO = matrizCaracteres.creacionDataSet(letrasIdeal.oMatriz);
            dataIdealP = matrizCaracteres.creacionDataSet(letrasIdeal.pMatriz);
            dataIdealQ = matrizCaracteres.creacionDataSet(letrasIdeal.qMatriz);
            dataIdealR = matrizCaracteres.creacionDataSet(letrasIdeal.rMatriz);
            dataIdealS = matrizCaracteres.creacionDataSet(letrasIdeal.sMatriz);
            dataIdealT = matrizCaracteres.creacionDataSet(letrasIdeal.tMatriz);
            dataIdealU = matrizCaracteres.creacionDataSet(letrasIdeal.uMatriz);
            dataIdealV = matrizCaracteres.creacionDataSet(letrasIdeal.vMatriz);
            dataIdealW = matrizCaracteres.creacionDataSet(letrasIdeal.wMatriz);
            dataIdealX = matrizCaracteres.creacionDataSet(letrasIdeal.xMatriz);
            dataIdealY = matrizCaracteres.creacionDataSet(letrasIdeal.yMatriz);
            dataIdealZ = matrizCaracteres.creacionDataSet(letrasIdeal.zMatriz);
            
        }
    }
}
