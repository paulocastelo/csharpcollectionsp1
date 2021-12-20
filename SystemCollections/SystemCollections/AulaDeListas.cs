using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCollections;

namespace Aula24ListaSomentLeitura
{
    class AulaDeListas
    {
        static void AulaAnterior()
        {
            
            Console.WriteLine("Início do programa:");
            Curso csharpcollection = new Curso("C# Collections P1", "Gustavo Instrutor");
            csharpcollection.Adiciona(new Aula("Arrays", 45));
            Imprimir(csharpcollection.Aulas);
            Console.WriteLine();

            //Adicionar 02 aulas
            csharpcollection.Adiciona(new Aula("Criando uma aula.", 20));
            csharpcollection.Adiciona(new Aula("Modelando Coleções", 19));

            //Imprimir
            Console.WriteLine("Imprimindo cSharpCollection");
            Imprimir(csharpcollection.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpcollection.Aulas);

            //Ordenar a lista copiada
            Console.WriteLine("Imprimindo aulas copiadas");
            aulasCopiadas.Sort();

            //Imprimindo lista copiada
            Imprimir(aulasCopiadas);

            Console.Write("Tempo total de aulas:");
            Console.WriteLine(csharpcollection.TempoTotal);


            Console.WriteLine(csharpcollection);

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
