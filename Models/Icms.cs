namespace Xperiments.DesignPatterns.Strategy.Models
{
    
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

    }
}