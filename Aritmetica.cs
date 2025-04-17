using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculos{

//Implmenta operações aritméticas
internal class Aritmetica
{
    
   
    /// <summary>
    /// Operação Soma.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>Retirna a soma de dois números</returns>
    public static int Somar(int x, int y)
    {
        return x + y;
    }

    /// <summary>
    /// Operação Subtrair
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>Retorna o resultado da subtração de dois números</returns>
    public static int Subtrar(int x, int y)
    {
        return x - y;
    }
}
}