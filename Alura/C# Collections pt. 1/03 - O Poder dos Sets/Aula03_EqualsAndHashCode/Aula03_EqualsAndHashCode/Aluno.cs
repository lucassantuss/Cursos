using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03_EqualsAndHashCode
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
            set { nome = value; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {NumeroMatricula}]";
        }


        // sobrescrevendo a comparacao do metodo Equals
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
                return false;

            return this.nome.Equals(outro.nome);
        }

        // aumentar a rapidez da busca pois ela depende do CODIGO DE DISPERSAO
        // HashCode -> busca por hashes, para caso houver mais de 1 registro por hash
        // e ter que realizar buscas complexas
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

        // IMPORTANTE!!
        // Dois objetos que são iguais possuem o mesmo hash code
        // PORÉM, o contrário não é verdadeiro:
        // Dois objetos com o mesmo hash code não são necessariamente iguais!
    }
}