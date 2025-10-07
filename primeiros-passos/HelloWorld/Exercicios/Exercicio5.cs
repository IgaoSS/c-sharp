namespace Exercicios;

public class Exercicio5
{
    public void ValidatePlate()
    {
        Console.WriteLine("\n\n5) Validação de placa de veículoi");
        Console.Write("Informe a placa do veículo: ");
        var placa = Console.ReadLine();

        bool validacao = true;
        if (placa.Length != 7)
        {
            validacao = false;
        }
        else
        {
            for (int i = 0; i < placa.Length; i++)
            {
                if (i < 3)
                {
                    if (!char.IsLetter(placa[i]))
                    {
                        validacao = false;
                    }
                }
                else
                {
                    if (!char.IsNumber(placa[i]))
                    {
                        validacao = false;
                    }
                }
            }
        }
        
        Console.WriteLine($"Placa validada? {validacao}");
    }
}
