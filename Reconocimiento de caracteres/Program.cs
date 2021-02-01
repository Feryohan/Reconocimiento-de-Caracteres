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


            #region Lectura de las letras DataBase
            //Lectura letras B
            for (int i = 1; i <= letrasDataBase.bNumero; i++)
            {
                letrasDataBase.bMatriz = matrizCaracteres.lecturaDataBase(letrasDataBase.bDireccion, i);
            }
            #endregion
            
            letrasDataBase.similitudConLetraA = matrizCaracteres.redNeuronal(letrasIdeal.aMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraB = matrizCaracteres.redNeuronal(letrasDataBase.bMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraC = matrizCaracteres.redNeuronal(letrasIdeal.cMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraD = matrizCaracteres.redNeuronal(letrasIdeal.dMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraE = matrizCaracteres.redNeuronal(letrasIdeal.eMatriz, letrasIdeal.bMatriz);

            letrasDataBase.similitudConLetraF = matrizCaracteres.redNeuronal(letrasIdeal.fMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraG = matrizCaracteres.redNeuronal(letrasIdeal.gMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraH = matrizCaracteres.redNeuronal(letrasIdeal.hMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraI = matrizCaracteres.redNeuronal(letrasIdeal.iMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraJ = matrizCaracteres.redNeuronal(letrasIdeal.jMatriz, letrasIdeal.bMatriz);

            letrasDataBase.similitudConLetraK = matrizCaracteres.redNeuronal(letrasIdeal.kMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraL = matrizCaracteres.redNeuronal(letrasIdeal.lMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraM = matrizCaracteres.redNeuronal(letrasIdeal.mMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraN = matrizCaracteres.redNeuronal(letrasIdeal.nMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraO = matrizCaracteres.redNeuronal(letrasIdeal.oMatriz, letrasIdeal.bMatriz);

            letrasDataBase.similitudConLetraP = matrizCaracteres.redNeuronal(letrasIdeal.pMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraQ = matrizCaracteres.redNeuronal(letrasIdeal.qMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraR = matrizCaracteres.redNeuronal(letrasIdeal.rMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraS = matrizCaracteres.redNeuronal(letrasIdeal.sMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraT = matrizCaracteres.redNeuronal(letrasIdeal.tMatriz, letrasIdeal.bMatriz);

            letrasDataBase.similitudConLetraU = matrizCaracteres.redNeuronal(letrasIdeal.uMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraV = matrizCaracteres.redNeuronal(letrasIdeal.vMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraW = matrizCaracteres.redNeuronal(letrasIdeal.wMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraX = matrizCaracteres.redNeuronal(letrasIdeal.xMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraY = matrizCaracteres.redNeuronal(letrasIdeal.yMatriz, letrasIdeal.bMatriz);
            letrasDataBase.similitudConLetraZ = matrizCaracteres.redNeuronal(letrasIdeal.zMatriz, letrasIdeal.bMatriz);


           List<Letras> listaLetras = new List<Letras>()
            {
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraA, letra = "A" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraB, letra = "B" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraC, letra = "C" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraD, letra = "D" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraE, letra = "E" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraF, letra = "F" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraG, letra = "G" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraH, letra = "H" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraI, letra = "I" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraJ, letra = "J" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraK, letra = "K" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraL, letra = "L" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraM, letra = "M" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraN, letra = "N" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraO, letra = "O" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraP, letra = "P" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraQ, letra = "Q" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraR, letra = "R" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraS, letra = "S" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraT, letra = "T" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraU, letra = "U" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraV, letra = "V" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraW, letra = "W" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraX, letra = "X" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraY, letra = "Y" },
                new Letras() { coincidenciaConLetra = letrasDataBase.similitudConLetraZ, letra = "Z" },
            };
            
            List<Letras> letrasOrdenadas = listaLetras.OrderByDescending(numero => numero.coincidenciaConLetra).ToList();
            foreach (Letras numero in letrasOrdenadas)
            {
                Console.WriteLine(numero.coincidenciaConLetra + " Letra " + numero.letra);
            }

            Console.ReadLine();

        }

        class Letras
        {
            public double coincidenciaConLetra { get; set; }
            public string letra { get; set; }
        }
    }
}
