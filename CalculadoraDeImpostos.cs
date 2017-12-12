using System;
using Xperiments.DesignPatterns.Strategy.Models;

namespace Xperiments.DesignPatterns.Strategy
{

    public class CalculadoraDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var x = imposto.Calcula(orcamento);
            Console.WriteLine(x);
            
        }

    }

}