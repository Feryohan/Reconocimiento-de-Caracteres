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
    class Program
    {
        static void Main(string[] args)
        {

            int ASCII;
            //Objeto para guardar los valors de 0 y 1 
            //de las letras que marcan la salida que las neuronas deben tener 
            matrizCaracteres letrasIdeal = new matrizCaracteres();
            //Objeto para leer las letras del dataBase 
            matrizCaracteres letrasDataBase = new matrizCaracteres();
            matrizCaracteres letrasUsuario = new matrizCaracteres();

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


            /*   #region Lectura de las letras DataBase
               //Lectura letras B
               for (int i = 1; i <= letrasDataBase.bNumero-1; i++)
               {
                   letrasDataBase.bMatriz = matrizCaracteres.lecturaDataBase(letrasDataBase.bDireccion, i);
               }
               #endregion
            */

            string direccion = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\PROYECTO Redes Neuronales\LetrasUsuario\ImagenUsuariobitMap.png";
            letrasUsuario.aMatriz = matrizCaracteres.lecturaDataUsuario(direccion);
            letrasUsuario.similitudConLetraA = matrizCaracteres.redNeuronal(letrasIdeal.aMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraB = matrizCaracteres.redNeuronal(letrasIdeal.bMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraC = matrizCaracteres.redNeuronal(letrasIdeal.cMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraD = matrizCaracteres.redNeuronal(letrasIdeal.dMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraE = matrizCaracteres.redNeuronal(letrasIdeal.eMatriz, letrasUsuario.aMatriz);

            letrasUsuario.similitudConLetraF = matrizCaracteres.redNeuronal(letrasIdeal.fMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraG = matrizCaracteres.redNeuronal(letrasIdeal.gMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraH = matrizCaracteres.redNeuronal(letrasIdeal.hMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraI = matrizCaracteres.redNeuronal(letrasIdeal.iMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraJ = matrizCaracteres.redNeuronal(letrasIdeal.jMatriz, letrasUsuario.aMatriz);

            letrasUsuario.similitudConLetraK = matrizCaracteres.redNeuronal(letrasIdeal.kMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraL = matrizCaracteres.redNeuronal(letrasIdeal.lMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraM = matrizCaracteres.redNeuronal(letrasIdeal.mMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraN = matrizCaracteres.redNeuronal(letrasIdeal.nMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraO = matrizCaracteres.redNeuronal(letrasIdeal.oMatriz, letrasUsuario.aMatriz);

            letrasUsuario.similitudConLetraP = matrizCaracteres.redNeuronal(letrasIdeal.pMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraQ = matrizCaracteres.redNeuronal(letrasIdeal.qMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraR = matrizCaracteres.redNeuronal(letrasIdeal.rMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraS = matrizCaracteres.redNeuronal(letrasIdeal.sMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraT = matrizCaracteres.redNeuronal(letrasIdeal.tMatriz, letrasUsuario.aMatriz);

            letrasUsuario.similitudConLetraU = matrizCaracteres.redNeuronal(letrasIdeal.uMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraV = matrizCaracteres.redNeuronal(letrasIdeal.vMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraW = matrizCaracteres.redNeuronal(letrasIdeal.wMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraX = matrizCaracteres.redNeuronal(letrasIdeal.xMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraY = matrizCaracteres.redNeuronal(letrasIdeal.yMatriz, letrasUsuario.aMatriz);
            letrasUsuario.similitudConLetraZ = matrizCaracteres.redNeuronal(letrasIdeal.zMatriz, letrasUsuario.aMatriz);


           List<Letras> listaLetras = new List<Letras>()
            {
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraA, letra = "A" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraB, letra = "B" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraC, letra = "C" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraD, letra = "D" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraE, letra = "E" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraF, letra = "F" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraG, letra = "G" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraH, letra = "H" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraI, letra = "I" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraJ, letra = "J" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraK, letra = "K" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraL, letra = "L" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraM, letra = "M" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraN, letra = "N" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraO, letra = "O" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraP, letra = "P" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraQ, letra = "Q" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraR, letra = "R" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraS, letra = "S" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraT, letra = "T" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraU, letra = "U" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraV, letra = "V" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraW, letra = "W" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraX, letra = "X" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraY, letra = "Y" },
                new Letras() { coincidenciaConLetra = letrasUsuario.similitudConLetraZ, letra = "Z" },
            };
            
            List<Letras> letrasOrdenadas = listaLetras.OrderByDescending(numero => numero.coincidenciaConLetra).ToList();
            foreach (Letras numero in letrasOrdenadas)
            {
                Console.WriteLine(numero.coincidenciaConLetra + " Letra " + numero.letra);
            }
            

         /*   BasicNetwork neuronaLetraA = matrizCaracteres.neuronaCreacionEntrenamiento(letrasDataBase.aMatriz, letrasIdeal.aMatriz, letrasDataBase.aDireccion, letrasDataBase.aNumero);
            var sw = new BasicMLData(30);
            IMLData nxs = neuronaLetraA.Compute(sw);

            Console.WriteLine(Convert.ToString(nxs[0]));
         */
            Console.ReadLine();

        }

        class Letras
        {
            public double coincidenciaConLetra { get; set; }
            public string letra { get; set; }
        }
    }
}
