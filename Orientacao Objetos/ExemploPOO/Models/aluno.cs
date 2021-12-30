using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar() // Override = sobre escrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minhas notas são {Nota}");
        }
    }
}