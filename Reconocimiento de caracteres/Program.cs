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
                        letrasIdeal.aMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'B':
                        letrasIdeal.bMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'C':
                        letrasIdeal.cMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'D':
                        letrasIdeal.dMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'E':
                        letrasIdeal.eMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'F':
                        letrasIdeal.fMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'G':
                        letrasIdeal.gMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'H':
                        letrasIdeal.hMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'I':
                        letrasIdeal.iMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'J':
                        letrasIdeal.jMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'K':
                        letrasIdeal.kMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'L':
                        letrasIdeal.lMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'M':
                        letrasIdeal.mMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'N':
                        letrasIdeal.nMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'O':
                        letrasIdeal.oMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'P':
                        letrasIdeal.pMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'Q':
                        letrasIdeal.qMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'R':
                        letrasIdeal.rMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'S':
                        letrasIdeal.sMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'T':
                        letrasIdeal.tMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'U':
                        letrasIdeal.uMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'V':
                        letrasIdeal.vMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'W':
                        letrasIdeal.wMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'X':
                        letrasIdeal.xMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'Y':
                        letrasIdeal.yMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                    case 'Z':
                        letrasIdeal.zMatriz = matrizCaracteres.asignacionBits(letra);
                        break;
                }
            }
            #endregion

            
            #region Lectura de las letras DataBase
            //Lectura letras B
            for(int i = 1; i <= letrasDataBase.bNumero; i++)
            {
                letrasDataBase.cMatriz = matrizCaracteres.lecturaDataBase(letrasDataBase.bDireccion, i);
            }
            #endregion

            Console.WriteLine("\n\n");

            for (int yy = 0; yy < 23; yy++)
            {
                for (int xx = 0; xx < 30; xx++)
                {
                    Console.Write(letrasDataBase.cMatriz[yy,xx]);
                }
                Console.Write("\n");
            }
            

            //data set sum
            double[][] x =
            {
                new double[]{0.0,0.5}, //0.5
                new double[]{0.2,0.6}, //0.8
                new double[]{0.5,0.5}  //1.0
            };

            double[][] y =
            {
                new double[]{0.5},
                new double[]{0.8},
                new double[]{1.0}
            };

            //Creando network
            BasicNetwork network = new BasicNetwork();
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 2)); //2 neuronas de entrada
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 5)); //5 neuronas ocultas
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 1)); //1 neurona de salida
            network.Structure.FinalizeStructure();
            network.Reset();

            //Entrenamiento
            IMLDataSet dataset = new BasicMLDataSet(x, y);
            ITrain learner = new Backpropagation(network, dataset);
            for(int i = 0; i < 3000; i++)
            {
                learner.Iteration();
                Console.WriteLine("error: " + learner.Error);
            }

            //Prueba
            foreach(BasicMLDataPair pair in dataset)
            {
                IMLData result = network.Compute(pair.Input);
                Console.WriteLine("{0} + {1} = {2} -> {3}", pair.Input[0], pair.Input[1], pair.Ideal[0], result[0]);
            }

            Console.ReadLine();
        }
    }
}
