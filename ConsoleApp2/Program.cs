namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Questao 1

            //Resposta o valor da SOMA sera: 91

            //Questao 2
            Console.WriteLine("Questao 2 \n");

            Console.Write("informe o valor:");

            int valorInformado = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int valorSoma = 0;

            Console.Write($"{a},{b}");

            for (int i = 2; i < valorInformado; i++)
            {
                valorSoma = a + b;
                Console.Write($",{valorSoma}");
                a = b;

                b = valorSoma;
            }

            //Questao 3
            Console.WriteLine("\n\nQuestao 3 \n");

            double[] faturamentoDiario = {
                120.50,  95.30,  80.00,  150.75,  110.20,  0,  0,
                140.10, 85.90,  100.00,  75.80,   95.00,   0,  0,
                60.30,  145.20, 110.40,  50.00,   140.00,  0,  0,
                170.30,  95.70,  105.20,  90.00,   115.50,  0,  0,
                75.90,  95.20
            };

            double mediaMensal = faturamentoDiario.Where(x => x != 0).Average();

            double qtdDias = faturamentoDiario.Where(x => x >= mediaMensal).Count();

            var menorValor = faturamentoDiario.Where(x => x > 0).Min();
            var maiorValor = faturamentoDiario.Max();

            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
            Console.WriteLine($"Quantidade de dias em que o faturamento foi maior que a media: {qtdDias}");

            //Questao 4
            Console.WriteLine("\nQuestao 4 \n");

            var faturamento = new Dictionary<string, double>()
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double valorTotal = faturamento.Sum(x => x.Value);

            foreach (var item in faturamento)
            {
                double percentual = item.Value * 100 / valorTotal;

                Console.WriteLine($"{item.Key}, Faturamento: {item.Value}, Porcentagem:{percentual.ToString("N")}%");
            }

            //Questao 5
            Console.WriteLine("\nQuestao 5 \n");

            string palavra = "Teste";

            char[] palavraVetor = palavra.ToCharArray();

            char[] palavraVetorInvertida = new char[palavraVetor.Length];

            int cont = 0;

            for (int i = palavraVetor.Length - 1; i >= 0; i--)
            {
                palavraVetorInvertida[cont] = palavraVetor[i];

                cont++;
            }

            string palavraInvertida = new string(palavraVetorInvertida);

            Console.WriteLine($"Palavra normal: {palavra} \nPalavra invertida: {palavraInvertida}");
        }
    }
}