
namespace Exercicio4FilaFibonacci
{
    internal class NumeroFibonacci
    {
        int numero;
        NumeroFibonacci proximo;

        public NumeroFibonacci(int numero)
        {
            this.numero = numero;
            proximo = null;
        }

        public void setNext(NumeroFibonacci numero)
        {
            proximo = numero;
        }

        public NumeroFibonacci getNext()
        {
            return proximo;
        }


        public int getValor()
        {
            return this.numero;
        }



    }
}
