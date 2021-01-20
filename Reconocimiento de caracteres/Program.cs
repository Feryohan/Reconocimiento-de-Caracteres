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
            int ASCII;
            LetrasIdeal prueba = new LetrasIdeal();
            for (ASCII = 65; ASCII < 91; ASCII++)
            {
                char letra = (char)(ASCII);
                switch (letra)
                {
                    case 'A':
                        prueba.aIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'B':
                        prueba.bIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'C':
                        prueba.cIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'D':
                        prueba.dIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'E':
                        prueba.eIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'F':
                        prueba.fIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'G':
                        prueba.gIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'H':
                        prueba.hIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'I':
                        prueba.iIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'J':
                        prueba.jIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'K':
                        prueba.kIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'L':
                        prueba.lIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'M':
                        prueba.mIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'N':
                        prueba.nIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'O':
                        prueba.oIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'P':
                        prueba.pIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'Q':
                        prueba.qIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'R':
                        prueba.rIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'S':
                        prueba.sIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'T':
                        prueba.tIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'U':
                        prueba.uIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'V':
                        prueba.vIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'W':
                        prueba.wIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'X':
                        prueba.xIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'Y':
                        prueba.yIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                    case 'Z':
                        prueba.zIdeal = LetrasIdeal.asignacionBits(letra);
                        break;
                }
            }

            Console.WriteLine("\n\n");

            for (int y = 0; y < 23; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    Console.Write(prueba.zIdeal[y,x]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
