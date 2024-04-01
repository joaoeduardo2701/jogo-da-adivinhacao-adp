namespace JogoDaAdivinhacao.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;

        while (opcao != 4)
        {
            Console.Clear();

            int pontuacao = 1000;

            int numeroSorteado = GeraNumerosAleatorios();

            Menu();
            opcao = int.Parse(Console.ReadLine());

            int chances = 0;

            if (opcao == 1)
                // Fácil
                chances = 15;
            else if (opcao == 2)
                // Médio
                chances = 10;
            else if (opcao == 3)
                // Difícil
                chances = 5;
            else if (opcao == 4)
                break;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida! Por favor digite um número válido!");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            
            pontuacao = LogicaGame(pontuacao, numeroSorteado, chances);

            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("Encerrando programa...");
    }

    static int LogicaGame(int pontuacao, int numeroSorteado, int chances)
    {
        int chute = 0;

        for (int i = 1; i <= chances; i++)
        {
            Console.WriteLine("Qual o seu " + i + "º chute? ");
            chute = int.Parse(Console.ReadLine());

            if (chute == numeroSorteado)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você ganhou!!!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("O numero sorteado foi o " + numeroSorteado);
                Console.WriteLine("Sua pontuação foi de " + pontuacao);
                break;
            }
            else
            {
                if (chute > numeroSorteado)
                {
                    Console.WriteLine("Seu chute foi maior que o número sorteado");
                }
                else if (chute < numeroSorteado)
                {
                    Console.WriteLine("Seu chute foi menor que o número sorteado");
                }

                pontuacao -= Math.Abs((chute - numeroSorteado) / 2);

                Console.WriteLine("Pontuação: " + pontuacao);
            }
        }

        return pontuacao;
    }

    static int GeraNumerosAleatorios()
    {
        Random r = new Random();
        int numeroSorteado = r.Next(1, 20);
        return numeroSorteado;
    }

    static void Menu()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("---------- Jogo da Adivinhação ----------");
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Escolha o nível de dificuldade do jogo: ");
        Console.WriteLine("1- Fácil");
        Console.WriteLine("2- Médio");
        Console.WriteLine("3- Difícil");
        Console.WriteLine("4- Encerrar programa");
        Console.Write("-> ");
    }
}
