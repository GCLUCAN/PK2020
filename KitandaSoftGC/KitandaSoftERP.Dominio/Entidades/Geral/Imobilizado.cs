using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Imobilizado
    {
        public int Imobilizado { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataCompra { get; set; }
        public string Situacao { get; set; }
        public string DataSituacao { get; set; }
        public Decimal ValorDepreciacao { get; set; }
        public Decimal TaxaDepreciacao { get; set; }
        public string ContaContabilistica { get; set; }
        public string CentroCusto { get; set; }
        public string Conservacao { get; set; }
        public string Tipo { get; set; }
        public string Serie { get; set; }
        public string TempoUtil { get; set; }
        public string ModoAquisicao { get; set; }

    }
}
