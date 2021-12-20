using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCollections
{
    class Curso
    {
        private IList<Aula> aulas;
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

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
                sb.Append(" - " + aula.Titulo +"\n");

            }
            sb.Append("Instrutor " + instrutor);
            return sb.ToString();
        }
    }
}
