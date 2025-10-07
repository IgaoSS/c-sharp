using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Exercicios;

class Program
{
    static void Main()
    {
        Exercicio1 exercicio1 = new Exercicio1();
        exercicio1.Welcome();

        Exercicio2 exercicio2 = new Exercicio2();
        exercicio2.ConcatNames();

        Exercicio3 exercicio3 = new Exercicio3();
        exercicio3.Calculator();

        Exercicio4 exercicio4 = new Exercicio4();
        exercicio4.CheckLenWord();

        Exercicio5 exercicio5 = new Exercicio5();
        exercicio5.ValidatePlate();

        Exercicio6 exercicio6 = new Exercicio6();
        exercicio6.FormatDates();
    }
}