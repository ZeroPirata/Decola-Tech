using Colecoes.helper;
using System;
using System.Collections.Generic;

namespace Colecoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 2]
            {
                {2 , 2},
                {4 , 6},
                {6 , 10},
                {8 , 12},
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }
            int[] arrayInteiro = new int[4];
            arrayInteiro[0] = 0;
            arrayInteiro[1] = 10;
            arrayInteiro[2] = 20;


            arrayInteiro[3] = int.Parse("30");
            System.Console.WriteLine();
            System.Console.WriteLine("For");
            for (int i = 0; i < arrayInteiro.Length; i++)
            {
                System.Console.WriteLine( string.Join(", ", arrayInteiro[i]));
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Foreach");
            foreach (int item in arrayInteiro)
            {
                System.Console.WriteLine(item);
            }
            // Bubble Sort
            System.Console.WriteLine();
            System.Console.WriteLine("Ordenação com Buble Sort");
            OperacaoArray op = new OperacaoArray();
            int[] array = new int[5] { 5, 3, 8, 4, 6 };
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaString(array);
            int valorexiste = 3;
            int indice = op.ObterIndice(array, valorexiste);
            int valorachado = op.ObterValor(array, valorexiste);
            bool existe = op.Existe(array, valorexiste);
            bool TodosMaiorQue = op.TodosMaiorQue(array, valorexiste);

            System.Console.WriteLine();
            System.Console.WriteLine("Sem ordenação");
            op.ImprimirArray(array);
            System.Console.WriteLine();
            System.Console.WriteLine("Ordenado");
            op.OrdenarBubbleSort(ref array);
            op.ImprimirArray(array);

            System.Console.WriteLine();
            System.Console.WriteLine("Classe Array");
            op.Ordenar(ref array);
            op.ImprimirArray(array);

            System.Console.WriteLine();
            System.Console.WriteLine("Copia do array");
            op.ImprimirArray(arrayCopia);
            op.Copiar(ref array, ref arrayCopia);
            op.ImprimirArray(arrayCopia);

            System.Console.WriteLine();
            System.Console.WriteLine($"Capacidade Atual do array{array.Length}");
            op.RedimensionarArray(ref array, array.Length * 2);

            System.Console.WriteLine();
            System.Console.WriteLine($"Capacidade Atual ataualizada do array{array.Length}");
            if (existe)
            {
                System.Console.WriteLine($"Numero Encontrado {valorexiste}");
            }
            else
            {
                System.Console.WriteLine($"Numero não Encontrado {valorexiste}");
            }
            System.Console.WriteLine();
            if (TodosMaiorQue)
            {
                System.Console.WriteLine($"Todos os valores são maior que {valorexiste}");
            }
            else
            {
                System.Console.WriteLine("Existe valores que não são maiories que {0}", valorexiste);
            }
            System.Console.WriteLine();
            if (valorachado > 0)
            {
                System.Console.WriteLine("Encontrei o valor");
            }
            else
            {
                System.Console.WriteLine("Valor não encontrado");
            }
            System.Console.WriteLine();
            if (indice > -1)
            {
                System.Console.WriteLine("O indice do elemento {0} é {1}", valorexiste, indice);
            }
            else
            {
                System.Console.WriteLine("Valor não existente");
            }
            //Coleções Genericas
            System.Console.WriteLine();
            operacaolista opLista = new operacaolista();
            List<string> estados = new List<string>();
            System.Console.WriteLine();
            estados.Add("SP");
            estados.Add("BH");
            estados.Add("MG");
            System.Console.WriteLine($"Os estados são {estados.Count}");
            opLista.ImprimirListaString(estados);
            // System.Console.WriteLine();
            // System.Console.WriteLine("Removido");
            // estados.Remove("MG");
            // opLista.ImprimirListaString(estados);

            System.Console.WriteLine();
            string[] estadosArray = new string[2] { "SC", "MT" };
            estados.AddRange(estadosArray);
            opLista.ImprimirListaString(estados);
            estados.Insert(2, "RJ");

            // Filas 
            System.Console.WriteLine();
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Gabriel");
            fila.Enqueue("Jonathan");
            fila.Enqueue("Ronaldo");
            while (fila.Count > 0)
            {
                System.Console.WriteLine($"Vez de: {fila.Peek()}"); // Inicio da fila
                System.Console.WriteLine($"{fila.Dequeue()} foi atendido"); // Chamando a pessoa, a removendo para ser o proximo
                System.Console.WriteLine($"{fila.Count()} Pessoas ainda na fila");
                System.Console.WriteLine();
                if (fila.Count == 0)
                {
                    System.Console.WriteLine("Obrigado por virem");
                }
            }
            System.Console.WriteLine();
            Stack<string> pilhalivros = new Stack<string>();
            pilhalivros.Push(".NET");
            pilhalivros.Push("Python");
            pilhalivros.Push("Java");
            while (pilhalivros.Count > 0)
            {
                System.Console.WriteLine($"Proximo livro para a leitura é: { pilhalivros.Peek() }");
                System.Console.WriteLine($"O livro: { pilhalivros.Pop()} foi completado");
            }
            // Dicionario
            System.Console.WriteLine();
            Dictionary<string, string> Jogos = new Dictionary<string, string>();
            Jogos.Add("League of legends", "Riot games");
            Jogos.Add("Counter Strike", "Valve");
            Jogos.Add("Megaman Zero", "Capcom");
            //        Chave//Key     Valor/Value
            string valorProcurado = "Pirata";
            if (Jogos.TryGetValue(valorProcurado, out string? empresa))
            {
                System.Console.WriteLine($"A Empresa é {empresa}");
            }
            else
            {
                System.Console.WriteLine($"A Empresa {valorProcurado} não existe");
            }
            System.Console.WriteLine();
            foreach (KeyValuePair<string, string> item in Jogos)
            {
                System.Console.WriteLine($"Jogo: {item.Key} - Empresa: {item.Value}");
            }
            System.Console.WriteLine();
            valorProcurado = "Megaman Zero";
            System.Console.WriteLine();
            System.Console.WriteLine("Valor original");
            System.Console.WriteLine(Jogos[valorProcurado]);
            Jogos[valorProcurado] = "RockMan";
            System.Console.WriteLine("Valor Alterado");
            System.Console.WriteLine(Jogos[valorProcurado]);
            System.Console.WriteLine();
            System.Console.WriteLine("Removendo o Jogo");
            valorProcurado = "League of legends";
            Jogos.Remove(valorProcurado);
            System.Console.WriteLine();
            foreach (KeyValuePair<string, string> item in Jogos)
            {
                System.Console.WriteLine($"Jogo: {item.Key} - Empresa: {item.Value}");
            }

            // LIQN
            System.Console.WriteLine();
            int[] arrayNumber = new int[5] { 2, 3, 8, 9, 12 };
            // Query
            var QueryNumerosPares =
                from num in arrayNumber
                where num % 2 == 0
                orderby num
                select num;
            System.Console.WriteLine(string.Join(", ", QueryNumerosPares));
            // Metodo
            var NumeroParesMetodo = arrayNumber.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            System.Console.WriteLine(string.Join(", ", NumeroParesMetodo));
            // Valor Max and Min
            int[] arrayMaxMin = new int[5] {100, 50, 25, 75, 200};
            var Min = arrayMaxMin.Min();
            var Max = arrayMaxMin.Max();
            var Med = arrayMaxMin.Average();
            System.Console.WriteLine($"Maximo {Max}, Médio {Med}, Minimo {Min}");
            var Soma = arrayMaxMin.Sum();
            System.Console.WriteLine($"A soma é {Soma}");
            int[] arrayRepete = new int[10]{10,20,30,40,50,10,20,20,30,100};
            var arrayUnico = arrayRepete.Distinct().ToArray();
            System.Console.WriteLine(string.Join(", ", arrayUnico));
        }
    }
}