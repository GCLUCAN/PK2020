using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class DetalhesFatura : Retorno.Retorno
    {
        public Fatura MensFatFatura { get; set; }
        public MensalidadeAluno MensFatAluno { get; set; }
        public DateTime MensFatDataPagamento { get; set; }
        public Decimal MensFatDesconto { get; set; }
        public Decimal MensFatMulta { get; set; }
        public Decimal MensFatValor { get; set; }
        public MultaItemCobranca MultaMensalidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Quantidade { get; set; }
    }
}
