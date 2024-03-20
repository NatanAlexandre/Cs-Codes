using System;

class Program {
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(string[] args) {
        int ds = (int)DiasSemana.Sexta;
        DiasSemana ds2 = (DiasSemana)3;

        Console.WriteLine("{0}, {1}", ds, ds2);
    }
}