using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void UtilizandoStack()
        {
            var navegador = new Navegador();
            navegador.NavegarPara("https://www.google.com");
            navegador.NavegarPara("https://www.caelum.com.br");
            navegador.NavegarPara("https://www.alura.com.br");
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Proximo();

            Console.ReadLine();
        }
    }

    internal class Navegador
    {
        public string atual = "vazia";
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}

