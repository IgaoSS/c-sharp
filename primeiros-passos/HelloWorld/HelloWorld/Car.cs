namespace HelloWorld;
public class Car
{
    public string Modelo { get; set; }
    public DateOnly Lancamento { get; set; }
    public Cor Cor { get; set; }

    public Car(string modelo)
    {
        Modelo = modelo;
    }

    public void NomeDoModelo() => Console.WriteLine(Modelo);
}
