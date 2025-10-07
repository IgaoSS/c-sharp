namespace Exercicios;

public class Exercicio1
{
    public void Welcome()
    {
        Console.WriteLine("1) Programa para dar boas-vindas ao usuário");
        
        Console.Write("Informe seu usuário: ");
        var usuario = Console.ReadLine();
        
        Console.WriteLine($"Olá, {usuario}! Seja muito bem-vindo!");
    }
}
