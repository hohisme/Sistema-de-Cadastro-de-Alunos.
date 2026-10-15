using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_cadastro
{
    internal class CadastroAlunos
    {
        private List<Aluno> alunos = new List<Aluno>();



        public void Adicionar(Aluno novoAluno)
        {
            alunos.Add(novoAluno);
        }

        public void Listar()
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine($"Nome: {alunos[i].Nome}, Idade: {alunos[i].Idade}, Nota: {alunos[i].Nota}");
            }
        }



        public void Remover(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    alunos.RemoveAt(i); 
                    Console.WriteLine($"Aluno {nome} removido com sucesso.");
                    return;
                }
            }
            Console.WriteLine($"Aluno {nome} não encontrado.");
        }

        public void Atualizar(string nome, Aluno alunoAtualizado)
        {
            string nomeBusca = nome.Trim();
            for (int i = 0; i < alunos.Count; i++)
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