using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Encog.Engine.Network.Activation;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Networks.Training;
using Encog.Neural.Networks.Structure;
using Encog.Neural.Networks.Training.Propagation.Back;
using Encog.ML.Data;
using Encog.ML.Data.Basic;

namespace Reconocimiento_de_caracteres
{
    public class matrizCaracteres
    {
        #region Atributos: Matriz, Dirección y Numero de las Letras
        public double[,] aMatriz { get; set; }
        public string aDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\A\A";
        public int aNumero = 13;
        public double similitudConLetraA;
        public string letraA = "A";
        public double[,] bMatriz { get; set; }
        public string bDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\B\B";
        public int bNumero = 14;
        public double similitudConLetraB;
        public string letraB = "B";
        public double[,] cMatriz { get; set; }
        public string cDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\C\C";
        public int cNumero = 14;
        public double similitudConLetraC;
        public string letraC = "C";
        public double[,] dMatriz { get; set; }
        public string dDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\D\D";
        public int dNumero = 14;
        public double similitudConLetraD;
        public string letraD = "D";
        public double[,] eMatriz { get; set; }
        public string eDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\E\E";
        public int eNumero = 14;
        public double similitudConLetraE;
        public string letraE = "E";
        public double[,] fMatriz { get; set; }
        public string fDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\F\F";
        public int fNumero = 14;
        public double similitudConLetraF;
        public string letraF = "F";
        public double[,] gMatriz { get; set; }
        public string gDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\G\G";
        public int gNumero = 12;
        public double similitudConLetraG;
        public string letraG = "G";
        public double[,] hMatriz { get; set; }
        public string hDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\H\H";
        public int hNumero = 14;
        public double similitudConLetraH;
        public string letraH = "H";
        public double[,] iMatriz { get; set; }
        public string iDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\I\I";
        public int iNumero = 11;
        public double similitudConLetraI;
        public string letraI = "I";
        public double[,] jMatriz { get; set; }
        public string jDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\J\J";
        public int jNumero = 14;
        public double similitudConLetraJ;
        public string letraJ = "J";
        public double[,] kMatriz { get; set; }
        public string kDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\K\K";
        public int kNumero = 13;
        public double similitudConLetraK;
        public string letraK = "K";
        public double[,] lMatriz { get; set; }
        public string lDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\L\L";
        public int lNumero = 14;
        public double similitudConLetraL;
        public string letraL = "L";
        public double[,] mMatriz { get; set; }
        public string mDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\M\M";
        public int mNumero = 11;
        public double similitudConLetraM;
        public string letraM = "M";
        public double[,] nMatriz { get; set; }
        public string nDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\N\N";
        public int nNumero = 14;
        public double similitudConLetraN;
        public string letraN = "N";
        public double[,] oMatriz { get; set; }
        public string oDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\O\O";
        public int oNumero = 14;
        public double similitudConLetraO;
        public string letraO = "O";
        public double[,] pMatriz { get; set; }
        public string pDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\P\P";
        public int pNumero = 14;
        public double similitudConLetraP;
        public string letraP = "P";
        public double[,] qMatriz { get; set; }
        public string qDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Q\Q";
        public int qNumero = 12;
        public double similitudConLetraQ;
        public string letraQ = "Q";
        public double[,] rMatriz { get; set; }
        public string rDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\R\R";
        public int rNumero = 12;
        public double similitudConLetraR;
        public string letraR = "R";
        public double[,] sMatriz { get; set; }
        public string sDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\S\S";
        public int sNumero = 14;
        public double similitudConLetraS;
        public string letraS = "S";
        public double[,] tMatriz { get; set; }
        public string tDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\T\T";
        public int tNumero = 14;
        public double similitudConLetraT;
        public string letraT = "T";
        public double[,] uMatriz { get; set; }
        public string uDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\U\U";
        public int uNumero = 9;
        public double similitudConLetraU;
        public string letraU = "U";
        public double[,] vMatriz { get; set; }
        public string vDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\V\V";
        public int vNumero = 14;
        public double similitudConLetraV;
        public string letraV = "V";
        public double[,] wMatriz { get; set; }
        public string wDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\W\W";
        public int wNumero = 8;
        public double similitudConLetraW;
        public string letraW = "W";
        public double[,] xMatriz { get; set; }
        public string xDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\X\X";
        public int xNumero = 14;
        public double similitudConLetraX;
        public string letraX = "X";
        public double[,] yMatriz { get; set; }
        public string yDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Y\Y";
        public int yNumero = 12;
        public double similitudConLetraY;
        public string letraY = "Y";
        public double[,] zMatriz { get; set; }
        public string zDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Z\Z";
        public int zNumero = 14;
        public double similitudConLetraZ;
        public string letraZ = "Z";
        #endregion

