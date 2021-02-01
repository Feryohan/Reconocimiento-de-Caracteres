using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reconocimiento_de_caracteres
{
    public class matrizCaracteres
    {
        #region Matriz, Dirección y Numero de las Letras
        public double[,] aMatriz { get; set; }
        public string aDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\A\A";
        public int aNumero = 13;
        public double[,] bMatriz { get; set; }
        public string bDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\B\B";
        public int bNumero = 14;
        public double[,] cMatriz { get; set; }
        public string cDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\C\C";
        public int cNumero = 14;
        public double[,] dMatriz { get; set; }
        public string dDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\D\D";
        public int dNumero = 14;
        public double[,] eMatriz { get; set; }
        public string eDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\E\E";
        public int eNumero = 14;
        public double[,] fMatriz { get; set; }
        public string fDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\F\F";
        public int fNumero = 14;
        public double[,] gMatriz { get; set; }
        public string gDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\G\G";
        public int gNumero = 12;
        public double[,] hMatriz { get; set; }
        public string hDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\H\H";
        public int hNumero = 14;
        public double[,] iMatriz { get; set; }
        public string iDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\I\I";
        public int iNumero = 11;
        public double[,] jMatriz { get; set; }
        public string jDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\J\J";
        public int jNumero = 14;
        public double[,] kMatriz { get; set; }
        public string kDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\K\K";
        public int kNumero = 13;
        public double[,] lMatriz { get; set; }
        public string lDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\L\L";
        public int lNumero = 14;
        public double[,] mMatriz { get; set; }
        public string mDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\M\M";
        public int mNumero = 11;
        public double[,] nMatriz { get; set; }
        public string nDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\N\N";
        public int nNumero = 14;
        public double[,] oMatriz { get; set; }
        public string oDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\O\O";
        public int oNumero = 14;
        public double[,] pMatriz { get; set; }
        public string pDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\P\P";
        public int pNumero = 14;
        public double[,] qMatriz { get; set; }
        public string qDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Q\Q";
        public int qNumero = 12;
        public double[,] rMatriz { get; set; }
        public string rDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\R\R";
        public int rNumero = 12;
        public double[,] sMatriz { get; set; }
        public string sDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\S\S";
        public int sNumero = 14;
        public double[,] tMatriz { get; set; }
        public string tDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\T\T";
        public int tNumero = 14;
        public double[,] uMatriz { get; set; }
        public string uDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\U\U";
        public int uNumero = 9;
        public double[,] vMatriz { get; set; }
        public string vDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\V\V";
        public int vNumero = 14;
        public double[,] wMatriz { get; set; }
        public string wDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\W\W";
        public int wNumero = 8;
        public double[,] xMatriz { get; set; }
        public string xDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\X\X";
        public int xNumero = 14;
        public double[,] yMatriz { get; set; }
        public string yDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Y\Y";
        public int yNumero = 12;
        public double[,] zMatriz { get; set; }
        public string zDireccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Z\Z";
        public int zNumero = 14;
        #endregion

        #region Método: asignacionBits
        //Se crea una matriz, para cada letra, con un valor de 0 (blanco) o 1 (negro)
        //en cada pixel
        //es una matriz de 23x30
        public static double[,] asignacionBits(char letra)
        {
            //Representación grafica de la imagen
            string valorPixel;
            //Arreglo para guardar la información de los pixeles
            double[,] arregloBits = new double[23, 30];
            //Dirección de la imagen
            string path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\Letras de Entrada\" + letra + ".png";
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
                    Console.Write(valorPixel);
                }
                Console.Write("\n");
            }
            return arregloBits;
        }
        #endregion

        #region Método:lecturaDataBase
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
                    Console.Write(valorPixel);
                }
                Console.Write("\n");
            }
            return arregloBits;
        }
        #endregion

    }
}
