using System;
using System.Globalization;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Console.WriteLine("Seja bem vindo à lista de exercícios de estruturas sequenciais. A seguir será fornecido o tópico dos 6 exercícios onde você poderá escolher um deles para testar.");

            while (continuar != 0)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Exercício 1 - Soma de 2 valores inteiros.");
                Console.WriteLine("Exercício 2 - Área de um círculo.");
                Console.WriteLine("Exercício 3 - Diferença entre 4 valores inteiros.");
                Console.WriteLine("Exercício 4 - Cálculo de salário de um funcionário.");
                Console.WriteLine("Exercício 5 - Valor a ser pago em uma compra.");
                Console.WriteLine("Exercício 6 - Área de figuras 2D.");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Escola a opção do exercício desejado (se desejar encerrar o programa digite qualquer outro número):");
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                if (opcao == 1)
                {
                    Console.WriteLine("Exercício 1");
                    Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.");

                    Console.Write("Número 1 = ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("Número 2 = ");
                    int n2 = int.Parse(Console.ReadLine());
                    int soma = n1 + n2;
                    Console.WriteLine($"SOMA = {soma}");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Exercício 2");
                    Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos");
                    Console.WriteLine("Fórmula da área: area = π . raio2");
                    Console.WriteLine("Considere o valor de π = 3.14159");

                    Console.WriteLine("");

                    Console.Write("Raio do círculo = ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area = 3.14159 * Math.Pow(raio, 2);
                    Console.WriteLine($"A={area.ToString("F4")}");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Exercício 3");
                    Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).");

                    Console.Write("Número 1 = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Número 2 = ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Número 3 = ");
                    int c = int.Parse(Console.ReadLine());
                    Console.Write("Número 4 = ");
                    int d = int.Parse(Console.ReadLine());

                    int diferenca = (a * b) - (c * d);
                    Console.WriteLine($"DIFERENCA = {diferenca}");
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Exercício 4");
                    Console.WriteLine("Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.");

                    Console.Write("Código de funcionário = ");
                    int codigo_funcionario = int.Parse(Console.ReadLine());
                    Console.Write("Quantidade de horas trabalhadas = ");
                    int horas_trabalhadas = int.Parse(Console.ReadLine());
                    Console.Write("Valor recebido por hora trabalhada = ");
                    double valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double salario = valor_hora * horas_trabalhadas;

                    Console.WriteLine($"NUMBER = {codigo_funcionario}");
                    Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Exercício 5");
                    Console.WriteLine("Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.");

                    // Opção para caso os valores sejam na mesma linha
                    Console.Write("Informe na mesma linha o código, quantidade e valor do produto 1 = ");
                    string[] peca1 = Console.ReadLine().Split(" ");
                    int cod_peca1 = int.Parse(peca1[0]);
                    int qtd_peca1 = int.Parse(peca1[1]);
                    double val_peca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

                    Console.Write("Informe na mesma linha o código, quantidade e valor do produto 2 = ");
                    string[] peca2 = Console.ReadLine().Split(" ");
                    int cod_peca2 = int.Parse(peca2[0]);
                    int qtd_peca2 = int.Parse(peca2[1]);
                    double val_peca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

                    /* Opção para casos os valores sejam em linhas diferentes
                     * Console.Write("Código do produto 1 = ");
                    int cod_peca1 = int.Parse(Console.ReadLine());
                    Console.Write("Número de peças para o produto 1 = ");
                    int qtd_peca1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor unitário so produto 1 = ");
                    double val_peca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Código do produto 2 = ");
                    int cod_peca2 = int.Parse(Console.ReadLine());
                    Console.Write("Número de peças para o produto 2 = ");
                    int qtd_peca2 = int.Parse(Console.ReadLine());
                    Console.Write("Valor unitário so produto 2 = ");
                    double val_peca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);*/

                    double total = (qtd_peca1 * val_peca1) + (qtd_peca2 * val_peca2);

                    Console.WriteLine($"VALOR A PAGAR: R${total.ToString("F2")}");
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Exercício 6");
                    Console.WriteLine("Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: ");
                    Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura. ");
                    Console.WriteLine("b) a área do círculo de raio C. (pi = 3.14159)");
                    Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura. ");
                    Console.WriteLine("d) a área do quadrado que tem lado B. ");
                    Console.WriteLine("e) a área do retângulo que tem lados A e B.");

                    Console.Write("Digite os valores dos lados A, B e C, respectivamente, na mesma linha: ");
                    string[] valores = Console.ReadLine().Split(" ");
                    double a = double.Parse(valores[0]);
                    double b = double.Parse(valores[1]);
                    double c = double.Parse(valores[2]);

                    double triangulo = (a * c) / 2;
                    double circulo = 3.14159 * Math.Pow(c, 2);
                    double trapezio = ((a + b) * c) / 2;
                    double quadrado = b * b;
                    double retangulo = a * b;

                    Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
                    Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
                    Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
                    Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
                    Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
                }
                else
                {
                    break;
                }
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Digite 1 caso queira verificar outro exercício ou 0 para encerrar: ");
                continuar = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Clear();
            }
        }
    }
}
