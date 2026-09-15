using System;

namespace sistema_de_cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadastroAlunos cadastro = new CadastroAlunos();

            Console.WriteLine("Bem-vindo ao sistema de cadastro de alunos!");

            while (true)
            {
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Listar Aluno ");
                Console.WriteLine("3 - Remover Aluno");
                Console.WriteLine("4 - Atualizar Aluno");
                Console.WriteLine("5 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Nota: ");
                        double nota = double.Parse(Console.ReadLine());

                        Aluno novoAluno = new Aluno(nome, idade, nota);
                        cadastro.Adicionar(novoAluno);
                        break;

                    case "2":
                        cadastro.Listar();
                        break;

                    case "3":
                        Console.Write("Nome do aluno a remover: ");
                        string nomeRemover = Console.ReadLine();
                        cadastro.Remover(nomeRemover);
                        break;

                    case "4":
                        Console.Write("Nome do aluno a atualizar: ");
                        string nomeAtualizar = Console.ReadLine();

                        Console.Write("Novo nome: ");
                        string novoNome = Console.ReadLine();

                        Console.Write("Nova idade: ");
                        int novaIdade = int.Parse(Console.ReadLine());

                        Console.Write("Nova nota: ");
                        double novaNota = double.Parse(Console.ReadLine());

                        Aluno alunoAtualizado = new Aluno(novoNome, novaIdade, novaNota);
                        cadastro.Atualizar(nomeAtualizar, alunoAtualizado);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}