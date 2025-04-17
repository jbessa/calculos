using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculos
{
    /// <summary>
    /// Tipo de conversão de temperatura a executar.
    /// </summary>
    internal static class Conversoes{
    
        public enum static ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        punlic enum ConversaoDistancia{
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }


        /// <summary>
        /// Conversões de temperaturas
        /// </summary>
        /// <param name="conversao">A conversão a efectuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura){

        if (conversao == ConversaoTemperatura.CelsiusFahrenheit){
            return (temperatura * 1.8000 + 32);
        }
        else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
        {
            return ((temperatura -32) / 1.8000);
        }
        return -1;
}
    /// <summary>
    /// Conversão de distâncias.
    /// </summary>
    /// <param name="conversao">Conversão a efectuar</param>
    /// <param name="distancia">A distância a converter</param>
    /// <returns>O resultado da conversão da distância</returns>
     public static double ConverterDistancia(ConversaoDistancia conversao, double distancia){

            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213;
            } else if(conversao == ConversaoDistancia.MilhasMetros){
                return distancia * 1609.344
            }
            return -1;
     }

}
}