﻿Console.WriteLine("Informe seu Peso:\n");
double pe= double.Parse (Console.ReadLine());
Console.WriteLine("informe sua Altura:\n");
double al= double.Parse (Console.ReadLine());
double imc = pe/(al*al);

if (imc <= 16.9)
    Console.WriteLine("Você está muito abaixo do peso");
if (17 <= imc && imc <= 18.4)
    Console.WriteLine("Você está abaixo do peso");
if (18.5 <= imc && imc <= 24.9)
    Console.WriteLine("Você está com o peso nomal");
if (25 <= imc && imc <= 29.9)
    Console.WriteLine("Você está acima do peso");
if (30 <= imc && imc <= 34.9)
    Console.WriteLine("Você tem obesidade grau I");
if (35 <= imc && imc <= 40)
    Console.WriteLine("Você tem obesidade grau II");
if (40 <= imc)
    Console.WriteLine("Você tem obesidade grau III");

Console.WriteLine("Digite um número:\n");
    double a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o outro número:\n");
    double b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a opação que vc deseja fazer:" +
    "\nSoma: +" +
    "\nSubtração: -" +
    "\nDivisão: /" +
    "\nMultiplicação: *");
    double c = double.Parse(Console.ReadLine());
double d;
if (c == +)
    d = a + b;
Console.WriteLine($"O resultado é: {d}");
