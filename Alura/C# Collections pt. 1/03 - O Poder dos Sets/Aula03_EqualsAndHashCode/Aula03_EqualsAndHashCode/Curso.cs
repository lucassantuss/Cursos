using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Aula03_EqualsAndHashCode
{
    public class Curso
    {
        // alunos deve ser um ISet. Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        // ReadOnly
        // Sem o SET não pode alterar o valor da propriedade
        public IList<Aluno> Alunos
        {
            get { return new ReadOnlyCollection<Aluno>(alunos.ToList()); }
        }

        // ReadOnly
        // Sem o SET não pode alterar o valor da propriedade
        // ReadOnlyCollection
        // Trocar List<Aula> POR IList<Aula> por que ReadOnlyCollection implementa um IList
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;

                //foreach(var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}

                //return total;

                // Utilizando LINQ = Language Integrated Query
                // Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            // Join vai unir as strings da coleção de aulas
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public Boolean EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}