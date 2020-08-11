using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class EntradaCaixa : Retorno.Retorno
    {
        public int EntCodigo { get; set; }
        public Decimal EntValor { get; set; }

        public String EntDocumento { get; set; }
        public String EntNatureza { get; set; }
        

        public EntradaCaixa(int codigo, Decimal valor, string documento, string natureza)
        {
            this.EntCodigo = codigo;
            this.EntDocumento = documento;
            this.EntNatureza = natureza;
            this.EntValor = valor;
        }

        public EntradaCaixa()
        {

        }

    }
}
