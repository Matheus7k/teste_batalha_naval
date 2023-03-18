using teste_batalha_naval;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new Player();
        Player player2 = new Player();

        Console.WriteLine("Nome do jogador 1: ");
        player1._name =Console.ReadLine();
        Console.WriteLine("Nome do jogador 2: ");
        player2._name = Console.ReadLine();


        //----AREA DE TESTES----
        int[] vetor = new int[2];
        vetor[0] = 0;
        vetor[1] = 5;

        AircraftCarrier pa = new();
        Player playerTeste = new();

        Board board = new();
        board.InsertBoard(vetor[0], vetor[1],pa, playerTeste,"horizontal", 1);

        foreach(int p in board._board)
        {
            Console.WriteLine(p);
        }
        //----AREA DE TESTES----
        vetor = PositionVerification();

        int[] PositionVerification()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRST";
            char charPosition;
            string[] auxString;
            int[] auxVector = new int[2];

            Console.WriteLine("Indique a posição alvo: (A,1)");
            auxString = Console.ReadLine().Split(',');

            if (auxString.GetUpperBound(0) == 0)
            {
                Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                return PositionVerification();
            }

            if ((!int.TryParse(auxString[0], out (auxVector[0]))))
            {
                if ((!int.TryParse(auxString[1], out auxVector[0])))
                {
                    Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    return PositionVerification();
                }
                else
                {
                    if (!char.TryParse(auxString[0].Trim().ToUpper(), out charPosition))
                    {
                        Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        return PositionVerification();
                    }

                    auxVector[0] -= 1;
                    if (auxVector[0] > 19)
                    {
                        Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        return PositionVerification();
                    }
                    auxVector[1] = alphabet.IndexOf(charPosition);
                    return auxVector;
                }
            }
            else
            {
                if (!char.TryParse(auxString[1].Trim().ToUpper(), out charPosition))
                {
                    Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    return PositionVerification();
                }
                auxVector[0] -= 1;
                if (auxVector[0] > 19)
                {
                    Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    return PositionVerification();
                }
                auxVector[1] = alphabet.IndexOf(charPosition);
                if (auxVector[1] == -1)
                {
                    Console.WriteLine("Valor inválido! Aperte qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    return PositionVerification();
                }
                return auxVector;
            }
        }
    }
}