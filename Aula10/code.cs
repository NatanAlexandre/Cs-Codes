using System;

class Program {
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(string[] args) {
        DiasSemana ds = (int)DiasSemana.Sexta;
        DiasSemana ds2 = (DiasSemana)0;

        Console.WriteLine("{0}", ds);
    }
}