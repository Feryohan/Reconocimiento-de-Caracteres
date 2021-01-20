using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reconocimiento_de_caracteres
{
    public class LetrasIdeal
    {
        #region Matrices de letras ideales
        public int[,] aIdeal { get; set; }
        public int[,] bIdeal { get; set; }
        public int[,] cIdeal { get; set; }
        public int[,] dIdeal { get; set; }
        public int[,] eIdeal { get; set; }
        public int[,] fIdeal { get; set; }
        public int[,] gIdeal { get; set; }
        public int[,] hIdeal { get; set; }
        public int[,] iIdeal { get; set; }
        public int[,] jIdeal { get; set; }
        public int[,] kIdeal { get; set; }
        public int[,] lIdeal { get; set; }
        public int[,] mIdeal { get; set; }
        public int[,] nIdeal { get; set; }
        public int[,] oIdeal { get; set; }
        public int[,] pIdeal { get; set; }
        public int[,] qIdeal { get; set; }
        public int[,] rIdeal { get; set; }
        public int[,] sIdeal { get; set; }
        public int[,] tIdeal { get; set; }
        public int[,] uIdeal { get; set; }
        public int[,] vIdeal { get; set; }
        public int[,] wIdeal { get; set; }
        public int[,] xIdeal { get; set; }
        public int[,] yIdeal { get; set; }
        public int[,] zIdeal { get; set; }
        #endregion

        #region Método: asignacionBits
        //Se crea una matriz, para cada letra, con un valor de 0 (blanco) o 1 (negro)
        //en cada pixel
        //es una matriz de 23x30
        public static int[,] asignacionBits(char letra)
        {
            //Representación grafica de la imagen
            string valorPixel;
            //Arreglo para guardar la información de los pixeles
            int[,] arregloBits = new int[23, 30];
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
                        arregloBits[y, x] = 1;
                    }
                    else
                    {
                        //Blanco
                        valorPixel = "█";
                        arregloBits[y, x] = 0;
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
