namespace Exercicios;

public class Exercicio3
{
    public void Calculator()
    {
        Console.WriteLine("\n\n3) Funções matemáticas com dois valores");
        
        Console.Write("Informe o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Informe o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Soma: {numero1 + numero2}");
        Console.WriteLine($"Subtração: {numero1 - numero2}");
        Console.WriteLine($"Multiplicação: {numero1 * numero2}");
        Console.WriteLine($"Divisão: {numero1 / numero2}");
        Console.WriteLine($"Média: { (numero1 + numero2)/2 }");
    }
}
