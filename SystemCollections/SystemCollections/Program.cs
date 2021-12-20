using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCollections;

namespace Aula24ListaSomentLeitura
{
    class program
    {
        static void Main(string[] args)
        {
            Curso csharpcollection = new Curso("C# Collections P1", "Gustavo Instrutor");
            csharpcollection.Adiciona(new Aula("Arrays", 45));
            Imprimir(csharpcollection.Aulas);
            Console.WriteLine();

            //Adicionar 02 aulas
            csharpcollection.Adiciona(new Aula("Criando uma aula.", 20));
            csharpcollection.Adiciona(new Aula("Modelando Coleções", 19));

            //Imprimir
            Imprimir(csharpcollection.Aulas);

            //Utilizar o Sort na lista
            csharpcollection.Aulas.OrderBy();

            Console.ReadLine();
        }
        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
