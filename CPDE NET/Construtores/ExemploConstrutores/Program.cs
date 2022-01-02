using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(String[] args)
        {
            Matematica m = new Matematica(10,20);
            m.Somar();
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(10,25);
            Pessoa p1 = new Pessoa("Gabriel", "Souza");
            p1.Apresnetar();
            Data data = new Data();
            data.setMes(12);
            data.setMes(13);
            data.Apresnetar(); const double pi = 3.14;
            System.Console.WriteLine(pi);

        }
    }
}