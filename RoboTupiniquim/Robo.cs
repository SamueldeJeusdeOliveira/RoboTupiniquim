using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim
{
    class Robo
    {
        public static int PosicaoX;
        public static int PosicaoY;
        public static char Direcao;

        public static void Mover(string comandos)
        {
            foreach (char comando in comandos)
            {
                if (comando == 'M')
                {
                    MoverParaFrente();
                }
                else if (comando == 'D')
                {
                    VirarDireita();
                }
                else if (comando == 'E')
                {
                    VirarEsquerda();
                }
            }
        }
            public static void MoverParaFrente()
        {
            switch (Direcao)
            {
                case 'N':
                    PosicaoY++;
                    break;
                case 'L':
                    PosicaoX++;
                    break;
                case 'S':
                    PosicaoY--;
                    break;
                case 'O':
                    PosicaoX--;
                    break;
            }
        }

        public static void VirarDireita()
        {
            switch (Direcao)
            {
                case 'N':
                    Direcao = 'L';
                    break;
                case 'L':
                    Direcao = 'S';
                    break;
                case 'S':
                    Direcao = 'O';
                    break;
                case 'O':
                    Direcao = 'N';
                    break;
            }
        }

        public static void VirarEsquerda()
        {
            switch (Direcao)
            {
                case 'N':
                    Direcao = 'O';
                    break;
                case 'L':
                    Direcao = 'N';
                    break;
                case 'S':
                    Direcao = 'L';
                    break;
                case 'O':
                    Direcao = 'S';
                    break;
            }
        }

        public static void ExibirCoordenadas()
        {
            Console.WriteLine($"Posição final: {PosicaoX} {PosicaoY} {Direcao}");
        }
    }
}
