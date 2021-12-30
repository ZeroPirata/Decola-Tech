using System;
using System.IO;
using ExemploPOO.helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Aula de Encapsulamento
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            Console.WriteLine($"Área é {r.ObterArea()}");
            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(-30, -30);
            // Console.WriteLine($"Área é {r1.ObterArea()}");

            // Aula de Abstração
            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Idade = 20;
            p1.Apresentar();

            // Aula de Herança + Polimorfismo
            Aluno pes = new Aluno();
            pes.Nome = "Murilo";
            pes.Idade = 21;
            pes.Nota = 8;
            pes.Apresentar();
            Professor prof = new Professor();
            prof.Nome = "Josue";
            prof.Idade = 35;
            prof.Materia = "Matematica";
            prof.Apresentar();
            // Calculadora Polimorfismo tempo de compilação
            Calculadora calc = new Calculadora();
            Console.WriteLine("Resultado da primeira soma é: " + calc.somar(10,10));
            Console.WriteLine("Resultado da primeira soma é: " + calc.somar(10,10,10));

            // Aula de Classes Abstratas
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();
            // Aula de Classe Abstratas selada ela não deixa os filho altera-la
            // Aula de calsse Abstratas Object
            Computador cpu =  new Computador();
            Console.WriteLine(cpu.ToString());
            // Aula de Interface
            ICalculadora calcs = new Calculadora();
            Console.WriteLine(calcs.somar(15,  15));
            Console.WriteLine(calcs.dividir(20, 2));
            Console.WriteLine(calcs.multiplicar(50, 2));
            Console.WriteLine(calcs.subtrair(10, 2));

            // Aula de Minipulação de arquivos
            // Mude o caminho a baixo para aplicar os teste, pois esses são do meu computador
            // var caminho = "Z:\\Fatec\\Fatec Codigos\\gate of stainer";
            // var caminhoArquivo = Path.Combine(caminho,"arquivoteste.txt");
            // var novocaminho = Path.Combine(caminho, "src","arquivoteste.txt");
            // var caminhoarquivotesteCopy = Path.Combine(caminho,"arquivoteste-backup.txt");
            // var listaString = new List<string>{"linha1", "linha2", "linha3"};
            // var listaStringContinuacao = new List<string>{"Teste1", "Teste2", "Teste3"};
            // FileHelper helper = new FileHelper();
            // helper.DeletarArquivo(caminhoarquivotesteCopy);
            // helper.CopiarArquivo(caminhoArquivo,caminhoarquivotesteCopy, false);
            // helper.MoverArquivo(caminhoArquivo, novocaminho, false);
            // helper.LerarquivoStream(caminhoArquivo);
            // helper.CriarArquivodeTxtStream(caminhoArquivo, listaString);
            // helper.adicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // helper.CriarArquivodeTxt(caminhoArquivo, "Testando o progama");
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorio(caminho);
            // helper.CriarDiretorio(Path.Combine(caminho, "Pasta Teste"));

            // var caminhoDeletar = "Z:\\Fatec\\Fatec Codigos\\gate of stainer\\Pasta Teste";
            // helper.ApagarDiretorio(caminhoDeletar);
        }
    }
}