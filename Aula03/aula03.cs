using System;

class Program {
    static void Main(string[] args){
        int num = 0;
        char letra = 'c';
        float valor = 5.3f;
        byte n1 = 10; // 0 e 255
        string nome = "Natan";

        var aux = nome; // Var não recebe tipo da variável

        Console.WriteLine("Valor da variável: " + aux + "...");
    }
}