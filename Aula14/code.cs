using System;

class Program {
    static void Main(string[] args){
        int tempo;
        char escolha;
        Console.WriteLine("Belo Horizonte/MG a VItória/ES");
        Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [O] Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
                tempo = 50;
                break;
            case 'c':
                tempo = 480;
                break;
            case 'o':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0){
            Console.WriteLine("Transporte Indisponível");
        } else {
            Console.WriteLine("O tempo para o Transporte escolhido, é {0} minutos", tempo);
        }
    }
}