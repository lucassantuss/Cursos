using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01_SortedDictionary
{
    public class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public override string ToString()
        {
            return "[Aluno: " + this.nome + ", matrícula: " + this.numeroMatricula + "]";
        }
    }
}