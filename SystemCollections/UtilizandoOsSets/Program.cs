using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCollections;

namespace UtilizandoOsSets
{
    class Program
    {
        static void Final ()
        {
            List<string> frutas = new List<string>
            {
                "abacate",
                "banana",
                "caqui",
                "figo"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine();

            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("Quarta");
            Console.WriteLine("D4.Value: " + d4.Value);
            var d2 = dias.AddBefore(d4, "Segunda");
            dias.AddAfter(d2, "Terça");
            var d1 = dias.AddBefore(d2, "Domingo");

            var d5 = dias.AddAfter(d4, "Quinta");
            var d6 = dias.AddBefore(d5,"Sexta");
            //dias.AddFirst("Sábado");

            Console.ReadLine();

        }

        private static void Aula4()
        {
            Curso csharpcolecoes = new Curso("C# Coleções", "Marcelo Oliveira");
            csharpcolecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            csharpcolecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpcolecoes.Adiciona(new Aula("Modelando Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpcolecoes.Matricula(a1);
            csharpcolecoes.Matricula(a2);
            csharpcolecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados:");
            foreach (var aluno in csharpcolecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();

            Console.WriteLine($"O aluno {a1.Nome} está matriculado?");
            VerificarMatricula(csharpcolecoes, a1);
            Console.WriteLine();

            Aluno a4 = new Aluno("John Wick", 771214);
            Console.WriteLine($"O aluno {a4.Nome} está matriculado?");
            VerificarMatricula(csharpcolecoes, a4);
            Console.WriteLine();

            Aluno a5 = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine($"O aluno {a5.Nome} está matriculado?");
            VerificarMatricula(csharpcolecoes, a5);
            Console.WriteLine();

            Console.WriteLine("Os alunos a1 e a5 são iguais? " + a1.Equals(a5));
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Quem é o aluno com a matrícula 5617?");
            Aluno aluno5617 = csharpcolecoes.BuscaMatriculado(5617);
            Console.WriteLine("aluno5617: " + aluno5617);
            Console.WriteLine();


            Console.WriteLine("Quem é o aluno com a matrícula 5618?");
            Aluno aluno5618 = csharpcolecoes.BuscaMatriculado(5618);
            Console.WriteLine("aluno5618: " + aluno5618);
            Console.WriteLine();

            Console.WriteLine("Tentando adiciona duplicados. Aluno5617?");
            Aluno alunoNovo = new Aluno("Paul Wash", 5617);
            csharpcolecoes.SubstituiAluno(alunoNovo);
            //csharpcolecoes.BuscaMatriculado(5617);
            Console.WriteLine("Quem é o aluno com a matrícula 5617 agora?");
            Aluno aluno5617Agora = csharpcolecoes.BuscaMatriculado(5617);
            Console.WriteLine(aluno5617Agora);
            Console.WriteLine();
        }

        private static void VerificarMatricula(Curso csharpcolecoes, Aluno aluno)
        {
            bool verifica = csharpcolecoes.EstaMatriculado(aluno);
            if (verifica == true)
            {
                Console.WriteLine("Sim.");
            }
            else
            {
                Console.WriteLine("Não.");

            }
        }

        private static void Aula31()
        {
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //Imprimir NÃO FUNCIONA!
            Console.WriteLine(alunos);

            Console.WriteLine(string.Join("\n", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fábio Gushiken");
            Console.WriteLine();

            Console.WriteLine(string.Join("\n", alunos));
            Console.WriteLine();

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            alunos.Add("Fábio Gushiken");
            Console.WriteLine(string.Join("\n", alunos));
            Console.WriteLine();

            //Ordenando
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine("Imprimindo a ordenação:");
            foreach (var aluno in alunosEmLista)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
