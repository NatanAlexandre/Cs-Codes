using System;

// Array

class Program {
    static void Main(string[] args){
        int n1, n2, n3, n4, n5;

        int[] n = new int[5]; // 0
        int[] num = new int[3]{55, 77, 99};
        int[] numl = {55, 77, 99}; // usa o número de elemntos passados

        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine(n[4]);
        Console.WriteLine(num[2]);
    }
}