using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEstudo
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //Entrou: Van
            Enfileirar("Van");
            //Entrou: Kombi
            Enfileirar("Kombi");
            //Entrou: Guincho
            Enfileirar("Guincho");
            //Entrou: Pick-up
            Enfileirar("Pick-up");
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

            Console.ReadLine();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                var veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}.");
                ImprimirFila();
                Console.WriteLine();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}.");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
            Console.WriteLine();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");
            foreach (var carro in pedagio)
            {
                Console.WriteLine(carro);
            }
        }
    }
}