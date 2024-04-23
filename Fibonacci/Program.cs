// 1. faça um programa que leia um número inteiro e imprima até esta posição da sequencia fibonacci;

int numero = 0, n1 = 1, n2 = 1, aux = 0;

do
{
    Console.WriteLine("Digite um número de elementos:");
    numero = int.Parse(Console.ReadLine());
} while (numero < 1);

int[] fibonacci = new int[numero];

Console.WriteLine("Sequencia Fibonacci:");

if (numero >= 1)
{
    fibonacci[0] = n1;
}

if (numero >= 2)
{
    fibonacci[1] = n2;
}

if (numero >= 3)
{
    for (int i = 2; i < numero; i++)
    {
        aux = n1 + n2;
        n1 = n2;
        n2 = aux;
        fibonacci[i] = aux;
    }
}

for (int i = 0; i < numero; i++)
{
    Console.Write($"{fibonacci[i]}, ");
}
