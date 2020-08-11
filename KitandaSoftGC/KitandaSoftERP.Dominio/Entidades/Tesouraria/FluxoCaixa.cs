using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class FluxoCaixa : Retorno.Retorno
    {
        public Decimal SaldoActual { get; set; }
        public Decimal SaldoBanco { get; set; }
        public Decimal SaldoCaixa { get; set; }
        public DateTime FluData { get; set; }
        public String FluxoDescricao { get; set; }
        public Decimal FluEntradaDia { get; set; }
        public Decimal FluSaidaDia { get; set; }
        public Decimal FluEntradaBanco { get; set; }
        public Decimal FluSaidaBanco { get; set; }
        public DateTime FluDataIni { get; set; }
        public DateTime FluDataTerm { get; set; }
        public Decimal FluEntradaCaixa { get; set; }
        public Decimal FluSaidaCaixa { get; set; }



    }

    public class ListaFluxosCaixasDTO : List<FluxoCaixa>
    {

    }
}

