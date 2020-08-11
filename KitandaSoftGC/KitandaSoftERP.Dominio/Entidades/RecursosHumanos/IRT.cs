using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.RecursosHumanos
{
    public class IRT : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public double SalarioMinimo { get; set; }

        public double SalarioMaximo { get; set; }

        public double ValorMinimoDesconto { get; set; }

        public double PercentualDesconto { get; set; }


        public IRT()
        {
            Codigo = 0;
            SalarioMinimo = 0;
            SalarioMaximo = 0;
            ValorMinimoDesconto = 0;
            PercentualDesconto = 0;
        }

        public IRT(int pCodigo, double pValorMinimo, double pValorMaximo, double pValorMinDesconto, double pPercentagemDesconto)
        {
            Codigo = pCodigo;
            SalarioMinimo = pValorMinimo;
            SalarioMaximo = pValorMaximo;
            ValorMinimoDesconto = pValorMinDesconto;
            PercentualDesconto = pPercentagemDesconto;
        }
    }
}
