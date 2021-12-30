namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public string? Materia { get; set; }
        public sealed override void Apresentar() // override = permitir sobre escrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e dou aula de {Materia}");
        }
    }
}