namespace HelloWorld;

public class OperacoesMatematicas
{
    public (int resultadoOperacao, string autor) Adicionar(int valor1, int valor2)
    {
        // valor1 + valor2
        var resultado = valor1 + valor2;
        return (resultado, "igor");
    }
}
