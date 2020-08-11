using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class SaidaCaixa : Retorno.Retorno
    {
        public Int32 SaiCodigo { get; set; }
        public Decimal SaiValor { get; set; }
        public String SaiDocumento { get; set; }
        public String SaiNatureza { get; set; }

        public SaidaCaixa(int codigo, Decimal valor, string documento, string natureza)
        {
            this.SaiCodigo = codigo;
            this.SaiDocumento = documento;
            this.SaiNatureza = natureza;
            this.SaiValor = (decimal)valor;
        }

        public SaidaCaixa()
        {

        }

    }
}
