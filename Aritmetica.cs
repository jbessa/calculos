namespace Calculos{

//Implmenta operações aritméticas
internal class Aritmetica
{
    /// <summary>
    /// Tipo de conversão de temperatura a executar.
    /// </summary>
    public enum ConversaoTemperatura
    {
        Nulo = 0,
        CelsiusFahrenheit,
        FahrenheitCelsius
    }

    /// <summary>
    /// Operação Soma.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>Retirna a soma de dois números</returns>
    public int Somar(int x, int y)
    {
        return x + y;
    }

/// <summary>
/// Operação Subtrair
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns>Retorna o resultado da subtração de dois números</returns>
    public int Subtrar(int x, int y)
    {
        return x - y;
    }

public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura){

    if (conversao == ConversaoTemperatura.CelsiusFahrenheit){
        return (temperatura * 1.8000 + 32);
    }
    else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
    {
        return ((temperatura -32) / 1.8000);
    }
    return -1;
}


}



}