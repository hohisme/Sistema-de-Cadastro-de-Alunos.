using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_cadastro
{
    internal class CadastroAlunos
    {
        private Aluno[] alunos = new Aluno[100];
        private int quantidade = 0;

        public void Adicionar(Aluno novoAluno)
        {
            if (quantidade < alunos.Length)
            {
                alunos[quantidade] = novoAluno;
                quantidade++;
            }
            else
            {
                Console.WriteLine("Não é possível adicionar mais alunos. Limite atingido.");
            }
        }
        public void Listar()
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Nome: {alunos[i].Nome}, Idade: {alunos[i].Idade}, Nota: {alunos[i].Nota}");
            }
        }

        public void Remover(string nome)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (alunos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < quantidade - 1; j++)
                    {
                        alunos[j] = alunos[j + 1];
                    }
                    alunos[quantidade - 1] = null;
                    quantidade--;
                    Console.WriteLine($"Aluno {nome} removido com sucesso.");
                    return;
                }
            }
            Console.WriteLine($"Aluno {nome} não encontrado.");
        }

        public void Atualizar(string nome, Aluno alunoAtualizado)
        {
            string nomeBusca = nome.Trim();
            for (int i = 0; i < quantidade; i++)
            {
                if (alunos[i].Nome.Trim().Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    alunos[i] = alunoAtualizado;
                    Console.WriteLine($"Aluno {nome} atualizado com sucesso.");
                    return;
                }
            }
            Console.WriteLine($"Aluno {nome} não encontrado.");
        }
    }
}