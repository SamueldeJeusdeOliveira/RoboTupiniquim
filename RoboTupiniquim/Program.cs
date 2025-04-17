namespace RoboTupiniquim
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Robo robo1 = new Robo();

            string posicaoInicial = "3 3 L";
            string comandos = "MMDMMDMDDM";

            string[] coordenadasIniciais = posicaoInicial.Split(' ');
            Robo.PosicaoX = Convert.ToInt32(coordenadasIniciais[0]);
            Robo.PosicaoY = Convert.ToInt32(coordenadasIniciais[1]);
            Robo.Direcao = coordenadasIniciais[2][0];

            Robo.ExibirCoordenadas();
            Robo robo2 = new Robo();
            string posicaoInicial2 = "4 1 O";
            string comandos2 = "MMDMMDMDDM";

            string[] coordenadasIniciais2 = posicaoInicial2.Split(' ');
            Robo.PosicaoX = Convert.ToInt32(coordenadasIniciais2[0]);
            Robo.PosicaoY = Convert.ToInt32(coordenadasIniciais2[1]);
            Robo.Direcao = coordenadasIniciais2[2][0];
            Robo.Mover(comandos2);

            Robo.ExibirCoordenadas();
        }
    }
}