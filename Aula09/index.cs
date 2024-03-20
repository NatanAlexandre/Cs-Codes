using System;

class Program {
    static void Main(string[] args){
        // Bitwise >> e << | >> = Metade do valor da variavel | << Dobro do valor da variavel;
        // Deslocamento de Bits >> n (numero de bits para deslocar)

        int num = 20;
        int num2 = 20;

        num = num >> 1;
        num2 = num2 << 2;

        Console.WriteLine("{0}, {1}", num, num2);
    }
}