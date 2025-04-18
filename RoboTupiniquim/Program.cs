namespace RoboTupiniquim
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a posição inicial do Robo 1:");
            string posicaoInicial = Console.ReadLine();
            Console.WriteLine("Digite os comandos:");
            string comandos = Console.ReadLine();

            string[] dados1 = posicaoInicial.Split(' ');
            Robo robo1 = new Robo(
                Convert.ToInt32(dados1[0]),
                Convert.ToInt32(dados1[1]),
                dados1[2][0]
            );

            robo1.Mover(comandos);
            robo1.ExibirCoordenadas();
            robo1.MostrarNoMapa();

            Console.WriteLine("Digite a posição inicial do Robo 2:");
            string posicaoInicial2 = Console.ReadLine();
            Console.WriteLine("Digite os comandos:");
            string comandos2 = Console.ReadLine();

            string[] dados2 = posicaoInicial2.Split(' ');
            Robo robo2 = new Robo(
                Convert.ToInt32(dados2[0]),
                Convert.ToInt32(dados2[1]),
                dados2[2][0]
            );

            robo2.Mover(comandos2);
            robo2.ExibirCoordenadas();
            robo2.MostrarNoMapa();
        }
    }
}
