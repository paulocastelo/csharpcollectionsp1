using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCollections
{
    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula aula = obj as Aula;

            return this.titulo.CompareTo(aula.titulo);

            //if (aula == null)
            //{
            //    return 1;
            //}

            //if (aula == obj)
            //{
            //    return 0;
            //}
            //return -1;
        }

        public override string ToString()
        {
            return "Título da aula: " + Titulo + ".\nTempo do aula: " + tempo + ".";
        }
    }
    class AulaP3
    {
        static void AulaIntrocao()
        {
            var aulaIntro = new Aula("Introdução às coleções", 29);
            var aulaModelando = new Aula("Modelando a classe aula", 18);
            var aulaSets = new Aula("Trabalhando em conjuntos", 32);

            List<Aula> aulas = new List<Aula>
            {
                aulaIntro,
                aulaModelando
            };

            aulas.Add(aulaSets);
            aulas.Add(new Aula("Conclusão", 45));
            imprimirObjetos(aulas);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-###################################################################-");
            Console.WriteLine("- Utilizando a propriedade Sort com a implementação do IComparable. -");
            Console.WriteLine("-###################################################################-");
            Console.WriteLine("Organizar pelo título definido no IComparable.");
            aulas.Sort();
            imprimirObjetos(aulas);
            Console.WriteLine();

            Console.WriteLine("Organizar por definição Lambda.");
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            imprimirObjetos(aulas);

            Console.ReadLine();

        }

        private static void AulaP2()
        {
            string aulaIntro = "Introdução às coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando em conjuntos";

            Console.WriteLine("Método 01 de atribuição de lista:");
            List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            Console.WriteLine(aulas);
            imprimirLista(aulas);

            Console.WriteLine("Método 02 de atribuição de lista:");
            List<string> aulas2 = new List<string>();
            aulas2.Add(aulaIntro);
            aulas2.Add(aulaModelando);
            aulas2.Add(aulaSets);
            imprimirLista(aulas2);

            Console.WriteLine("A primeira aula é " + aulas2[0] + ". Utilizando o índice.");
            Console.WriteLine("A primeira aula é " + aulas2.First() + ". Utilizando o first.");
            Console.WriteLine("A última aula é " + aulas2[aulas2.Count - 1] + ". Utilizando o lista.Count");
            Console.WriteLine("A última aula é " + aulas2.Last() + ". Utiliando o Last.");

            aulas2[0] = "Trabalhando com listas.";
            Console.WriteLine("A primeira aula 'Trabalhando' é:"
                + aulas2.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é:"
                + aulas2.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é:"
                + aulas2.FirstOrDefault(aula => aula.Contains("Conclusão")));

            Console.WriteLine("Removendo o primeiro item que possui 'Trabalhando':");
            aulas2.Remove(aulas2.FirstOrDefault(aula => aula.Contains("Trabalhando")));
            imprimirLista(aulas2);

            Console.WriteLine("Removendo o último item que possui 'Trabalhando':");
            aulas2.RemoveAt(aulas2.Count - 1);
            imprimirLista(aulas2);

            aulas2.Add("Conclusão");
            imprimirLista(aulas2);

            List<string> copia = aulas2.GetRange(aulas2.Count - 2, 2); // Pega o penúltimo.
            imprimirLista(copia);

            List<string> clone = new List<string>(aulas2);
            imprimirLista(clone);

            Console.WriteLine("Limpando todas as listas.");
            aulas.RemoveAll(aula => aula.Any());
            imprimirLista(aulas);
            aulas2.RemoveAll(aula => aula.Any());
            imprimirLista(aulas2);
            clone.RemoveAll(aula => aula.Any());
            imprimirLista(clone);
            copia.RemoveAll(aula => aula.Any());
            imprimirLista(copia);

            Console.ReadLine();
        }

        private static void AulaP1()
        {
            string aulaIntro = "Introdução às coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando em conjuntos";

            string[] aulas = new string[] {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            string[] aulas2 = new string[3];
            aulas2[0] = aulaIntro;
            aulas2[1] = aulaModelando;
            aulas2[2] = aulaSets;
            imprimir(aulas);
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            Console.WriteLine("Primeira ocorrência de 'Aula modelando' está no índice: " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine("Última ocorrência de 'Aula modelando' está no índice: " + Array.LastIndexOf(aulas, aulaModelando));
            Console.WriteLine();

            Console.WriteLine("Revertendo o array com reverse:");
            Array.Reverse(aulas2);
            imprimir(aulas2);
            Console.WriteLine();

            Console.WriteLine("Redimensionando array:");
            Array.Resize(ref aulas2, 2);
            imprimir(aulas2);
            Console.WriteLine();

            Array.Resize(ref aulas2, 3);
            aulas2[aulas2.Length - 1] = "Conclusão";
            imprimir(aulas2);
            Console.WriteLine();

            Array.Sort(aulas);
            imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine("Copiando array:");
            string[] novaAula = new string[2];
            Array.Copy(aulas, 1, novaAula, 0, 2);
            imprimir(novaAula);
            Console.WriteLine();

            Console.WriteLine("Clonando array:");
            string[] clone = novaAula.Clone() as string[];
            imprimir(clone);
            Console.WriteLine();

            Console.WriteLine("Limpando array:");
            Array.Clear(clone, 1, 1);
            imprimir(clone);

            Console.ReadLine();
        }

        private static void imprimirObjetos(List<Aula> aulas)
        {
            Console.WriteLine("Imprimindo lista de objetos:");
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
        private static void imprimirLista(List<string> aulas)
        {
            Console.WriteLine("Impressão utilizando o foreach:");
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            Console.WriteLine();

            Console.WriteLine("Impressão utilizando o for:");
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Impressão utilizando o nomeDaLista.forEach()");
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
            Console.WriteLine("-++++++++++++++++++++++++++++++++++++-");
            Console.WriteLine("-++++++++++++++++++++++++++++++++++++-");
            Console.WriteLine();
        }
        private static void imprimir(string[] aulas)
        {
            Console.WriteLine("Impressão utilizando o foreach:");
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            Console.WriteLine();
            Console.WriteLine("impressão utilizando o for:");
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
