using Exercicio4FilaFibonacci;

internal class Program
{
    static NumeroFibonacci criarNumero(int posicao)
    {
        int penultimo = -1, ultimo = 1, atual = 1;
        int fibonacci = 0;

        for (int i = 0; i < posicao; i++)
        {
            atual = penultimo + ultimo;
            fibonacci = atual;
            penultimo = ultimo;
            ultimo = atual;
        }

        return new NumeroFibonacci(fibonacci);
    }

    private static void Main(string[] args)
    {
        int numeroPos;

        do
        {
            Console.Write("Digite o número da posição limite: ");
            numeroPos = int.Parse(Console.ReadLine());
            if (numeroPos <= 0)
            {
                Console.WriteLine("\nO número não pode ser menor ou igual a zero.");
            }
        } while (numeroPos <= 0);
        FilaFibonacci fila = new FilaFibonacci();

        for (int i = 0; i < numeroPos; i++)
        {
            fila.push(criarNumero(i));
        }
        fila.imprimirPilha();
        Console.ReadKey();
    }
}
