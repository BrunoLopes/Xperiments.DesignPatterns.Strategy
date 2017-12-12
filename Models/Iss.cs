
namespace Xperiments.DesignPatterns.Strategy.Models
{

    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }

    }

}