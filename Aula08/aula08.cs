using System;

class Program {
    static void Main(string[] args){
        int n1, n2, soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        n2 = int.Parse(Console.ReadLine());
        soma = n1 + n2;
        Console.WriteLine("A soma dos números {0} e {1} é {2}", n1, n2, soma);

    }
}