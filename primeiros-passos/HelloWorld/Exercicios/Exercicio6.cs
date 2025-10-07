using System.Globalization;

namespace Exercicios;

public class Exercicio6
{
    public void FormatDates()
    {
        Console.WriteLine("\n\n6) Exibição de data em diferentes formatos");
        DateTime agora = DateTime.Now;

        Console.Write("- Formato completo: ");
        Console.WriteLine(agora.ToString("F", new CultureInfo("pt-BR")));

        Console.Write("- Apenas a data (dd/MM/yyyy): ");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));

        Console.Write("- Apenas a hora (formato 24h): ");
        Console.WriteLine(agora.ToString("HH:mm:ss"));

        Console.Write("- Data com o mês por extenso: ");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
    }
}
