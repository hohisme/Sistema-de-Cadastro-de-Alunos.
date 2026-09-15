using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_cadastro
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }

        public Aluno(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
    }
}