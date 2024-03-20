using System;

class Program {
    static void Main(string[] args){
        float n1, n2, n3, n4, media;

        Console.Write("Digite a primeira nota: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        n2 = float.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        n3 = float.Parse(Console.ReadLine());
        Console.Write("Digite a quarta nota: ");
        n4 = float.Parse(Console.ReadLine());

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