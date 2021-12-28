using System;
namespace Revisao
{
    class progama
    {
        static void Main(string[] args)
        {
            // Criação da array onde tera 5 itens depedendo do numero que eu colocar dentro dos Colchetes[]
            Aluno[] alunos = new Aluno[5];
            // indiceAluno é responsavel para a locomoção de novas coisas dentro da lista
            var indiceAluno = 0;
            // Referencia a classe que é responsavel para mostrar a interface ao Usuario
            string opcaoUsuario = ObterOpcaoUsuario();
            // Onde o Usuario ira escolher a opção desejada
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {   
                    // Adicionar novos alunos ao Codigo
                    case "1":
                        Console.WriteLine("Digite o nome do aluno: ");
                        // criar a variavel onde ira ser responsavel para criar o novo aluno com a nota
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        // responsavel para transformar o que é digitado em decimal
                        Console.WriteLine("Informe a nota dele");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Por favor, digite uma nota válida");
                        }
                        // Adicionar o aluno e mudar o indice
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    // Listar os alunos
                    case "2":
                        // Procurar no array todos os itens de alunos
                        foreach (var x in alunos)
                        {
                            // filtrar para que não apareça itens vazios
                            if (!string.IsNullOrEmpty(x.Nome))
                            {
                                Console.WriteLine($"Aluno: {x.Nome} - Nota: {x.Nota}");
                            }
                        }
                        break;
                    // Média geral do Aluno e classificação
                    case "3":
                        decimal notaTotal = 0;
                        var alunoTotal = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                alunoTotal++;
                            }
                        }
                        var mediaGeral = notaTotal / alunoTotal;
                        // Puxar no conceito.cs as notas
                        Conceito conceitogeral;
                        if (mediaGeral <= 2)
                        {
                            conceitogeral = Conceito.E;
                        }
                        else if (mediaGeral <= 4)
                        {
                            conceitogeral = Conceito.D;
                        }
                        else if (mediaGeral <= 6)
                        {
                            conceitogeral = Conceito.C;
                        }
                        else if (mediaGeral <= 8)
                        {
                            conceitogeral = Conceito.B;
                        }
                        else
                        {
                            conceitogeral = Conceito.A;
                        }
                        Console.WriteLine($"média geral foi {mediaGeral} , Classificação {conceitogeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario() // Referencia a Classe no codigo
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo informe a opcao desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string? opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}