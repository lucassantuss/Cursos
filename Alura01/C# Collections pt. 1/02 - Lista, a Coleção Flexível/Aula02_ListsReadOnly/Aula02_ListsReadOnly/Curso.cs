using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Aula02_ListsReadOnly
{
    public class Curso
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
    }
}