namespace Exercicios;

public class Exercicio4
{
    public void CheckLenWord()
    {
        Console.WriteLine("\n\n4) Calcular quantidade de caracteres nas palavras");
        
        Console.Write("Digite uma palavra ou uma frase: ");
        var palavra = Console.ReadLine();
        
        Console.WriteLine($"Quantidade de caracteres: {palavra?.Replace(" ", "").Length}");
    }
}
