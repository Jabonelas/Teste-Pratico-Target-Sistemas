using System.Text.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Questao 1

            //Resposta o valor da SOMA sera: 91

            //Questao 2

            Questao2();

            //Questao 3

            Questao3();

            //Questao 4

            Questao4();

            //Questao 5

            Questao5();
        }

        public static void Questao2()
        {
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
        }

        public static void Questao3()
        {
            Console.WriteLine("\n\nQuestao 3 \n");

            string json = @"[
	{
		""dia"": 1,
		""valor"": 22174.1664
	},
	{
		""dia"": 2,
		""valor"": 24537.6698
	},
	{
		""dia"": 3,
		""valor"": 26139.6134
	},
	{
		""dia"": 4,
		""valor"": 0.0
	},
	{
		""dia"": 5,
		""valor"": 0.0
	},
	{
		""dia"": 6,
		""valor"": 26742.6612
	},
	{
		""dia"": 7,
		""valor"": 0.0
	},
	{
		""dia"": 8,
		""valor"": 42889.2258
	},
	{
		""dia"": 9,
		""valor"": 46251.174
	},
	{
		""dia"": 10,
		""valor"": 11191.4722
	},
	{
		""dia"": 11,
		""valor"": 0.0
	},
	{
		""dia"": 12,
		""valor"": 0.0
	},
	{
		""dia"": 13,
		""valor"": 3847.4823
	},
	{
		""dia"": 14,
		""valor"": 373.7838
	},
	{
		""dia"": 15,
		""valor"": 2659.7563
	},
	{
		""dia"": 16,
		""valor"": 48924.2448
	},
	{
		""dia"": 17,
		""valor"": 18419.2614
	},
	{
		""dia"": 18,
		""valor"": 0.0
	},
	{
		""dia"": 19,
		""valor"": 0.0
	},
	{
		""dia"": 20,
		""valor"": 35240.1826
	},
	{
		""dia"": 21,
		""valor"": 43829.1667
	},
	{
		""dia"": 22,
		""valor"": 18235.6852
	},
	{
		""dia"": 23,
		""valor"": 4355.0662
	},
	{
		""dia"": 24,
		""valor"": 13327.1025
	},
	{
		""dia"": 25,
		""valor"": 0.0
	},
	{
		""dia"": 26,
		""valor"": 0.0
	},
	{
		""dia"": 27,
		""valor"": 25681.8318
	},
	{
		""dia"": 28,
		""valor"": 1718.1221
	},
	{
		""dia"": 29,
		""valor"": 13220.495
	},
	{
		""dia"": 30,
		""valor"": 8414.61
	}
]";

            List<Faturamento> faturamentoDiario = JsonSerializer.Deserialize<List<Faturamento>>(json);

            double mediaMensal = faturamentoDiario.Where(x => x.Valor != 0).Average(x => x.Valor);

            double qtdDias = faturamentoDiario.Where(x => x.Valor >= mediaMensal).Count();

            var menorValor = faturamentoDiario.Where(x => x.Valor > 0).Min();
            var maiorValor = faturamentoDiario.Max();

            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
            Console.WriteLine($"Quantidade de dias em que o faturamento foi maior que a media: {qtdDias}");
        }

        public static void Questao4()
        {
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
        }

        public static void Questao5()
        {
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

    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}