        #region Método: asignacionBits letras Ideales
        //Se crea una matriz, para cada letra, con un valor de 0 (blanco) o 1 (negro)
        //en cada pixel
        //es una matriz de 23x30
        public static double[,] lecturaLetrasIdeales(char letra)
        {
            //Representación grafica de la imagen
            string valorPixel;
            //Arreglo para guardar la información de los pixeles
            double[,] arregloBits = new double[23, 30];
            //Dirección de la imagen
            string path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Letras Ideales\" + letra + ".png";
            //imagen
            Bitmap image = new Bitmap(path, true);
            //Ciclo para extraer el 0 o 1 de cada pixel
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    //Obtiene el color RGB y el brillo del pixel (x,y)
                    Color colorRGB = image.GetPixel(x, y);

                    int valorRed = colorRGB.R;
                    int valorGreen = colorRGB.G;
                    int valorBlue = colorRGB.B;

                    //fórmula NTSC: 0.299 ∙ Rojo + 0.587 ∙ Verde + 0.114 ∙ Azul.
                    double colorGrises = 0.299 * valorRed + 0.587 * valorGreen + 0.114 * valorBlue;

                    //Blanco = 255 = 0
                    //Negro != 255 = 1
                    if (colorGrises != 255 & colorGrises < 245)
                    {
                        //Negro
                        valorPixel = " ";
                        arregloBits[y, x] = 1.0;
                    }
                    else
                    {
                        //Blanco
                        valorPixel = "█";
                        arregloBits[y, x] = 0.0;
                    }
                   // Console.Write(valorPixel);
                }
                //Console.Write("\n");
            }
            return arregloBits;
        }
        #endregion

        #region Método: asignacionBits letras DataBase
        //Se crea una matriz, para cada letra, con un valor de 0 (blanco) o 1 (negro)
        //en cada pixel
        //es una matriz de 23x30
        public static double[,] lecturaDataBase(string direccion, int letraNumero)
        {
            //Representación grafica de la imagen
            string valorPixel;
            //Arreglo para guardar la información de los pixeles
            double[,] arregloBits = new double[23, 30];
            //Dirección de la imagen
            string path = direccion + Convert.ToString(letraNumero) + ".png";
            //imagen
            Bitmap image = new Bitmap(path, true);
            //Ciclo para extraer el 0 o 1 de cada pixel
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    //Obtiene el color RGB y el brillo del pixel (x,y)
                    Color colorRGB = image.GetPixel(x, y);

                    int valorRed = colorRGB.R;
                    int valorGreen = colorRGB.G;
                    int valorBlue = colorRGB.B;

                    //fórmula NTSC: 0.299 ∙ Rojo + 0.587 ∙ Verde + 0.114 ∙ Azul.
                    double colorGrises = 0.299 * valorRed + 0.587 * valorGreen + 0.114 * valorBlue;

                    //Blanco = 255 = 0
                    //Negro != 255 = 1
                    if (colorGrises != 255 & colorGrises < 245)
                    {
                        //Negro
                        valorPixel = " ";
                        arregloBits[y, x] = 1.0;
                    }
                    else
                    {
                        //Blanco
                        valorPixel = "█";
                        arregloBits[y, x] = 0.0;
                    }
                   // Console.Write(valorPixel);
                }
              //  Console.Write("\n");
            }
            return arregloBits;
        }
        #endregion

        #region Método: Creación de dataSet para BasicNetwork
        //De la estructura -> IMLDataSet dataset = new BasicMLDataSet(datosInput, datosIdeal);
        //Los datosInput y datosIdeal deben ser del tipo double[][]
        //Por lo tanto transformamos las matrices que creamos de tipo double[,] a este formato
        public static double[][] creacionDataSete(double[,] matrizInformacion)
        {
            double[][] dataSet =
            {
                new double[]{matrizInformacion[0,0],matrizInformacion[0,1],matrizInformacion[0,2],matrizInformacion[0,3],matrizInformacion[0,4],matrizInformacion[0,5],matrizInformacion[0,6],matrizInformacion[0,7],matrizInformacion[0,8],matrizInformacion[0,9],matrizInformacion[0,10],matrizInformacion[0,11],matrizInformacion[0,12],matrizInformacion[0,13],matrizInformacion[0,14],matrizInformacion[0,15],matrizInformacion[0,16],matrizInformacion[0,17],matrizInformacion[0,18],matrizInformacion[0,19],matrizInformacion[0,20],matrizInformacion[0,21],matrizInformacion[0,22],matrizInformacion[0,23],matrizInformacion[0,24],matrizInformacion[0,25],matrizInformacion[0,26],matrizInformacion[0,27],matrizInformacion[0,28],matrizInformacion[0,29]},
                new double[]{matrizInformacion[1,0],matrizInformacion[1,1],matrizInformacion[1,2],matrizInformacion[1,3],matrizInformacion[1,4],matrizInformacion[1,5],matrizInformacion[1,6],matrizInformacion[1,7],matrizInformacion[1,8],matrizInformacion[1,9],matrizInformacion[1,10],matrizInformacion[1,11],matrizInformacion[1,12],matrizInformacion[1,13],matrizInformacion[1,14],matrizInformacion[1,15],matrizInformacion[1,16],matrizInformacion[1,17],matrizInformacion[1,18],matrizInformacion[1,19],matrizInformacion[1,20],matrizInformacion[1,21],matrizInformacion[1,22],matrizInformacion[1,23],matrizInformacion[1,24],matrizInformacion[1,25],matrizInformacion[1,26],matrizInformacion[1,27],matrizInformacion[1,28],matrizInformacion[1,29]},
                new double[]{matrizInformacion[2,0],matrizInformacion[2,1],matrizInformacion[2,2],matrizInformacion[2,3],matrizInformacion[2,4],matrizInformacion[2,5],matrizInformacion[2,6],matrizInformacion[2,7],matrizInformacion[2,8],matrizInformacion[2,9],matrizInformacion[2,10],matrizInformacion[2,11],matrizInformacion[2,12],matrizInformacion[2,13],matrizInformacion[2,14],matrizInformacion[2,15],matrizInformacion[2,16],matrizInformacion[2,17],matrizInformacion[2,18],matrizInformacion[2,19],matrizInformacion[2,20],matrizInformacion[2,21],matrizInformacion[2,22],matrizInformacion[2,23],matrizInformacion[2,24],matrizInformacion[2,25],matrizInformacion[2,26],matrizInformacion[2,27],matrizInformacion[2,28],matrizInformacion[2,29]},
                new double[]{matrizInformacion[3,0],matrizInformacion[3,1],matrizInformacion[3,2],matrizInformacion[3,3],matrizInformacion[3,4],matrizInformacion[3,5],matrizInformacion[3,6],matrizInformacion[3,7],matrizInformacion[3,8],matrizInformacion[3,9],matrizInformacion[3,10],matrizInformacion[3,11],matrizInformacion[3,12],matrizInformacion[3,13],matrizInformacion[3,14],matrizInformacion[3,15],matrizInformacion[3,16],matrizInformacion[3,17],matrizInformacion[3,18],matrizInformacion[3,19],matrizInformacion[3,20],matrizInformacion[3,21],matrizInformacion[3,22],matrizInformacion[3,23],matrizInformacion[3,24],matrizInformacion[3,25],matrizInformacion[3,26],matrizInformacion[3,27],matrizInformacion[3,28],matrizInformacion[3,29]},
                new double[]{matrizInformacion[4,0],matrizInformacion[4,1],matrizInformacion[4,2],matrizInformacion[4,3],matrizInformacion[4,4],matrizInformacion[4,5],matrizInformacion[4,6],matrizInformacion[4,7],matrizInformacion[4,8],matrizInformacion[4,9],matrizInformacion[4,10],matrizInformacion[4,11],matrizInformacion[4,12],matrizInformacion[4,13],matrizInformacion[4,14],matrizInformacion[4,15],matrizInformacion[4,16],matrizInformacion[4,17],matrizInformacion[4,18],matrizInformacion[4,19],matrizInformacion[4,20],matrizInformacion[4,21],matrizInformacion[4,22],matrizInformacion[4,23],matrizInformacion[4,24],matrizInformacion[4,25],matrizInformacion[4,26],matrizInformacion[4,27],matrizInformacion[4,28],matrizInformacion[4,29]},
                new double[]{matrizInformacion[5,0],matrizInformacion[5,1],matrizInformacion[5,2],matrizInformacion[5,3],matrizInformacion[5,4],matrizInformacion[5,5],matrizInformacion[5,6],matrizInformacion[5,7],matrizInformacion[5,8],matrizInformacion[5,9],matrizInformacion[5,10],matrizInformacion[5,11],matrizInformacion[5,12],matrizInformacion[5,13],matrizInformacion[5,14],matrizInformacion[5,15],matrizInformacion[5,16],matrizInformacion[5,17],matrizInformacion[5,18],matrizInformacion[5,19],matrizInformacion[5,20],matrizInformacion[5,21],matrizInformacion[5,22],matrizInformacion[5,23],matrizInformacion[5,24],matrizInformacion[5,25],matrizInformacion[5,26],matrizInformacion[5,27],matrizInformacion[5,28],matrizInformacion[5,29]},
                new double[]{matrizInformacion[6,0],matrizInformacion[6,1],matrizInformacion[6,2],matrizInformacion[6,3],matrizInformacion[6,4],matrizInformacion[6,5],matrizInformacion[6,6],matrizInformacion[6,7],matrizInformacion[6,8],matrizInformacion[6,9],matrizInformacion[6,10],matrizInformacion[6,11],matrizInformacion[6,12],matrizInformacion[6,13],matrizInformacion[6,14],matrizInformacion[6,15],matrizInformacion[6,16],matrizInformacion[6,17],matrizInformacion[6,18],matrizInformacion[6,19],matrizInformacion[6,20],matrizInformacion[6,21],matrizInformacion[6,22],matrizInformacion[6,23],matrizInformacion[6,24],matrizInformacion[6,25],matrizInformacion[6,26],matrizInformacion[6,27],matrizInformacion[6,28],matrizInformacion[6,29]},
                new double[]{matrizInformacion[7,0],matrizInformacion[7,1],matrizInformacion[7,2],matrizInformacion[7,3],matrizInformacion[7,4],matrizInformacion[7,5],matrizInformacion[7,6],matrizInformacion[7,7],matrizInformacion[7,8],matrizInformacion[7,9],matrizInformacion[7,10],matrizInformacion[7,11],matrizInformacion[7,12],matrizInformacion[7,13],matrizInformacion[7,14],matrizInformacion[7,15],matrizInformacion[7,16],matrizInformacion[7,17],matrizInformacion[7,18],matrizInformacion[7,19],matrizInformacion[7,20],matrizInformacion[7,21],matrizInformacion[7,22],matrizInformacion[7,23],matrizInformacion[7,24],matrizInformacion[7,25],matrizInformacion[7,26],matrizInformacion[7,27],matrizInformacion[7,28],matrizInformacion[7,29]},
                new double[]{matrizInformacion[8,0],matrizInformacion[8,1],matrizInformacion[8,2],matrizInformacion[8,3],matrizInformacion[8,4],matrizInformacion[8,5],matrizInformacion[8,6],matrizInformacion[8,7],matrizInformacion[8,8],matrizInformacion[8,9],matrizInformacion[8,10],matrizInformacion[8,11],matrizInformacion[8,12],matrizInformacion[8,13],matrizInformacion[8,14],matrizInformacion[8,15],matrizInformacion[8,16],matrizInformacion[8,17],matrizInformacion[8,18],matrizInformacion[8,19],matrizInformacion[8,20],matrizInformacion[8,21],matrizInformacion[8,22],matrizInformacion[8,23],matrizInformacion[8,24],matrizInformacion[8,25],matrizInformacion[8,26],matrizInformacion[8,27],matrizInformacion[8,28],matrizInformacion[8,29]},
                new double[]{matrizInformacion[9,0],matrizInformacion[9,1],matrizInformacion[9,2],matrizInformacion[9,3],matrizInformacion[9,4],matrizInformacion[9,5],matrizInformacion[9,6],matrizInformacion[9,7],matrizInformacion[9,8],matrizInformacion[9,9],matrizInformacion[9,10],matrizInformacion[9,11],matrizInformacion[9,12],matrizInformacion[9,13],matrizInformacion[9,14],matrizInformacion[9,15],matrizInformacion[9,16],matrizInformacion[9,17],matrizInformacion[9,18],matrizInformacion[9,19],matrizInformacion[9,20],matrizInformacion[9,21],matrizInformacion[9,22],matrizInformacion[9,23],matrizInformacion[9,24],matrizInformacion[9,25],matrizInformacion[9,26],matrizInformacion[9,27],matrizInformacion[9,28],matrizInformacion[9,29]},
                new double[]{matrizInformacion[10,0],matrizInformacion[10,1],matrizInformacion[10,2],matrizInformacion[10,3],matrizInformacion[10,4],matrizInformacion[10,5],matrizInformacion[10,6],matrizInformacion[10,7],matrizInformacion[10,8],matrizInformacion[10,9],matrizInformacion[10,10],matrizInformacion[10,11],matrizInformacion[10,12],matrizInformacion[10,13],matrizInformacion[10,14],matrizInformacion[10,15],matrizInformacion[10,16],matrizInformacion[10,17],matrizInformacion[10,18],matrizInformacion[10,19],matrizInformacion[10,20],matrizInformacion[10,21],matrizInformacion[10,22],matrizInformacion[10,23],matrizInformacion[10,24],matrizInformacion[10,25],matrizInformacion[10,26],matrizInformacion[10,27],matrizInformacion[10,28],matrizInformacion[10,29]},
                new double[]{matrizInformacion[11,0],matrizInformacion[11,1],matrizInformacion[11,2],matrizInformacion[11,3],matrizInformacion[11,4],matrizInformacion[11,5],matrizInformacion[11,6],matrizInformacion[11,7],matrizInformacion[11,8],matrizInformacion[11,9],matrizInformacion[11,10],matrizInformacion[11,11],matrizInformacion[11,12],matrizInformacion[11,13],matrizInformacion[11,14],matrizInformacion[11,15],matrizInformacion[11,16],matrizInformacion[11,17],matrizInformacion[11,18],matrizInformacion[11,19],matrizInformacion[11,20],matrizInformacion[11,21],matrizInformacion[11,22],matrizInformacion[11,23],matrizInformacion[11,24],matrizInformacion[11,25],matrizInformacion[11,26],matrizInformacion[11,27],matrizInformacion[11,28],matrizInformacion[11,29]},
                new double[]{matrizInformacion[12,0],matrizInformacion[12,1],matrizInformacion[12,2],matrizInformacion[12,3],matrizInformacion[12,4],matrizInformacion[12,5],matrizInformacion[12,6],matrizInformacion[12,7],matrizInformacion[12,8],matrizInformacion[12,9],matrizInformacion[12,10],matrizInformacion[12,11],matrizInformacion[12,12],matrizInformacion[12,13],matrizInformacion[12,14],matrizInformacion[12,15],matrizInformacion[12,16],matrizInformacion[12,17],matrizInformacion[12,18],matrizInformacion[12,19],matrizInformacion[12,20],matrizInformacion[12,21],matrizInformacion[12,22],matrizInformacion[12,23],matrizInformacion[12,24],matrizInformacion[12,25],matrizInformacion[12,26],matrizInformacion[12,27],matrizInformacion[12,28],matrizInformacion[12,29]},
                new double[]{matrizInformacion[13,0],matrizInformacion[13,1],matrizInformacion[13,2],matrizInformacion[13,3],matrizInformacion[13,4],matrizInformacion[13,5],matrizInformacion[13,6],matrizInformacion[13,7],matrizInformacion[13,8],matrizInformacion[13,9],matrizInformacion[13,10],matrizInformacion[13,11],matrizInformacion[13,12],matrizInformacion[13,13],matrizInformacion[13,14],matrizInformacion[13,15],matrizInformacion[13,16],matrizInformacion[13,17],matrizInformacion[13,18],matrizInformacion[13,19],matrizInformacion[13,20],matrizInformacion[13,21],matrizInformacion[13,22],matrizInformacion[13,23],matrizInformacion[13,24],matrizInformacion[13,25],matrizInformacion[13,26],matrizInformacion[13,27],matrizInformacion[13,28],matrizInformacion[13,29]},
                new double[]{matrizInformacion[14,0],matrizInformacion[14,1],matrizInformacion[14,2],matrizInformacion[14,3],matrizInformacion[14,4],matrizInformacion[14,5],matrizInformacion[14,6],matrizInformacion[14,7],matrizInformacion[14,8],matrizInformacion[14,9],matrizInformacion[14,10],matrizInformacion[14,11],matrizInformacion[14,12],matrizInformacion[14,13],matrizInformacion[14,14],matrizInformacion[14,15],matrizInformacion[14,16],matrizInformacion[14,17],matrizInformacion[14,18],matrizInformacion[14,19],matrizInformacion[14,20],matrizInformacion[14,21],matrizInformacion[14,22],matrizInformacion[14,23],matrizInformacion[14,24],matrizInformacion[14,25],matrizInformacion[14,26],matrizInformacion[14,27],matrizInformacion[14,28],matrizInformacion[14,29]},
                new double[]{matrizInformacion[15,0],matrizInformacion[15,1],matrizInformacion[15,2],matrizInformacion[15,3],matrizInformacion[15,4],matrizInformacion[15,5],matrizInformacion[15,6],matrizInformacion[15,7],matrizInformacion[15,8],matrizInformacion[15,9],matrizInformacion[15,10],matrizInformacion[15,11],matrizInformacion[15,12],matrizInformacion[15,13],matrizInformacion[15,14],matrizInformacion[15,15],matrizInformacion[15,16],matrizInformacion[15,17],matrizInformacion[15,18],matrizInformacion[15,19],matrizInformacion[15,20],matrizInformacion[15,21],matrizInformacion[15,22],matrizInformacion[15,23],matrizInformacion[15,24],matrizInformacion[15,25],matrizInformacion[15,26],matrizInformacion[15,27],matrizInformacion[15,28],matrizInformacion[15,29]},
                new double[]{matrizInformacion[16,0],matrizInformacion[16,1],matrizInformacion[16,2],matrizInformacion[16,3],matrizInformacion[16,4],matrizInformacion[16,5],matrizInformacion[16,6],matrizInformacion[16,7],matrizInformacion[16,8],matrizInformacion[16,9],matrizInformacion[16,10],matrizInformacion[16,11],matrizInformacion[16,12],matrizInformacion[16,13],matrizInformacion[16,14],matrizInformacion[16,15],matrizInformacion[16,16],matrizInformacion[16,17],matrizInformacion[16,18],matrizInformacion[16,19],matrizInformacion[16,20],matrizInformacion[16,21],matrizInformacion[16,22],matrizInformacion[16,23],matrizInformacion[16,24],matrizInformacion[16,25],matrizInformacion[16,26],matrizInformacion[16,27],matrizInformacion[16,28],matrizInformacion[16,29]},
                new double[]{matrizInformacion[17,0],matrizInformacion[17,1],matrizInformacion[17,2],matrizInformacion[17,3],matrizInformacion[17,4],matrizInformacion[17,5],matrizInformacion[17,6],matrizInformacion[17,7],matrizInformacion[17,8],matrizInformacion[17,9],matrizInformacion[17,10],matrizInformacion[17,11],matrizInformacion[17,12],matrizInformacion[17,13],matrizInformacion[17,14],matrizInformacion[17,15],matrizInformacion[17,16],matrizInformacion[17,17],matrizInformacion[17,18],matrizInformacion[17,19],matrizInformacion[17,20],matrizInformacion[17,21],matrizInformacion[17,22],matrizInformacion[17,23],matrizInformacion[17,24],matrizInformacion[17,25],matrizInformacion[17,26],matrizInformacion[17,27],matrizInformacion[17,28],matrizInformacion[17,29]},
                new double[]{matrizInformacion[18,0],matrizInformacion[18,1],matrizInformacion[18,2],matrizInformacion[18,3],matrizInformacion[18,4],matrizInformacion[18,5],matrizInformacion[18,6],matrizInformacion[18,7],matrizInformacion[18,8],matrizInformacion[18,9],matrizInformacion[18,10],matrizInformacion[18,11],matrizInformacion[18,12],matrizInformacion[18,13],matrizInformacion[18,14],matrizInformacion[18,15],matrizInformacion[18,16],matrizInformacion[18,17],matrizInformacion[18,18],matrizInformacion[18,19],matrizInformacion[18,20],matrizInformacion[18,21],matrizInformacion[18,22],matrizInformacion[18,23],matrizInformacion[18,24],matrizInformacion[18,25],matrizInformacion[18,26],matrizInformacion[18,27],matrizInformacion[18,28],matrizInformacion[18,29]},
                new double[]{matrizInformacion[19,0],matrizInformacion[19,1],matrizInformacion[19,2],matrizInformacion[19,3],matrizInformacion[19,4],matrizInformacion[19,5],matrizInformacion[19,6],matrizInformacion[19,7],matrizInformacion[19,8],matrizInformacion[19,9],matrizInformacion[19,10],matrizInformacion[19,11],matrizInformacion[19,12],matrizInformacion[19,13],matrizInformacion[19,14],matrizInformacion[19,15],matrizInformacion[19,16],matrizInformacion[19,17],matrizInformacion[19,18],matrizInformacion[19,19],matrizInformacion[19,20],matrizInformacion[19,21],matrizInformacion[19,22],matrizInformacion[19,23],matrizInformacion[19,24],matrizInformacion[19,25],matrizInformacion[19,26],matrizInformacion[19,27],matrizInformacion[19,28],matrizInformacion[19,29]},
                new double[]{matrizInformacion[20,0],matrizInformacion[20,1],matrizInformacion[20,2],matrizInformacion[20,3],matrizInformacion[20,4],matrizInformacion[20,5],matrizInformacion[20,6],matrizInformacion[20,7],matrizInformacion[20,8],matrizInformacion[20,9],matrizInformacion[20,10],matrizInformacion[20,11],matrizInformacion[20,12],matrizInformacion[20,13],matrizInformacion[20,14],matrizInformacion[20,15],matrizInformacion[20,16],matrizInformacion[20,17],matrizInformacion[20,18],matrizInformacion[20,19],matrizInformacion[20,20],matrizInformacion[20,21],matrizInformacion[20,22],matrizInformacion[20,23],matrizInformacion[20,24],matrizInformacion[20,25],matrizInformacion[20,26],matrizInformacion[20,27],matrizInformacion[20,28],matrizInformacion[20,29]},
                new double[]{matrizInformacion[21,0],matrizInformacion[21,1],matrizInformacion[21,2],matrizInformacion[21,3],matrizInformacion[21,4],matrizInformacion[21,5],matrizInformacion[21,6],matrizInformacion[21,7],matrizInformacion[21,8],matrizInformacion[21,9],matrizInformacion[21,10],matrizInformacion[21,11],matrizInformacion[21,12],matrizInformacion[21,13],matrizInformacion[21,14],matrizInformacion[21,15],matrizInformacion[21,16],matrizInformacion[21,17],matrizInformacion[21,18],matrizInformacion[21,19],matrizInformacion[21,20],matrizInformacion[21,21],matrizInformacion[21,22],matrizInformacion[21,23],matrizInformacion[21,24],matrizInformacion[21,25],matrizInformacion[21,26],matrizInformacion[21,27],matrizInformacion[21,28],matrizInformacion[21,29]},
                new double[]{matrizInformacion[22,0],matrizInformacion[22,1],matrizInformacion[22,2],matrizInformacion[22,3],matrizInformacion[22,4],matrizInformacion[22,5],matrizInformacion[22,6],matrizInformacion[22,7],matrizInformacion[22,8],matrizInformacion[22,9],matrizInformacion[22,10],matrizInformacion[22,11],matrizInformacion[22,12],matrizInformacion[22,13],matrizInformacion[22,14],matrizInformacion[22,15],matrizInformacion[22,16],matrizInformacion[22,17],matrizInformacion[22,18],matrizInformacion[22,19],matrizInformacion[22,20],matrizInformacion[22,21],matrizInformacion[22,22],matrizInformacion[22,23],matrizInformacion[22,24],matrizInformacion[22,25],matrizInformacion[22,26],matrizInformacion[22,27],matrizInformacion[22,28],matrizInformacion[22,29]}
            };
            return dataSet;
        }
        #endregion

        #region Método: Uso de redNeuronal
        public static double redNeuronal(double[,] letrasInput, double[,] letrasIdeal)
        {
            //dataSet
            double[][] dataInput = matrizCaracteres.creacionDataSete(letrasInput);
            double[][] dataIdeal = matrizCaracteres.creacionDataSete(letrasIdeal);

            //Creando network
            BasicNetwork network = new BasicNetwork();
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 30)); //30 neuronas de entrada
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 25)); //5 neuronas ocultas
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 30)); //1 neurona de salida
            network.Structure.FinalizeStructure();
            network.Reset();

            //Entrenamiento
            IMLDataSet dataset = new BasicMLDataSet(dataInput, dataIdeal);
            ITrain learner = new Backpropagation(network, dataset);
            for (int i = 0; i < 3000; i++)
            {
                learner.Iteration();
                //Console.WriteLine("error: " + learner.Error);
            }


            Console.WriteLine("error final: " + learner.Error);
            //Utilizando el error de la red
            double similitud = 100 - learner.Error * 1000;

            //Prueba
            foreach (BasicMLDataPair pair in dataset)
            {
                IMLData result = network.Compute(pair.Input);
                double error = result[0] + result[1] + result[2] + result[3] + result[4] + result[5] + result[6] + result[7] + result[8] + result[9] + result[10] + result[11] + result[12] + result[13] + result[14] + result[15] + result[16] + result[17] + result[18] + result[19] + result[20] + result[21] + result[22] + result[23] + result[24] + result[25] + result[26] + result[27] + result[28] + result[29];
                error = error / 30;
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29} = {30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59} -> {60}", pair.Input[0], pair.Input[1], pair.Input[2], pair.Input[3], pair.Input[4], pair.Input[5], pair.Input[6], pair.Input[7], pair.Input[8], pair.Input[9], pair.Input[10], pair.Input[11], pair.Input[12], pair.Input[13], pair.Input[14], pair.Input[15], pair.Input[16], pair.Input[17], pair.Input[18], pair.Input[19], pair.Ideal[20], pair.Input[21], pair.Input[22], pair.Input[23], pair.Input[24], pair.Input[25], pair.Input[26], pair.Input[27], pair.Input[28], pair.Input[29], pair.Ideal[0], pair.Ideal[1], pair.Ideal[2], pair.Ideal[3], pair.Ideal[4], pair.Ideal[5], pair.Ideal[6], pair.Ideal[7], pair.Ideal[8], pair.Ideal[9], pair.Ideal[10], pair.Ideal[11], pair.Ideal[12], pair.Ideal[13], pair.Ideal[14], pair.Ideal[15], pair.Ideal[16], pair.Ideal[17], pair.Ideal[18], pair.Ideal[19], pair.Ideal[20], pair.Ideal[21], pair.Ideal[22], pair.Ideal[23], pair.Ideal[24], pair.Ideal[25], pair.Ideal[26], pair.Ideal[27], pair.Ideal[28], pair.Ideal[29], error);
            }

            Console.WriteLine("Similitud de la letra = " + similitud);
            return similitud;
        }
        #endregion

        #region Método: Entrenamiento redNeuronal
        #endregion
    }
}
