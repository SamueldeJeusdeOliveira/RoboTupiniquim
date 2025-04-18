using System;

namespace RoboTupiniquim
{
    class Robo
    {
        public int PosicaoX;
        public int PosicaoY;
        public char Direcao;

        public Robo(int x, int y, char direcao)
        {
            PosicaoX = x;
            PosicaoY = y;
            Direcao = direcao;
        }

        public void Mover(string comandos)
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

        private void MoverParaFrente()
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

        private void VirarDireita()
        {
            switch (Direcao)
            {
                case 'N': Direcao = 'L'; break;
                case 'L': Direcao = 'S'; break;
                case 'S': Direcao = 'O'; break;
                case 'O': Direcao = 'N'; break;
            }
        }

        private void VirarEsquerda()
        {
            switch (Direcao)
            {
                case 'N': Direcao = 'O'; break;
                case 'L': Direcao = 'N'; break;
                case 'S': Direcao = 'L'; break;
                case 'O': Direcao = 'S'; break;
            }
        }

        public void ExibirCoordenadas()
        {
            Console.WriteLine($"Posição final: {PosicaoX} {PosicaoY} {Direcao}");
        }

        public void MostrarNoMapa()
        {
            for (int y = 9; y >= 0; y--)
            {
                Console.Write(y + " ");
                for (int x = 0; x < 10; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (x == PosicaoX && y == PosicaoY)
                        Console.Write("R ");
                    else
                        Console.Write("- ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            Console.Write("  ");
            for (int x = 0; x < 10; x++)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
