

namespace Exercicio4FilaFibonacci
{

    internal class FilaFibonacci
    {
        NumeroFibonacci headNumero;
        NumeroFibonacci tailNumero;


        public FilaFibonacci()
        {
            this.headNumero = null;
            this.tailNumero = null;
            Console.WriteLine("\nPilha Criada!\n");
        }
        bool Empty()
        {
            return headNumero == null;
        }

        public void push(NumeroFibonacci auxNumero)
        {
            if (Empty() == true)
            {
                headNumero = auxNumero;
                tailNumero = auxNumero;
            }
            else
            {
                tailNumero.setNext(auxNumero);
                tailNumero = auxNumero;
            }

        }

        public void imprimirPilha()
        {
            Console.WriteLine("\nValores na pilha\n");
            NumeroFibonacci numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getNext();
            }
        }



    }

}
