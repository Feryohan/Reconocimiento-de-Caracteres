using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reconocimiento_de_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dirección de la imagen
            string path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\Data Base (A-Z)\H\img018-020.png";
            //imagen
            Bitmap image = new Bitmap(path, true);
            string valorPixel;
            //Obtenemos el numero de pixeles en lo alto y ancho de la imagen
            Console.WriteLine(image.PhysicalDimension+"\n");


            for(int y=0; y<image.Height; y++)
            {
                for(int x=0; x<image.Width; x++)
                {
                    //Obtiene el color RGB y el brillo del pixel (x,y)
                    Color colorRGB = image.GetPixel(x, y);

                    int valorRed = colorRGB.R;
                    int valorGreen = colorRGB.G;
                    int valorBlue = colorRGB.B;

                    //fórmula NTSC: 0.299 ∙ Rojo + 0.587 ∙ Verde + 0.114 ∙ Azul.
                    double colorGrises = 0.299 * valorRed + 0.587 * valorGreen + 0.114 * valorBlue;

                    //Blanco = 255 = 1
                    //Negro != 255 = 0
                    if(colorGrises != 255 & colorGrises < 250)
                    {
                        valorPixel = " ";
                    }
                    else
                    {
                        valorPixel = "█";
                    }

                    Console.Write(valorPixel);
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
