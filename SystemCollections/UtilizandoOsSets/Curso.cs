using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilizandoOsSets;

namespace SystemCollections
{
    class Curso
    {
        private IDictionary<int, Aluno> dicionarioAluno = new Dictionary<int, Aluno>();
        private IList<Aula> aulas;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
            //set { aulas = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAluno.Add(aluno.NumeroMatricula, aluno);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public int TempoTotal
        {
            get
            {
                //int total = new int();
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ - Language Integrated Query
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome do curso: " + Nome);
            sb.Append("Aulas: \n");
            foreach (var aula in aulas)
            {
                sb.Append(" - " + aula.Titulo + "\n");

            }
            sb.Append("Instrutor " + instrutor);
            return sb.ToString();
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            //foreach (var aluno in alunos)
            //{
            //    if (aluno.NumeroMatricula == numeroMatricula)
            //    {
            //        return aluno;
            //    }
            //}
            //throw new Exception("Matrícula não encontrada: " + numeroMatricula + ".");

            //return this.dicionarioAluno[numeroMatricula];

            Aluno aluno = null;
            this.dicionarioAluno.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAluno[aluno.NumeroMatricula] = aluno;
        }
    }
}
