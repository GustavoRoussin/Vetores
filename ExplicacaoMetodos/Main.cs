namespace ExplicacaoMetodos
{
    public class Main
    {
        
        public void Start()
        {
            Menu();
        }

        public void Menu()
        {
            int opcao = 1;

            while (opcao != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("Exercício 1 - Descubra o maior número dentre um grupo de números reais.");
                Console.WriteLine("Exercício 2 - Em um conjunto de números, descubra quantos e quais são os números pares");
                Console.WriteLine("Exercício 3 - Preencha dois vetores diferentes e some os valores de ambos em um novo vetor");
                Console.WriteLine("Exercício 4 - De um grupo de números reais, descubra a média dos números inseridos e quais estão abaixo da média");
                Console.WriteLine("Exercício 5 - De um grupo de números inteiros, descubra a média dos números pares inseridos");
                Console.WriteLine("Exercício 6 - Descubra a pessoa mais velha entre um grupo de pessoas e suas idades");
                Console.WriteLine("Exercício 7 - De um grupo de alunos com duas notas cada, descubra quais alunos obtiveram média superior a 6");
                Console.WriteLine("Exercício 8 - Em um conjunto de pessoas com informações de nome, sexo e idade, descubra a maior e menor altura, média de altura das mulheres e a quantidade de homens ");
                Console.WriteLine("Exercício 9 - A partir de valores de produtos inseridos, descubra as taxas de lucro, compra e venda");

                Console.WriteLine("Sair = 0");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    case 5:
                        Exercicio5();
                        break;

                    case 6:
                        Exercicio6();
                        break;

                    case 7:
                        Exercicio7();
                        break;

                    case 8:
                        Exercicio8();
                        break;

                    case 9:
                        Exercicio9();
                        break;
                    
                    default:
                        break;
                }

            }
        }

        public void Exercicio1()
        {
            Console.WriteLine("Digite a quantidade de números");
            int tamanho = int.Parse(Console.ReadLine());
            double[] numeros = new double[tamanho];

            var maiorNumero = 0.0;
            var posicaoDoMaiorNumero = 0;

            Console.WriteLine("Digite os números desejados: ");
            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                    posicaoDoMaiorNumero = i;
                }
            }

            Console.WriteLine($"Maior numero {maiorNumero}");
            Console.WriteLine($"Posição do maior numero {posicaoDoMaiorNumero}");
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Exercicio2()
        {
            Console.WriteLine("Insira a quantidade de números desejados: ");
            int qtdNumeros = int.Parse(Console.ReadLine());

            int[] numeros = new int[qtdNumeros];

            int qtdPares = 0;

            Console.WriteLine("Digite os números desejados: ");
            for (int i = 0; i < qtdNumeros; i++)
                numeros[i] = int.Parse(Console.ReadLine());


            Console.WriteLine("Números pares: ");

            for (int i = 0; i < qtdNumeros; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write($"{numeros[i]} ");
                    qtdPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Quantidade de números pares: \n{qtdPares}");
            Console.WriteLine();
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Exercicio3()
        {
            Console.WriteLine("Digite a quantidade de números para ambos os vetores:");
            int tamanho = int.Parse(Console.ReadLine());
            int[] numerosA = new int[tamanho];
            int[] numerosB = new int[tamanho];
            int[] numerosC = new int[tamanho];

            Console.WriteLine("Digite os números para cada vetor:");
            
            for (int i = 0; i < tamanho; i++)
            {
                numerosA[i] = int.Parse(Console.ReadLine());
                numerosB[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < tamanho; i++)
            {
                numerosC[i] = numerosA[i] + numerosB[i];
            }

            Console.WriteLine("Números nas mesmas posições somados: ");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(numerosC[i]);
            }
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Exercicio4()
        {
            Console.WriteLine("Insira a quantidade de números: ");
            int tamanho = int.Parse(Console.ReadLine());
            double[] numeros = new double[tamanho];
            double media = 0;

            Console.WriteLine("Digite os números: ");
            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                media += numeros[i];
            }

            media = media / tamanho;

            Console.WriteLine($"Média: " + media);
            Console.WriteLine();

            Console.WriteLine("Números abaixo da média: ");
            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] < media)
                {
                    Console.WriteLine(numeros[i]);
                    //NumerosMenores[i] = numeros[i];
                }
            }
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Exercicio5()
        {
            Console.WriteLine("Insira a quantidade de números: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] numeros = new int[tamanho];
            double media = 0.0;

            Console.WriteLine("Insira os números: ");
            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    media += numeros[i];
                    count++;
                }
            }
            media = media / count;
            Console.WriteLine($"Média dos números pares: " + media);
            Console.WriteLine();
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Exercicio6()
        {
            Console.WriteLine("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            string[] vetAux = new string[2];
            string pessoaMaisVelha = null;
            int maiorIdade = 0;

            Console.WriteLine("Digite o nome da pessoa seguido da sua idade: ");
            for (int i = 0; i < n; i++)
            {
                vetAux = Console.ReadLine().Split(' ');
                string nome = vetAux[0];
                int idade = int.Parse(vetAux[1]);

                if (maiorIdade < idade)
                {
                    maiorIdade = idade;
                    pessoaMaisVelha = nome;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void Exercicio7()
        {
            Console.WriteLine("Informe a quantidade de alunos:");
            int qntAlunos = int.Parse(Console.ReadLine());

            string[] vetAlunoENotas = new string[qntAlunos];

            for (int i = 0; i < qntAlunos; i++)
            {
                vetAlunoENotas[i] = Console.ReadLine();
            }

            Console.WriteLine("Alunos Aprovados");

            for (int i = 0; i < qntAlunos; i++)
            {
                string[] vetSplit = vetAlunoENotas[i].Split(" ");

                double nota1 = double.Parse(vetSplit[1]);
                double nota2 = double.Parse(vetSplit[2]);

                double media = (nota1 + nota2) / 2;

                if (media >= 6)
                {
                    Console.WriteLine(vetSplit[0]);
                }
            }
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        
        public void Exercicio8()
        {
            int n; 
            double maiorAltura = 0, menorAltura = 10000, mediaAlturaMulheres = 0;
            int numHomens = 0;

            Console.Write("Informe o número de pessoas: ");
            n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexos = new char[n];

            // leitura das alturas e sexos
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe a altura da pessoa {0}: ", i + 1);
                alturas[i] = double.Parse(Console.ReadLine());
                Console.Write("Informe o sexo da pessoa {0} (M/F): ", i + 1);
                sexos[i] = char.Parse(Console.ReadLine().ToUpper());
            }

            // cálculo da maior e menor altura
            for (int i = 0; i < n; i++)
            {
                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }

            // cálculo da média de altura das mulheres e do número de homens
            int numMulheres = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexos[i] == 'F')
                {
                    mediaAlturaMulheres += alturas[i];
                    numMulheres++;
                }
                else
                {
                    numHomens++;
                }
            }

            // exibição dos resultados
            Console.WriteLine("Maior altura: {0}", maiorAltura);
            Console.WriteLine("Menor altura: {0}", menorAltura);
            if (numMulheres > 0)
            {
                mediaAlturaMulheres /= numMulheres;
                Console.WriteLine("Média de altura das mulheres: {0}", mediaAlturaMulheres);
            }
            else
            {
                Console.WriteLine("Não há mulheres no grupo.");
            }
            Console.WriteLine("Número de homens: {0}", numHomens);
            Console.WriteLine();
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    
        public void Exercicio9()
        {
            Console.WriteLine("Digite a quantidade de produtos:");
            int qtdProdutos = int.Parse(Console.ReadLine());

            string[] produtos = new string[qtdProdutos];

            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine("Digite nome, preço de compra e preço de venda:");
                produtos[i] = Console.ReadLine();
            }

            // PROCESSAMENTO
            double precoCompra, precoVenda;

            // VARIAVEIS DE SAÍDA

            int countLucroMenor10 = 0;
            int countLucroEntre10E20 = 0;
            int countLucroAcima20 = 0;
            double valorTotalCompra = 0;
            double valorTotalVenda = 0;
            double lucroTotal = 0;

            for (int i = 0; i < qtdProdutos; i++)
            {
                var vet = produtos[i].Split(" ");

                //precoCompra = double.Parse(produtos[i].Split(" ")[1]);
                //precoVenda = double.Parse(produtos[i].Split(" ")[2]);

                precoCompra = double.Parse(vet[1]);
                precoVenda = double.Parse(vet[2]);

                double lucro = (precoVenda - precoCompra) / precoVenda;

                if (lucro < 0.1)
                {
                    countLucroMenor10++;
                }
                else if (lucro < 0.2)
                {
                    countLucroEntre10E20++;
                }
                else
                {
                    countLucroAcima20++;
                }

                valorTotalCompra += precoCompra;
                valorTotalVenda += precoVenda;
                lucroTotal += precoVenda - precoCompra;
            }

            Console.WriteLine($"Lucro abaixo de 10%: {countLucroMenor10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {countLucroEntre10E20}");
            Console.WriteLine($"Lucro acima de 20%: {countLucroAcima20}");
            Console.WriteLine($"Valor total de compra: {valorTotalCompra}");
            Console.WriteLine($"Valor total de venda: {valorTotalVenda}");
            Console.WriteLine($"Lucro total: {lucroTotal}");
            Console.WriteLine("Digite ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

