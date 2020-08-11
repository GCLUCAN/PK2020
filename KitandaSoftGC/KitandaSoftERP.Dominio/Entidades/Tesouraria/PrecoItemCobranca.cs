using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class PrecoItemCobranca : Retorno.Retorno
    {
        public int PreCodigo { get; set; }
        public ItemCobranca PreItemCobranca { get; set; }
        public Decimal PrePreco { get; set; }
        public DateTime PreInicio { get; set; }
        public DateTime PreTermino { get; set; }


        public PrecoItemCobranca()
        {

        }

        public PrecoItemCobranca(int pCodigo)
        {
            PreItemCobranca = new ItemCobranca(pCodigo);
        }

        public PrecoItemCobranca(int codigo, ItemCobranca item, Decimal preco, DateTime inicio, DateTime termino)
        {
            PreCodigo = codigo;
            PreItemCobranca = item;
            PrePreco = preco;
            PreInicio = inicio;
            PreTermino = termino;
        }

        public PrecoItemCobranca(decimal pPreco)
        {
            PrePreco = pPreco;
        }
    }

    public class ListaPrecosItensCobrancaDTO : List<PrecoItemCobranca>
    {

    }
}

