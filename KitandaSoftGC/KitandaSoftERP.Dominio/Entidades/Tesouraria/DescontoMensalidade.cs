using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class DescontoMensalidade: Retorno.Retorno
    {
        public Desconto PlanoDesconto { get; set; }
        public Mensalidade PlanoMensalidade { get; set; }

        public DescontoMensalidade(int pDesconto, int pItem)
        {
            // TODO: Complete member initialization
            PlanoMensalidade = new Mensalidade(pItem.ToString(), -1);
            PlanoDesconto = new Desconto(pDesconto);
        }

        public DescontoMensalidade()
        {
            // TODO: Complete member initialization
        }
    }
}
