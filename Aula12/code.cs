using System;

class Program {
    static void Main(string[] args){
        int nota;
        string resultado = "Reprovado";

        if(nota > 60){
            resultado = "Aprovado";
        }

        Console.WriteLine("Resultado: {0}", resultado);
    }
}