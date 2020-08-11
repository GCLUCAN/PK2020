using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class MultaItemCobranca
    {
        public int MulMensmensalidade { get; set; }
        public int MulMensfatura { get; set; }
        public int MulMensMulta { get; set; }
        public Mensalidade PlanoMensalidade { get; set; }
        public Multa PlanoMultaMensalidade { get; set; }


        public MultaItemCobranca()
        {

        }
        public MultaItemCobranca(int pMultaID, int pItem)
        {
            PlanoMensalidade = new Mensalidade(pItem.ToString(), -1);
            PlanoMultaMensalidade = new Multa(pMultaID);
        }

        public string DescricaoMulta { get; set; }

        public Decimal Valor { get; set; }
    }

}

