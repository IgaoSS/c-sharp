namespace Exercicios;

public class Exercicio2
{
    public void ConcatNames()
    {
        Console.WriteLine("\n\n2) Concatenar um nome e um sobrenome");
        
        Console.Write("Informe o nome: ");
        var nome = Console.ReadLine();
        
        Console.Write("Informe o sobrenome: ");
        var sobrenome = Console.ReadLine();
        
        Console.WriteLine($"Nome completo informado: {nome} {sobrenome}");
    }
}
