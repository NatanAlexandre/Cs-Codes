using System;

class Program {
    static void Main(string[] args){
        float n1 = 11, n2, n3, n4, media;

        Console.Write("Digite a primeira nota: ");
        n1 = float.Parse(Console.ReadLine());
        while(n1 > 10f || n1 < 0){
            Console.WriteLine("Apenas notas de 0 a 10");
            Console.Write("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
        }
        Console.Write("Digite a segunda nota: ");
        n2 = float.Parse(Console.ReadLine());
        while(n2 > 10f || n2 < 0){
            Console.WriteLine("Apenas notas de 0 a 10");
            Console.Write("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
        }
        Console.Write("Digite a terceira nota: ");
        n3 = float.Parse(Console.ReadLine());
        while(n3 > 10f || n3 < 0){
            Console.WriteLine("Apenas notas de 0 a 10");
            Console.Write("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
        }
        Console.Write("Digite a quarta nota: ");
        n4 = float.Parse(Console.ReadLine());
        while(n4 > 10f || n4 < 0){
            Console.WriteLine("Apenas notas de 0 a 10");
            Console.Write("Digite a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());
        }

        media = ((n1 + n2 + n3 + n4) / 4f);

        if(media >= 6f){
            Console.WriteLine("Parabéns, você foi aprovado!");
        } else if (media >= 4f) {
            Console.WriteLine("Você ficou de recuperação!");
        } else {
            Console.WriteLine("Você foi reprovado!");
        }

        Console.WriteLine("Media: {0}", media);
    }
}