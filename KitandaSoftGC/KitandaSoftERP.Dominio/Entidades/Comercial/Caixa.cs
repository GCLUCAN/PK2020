using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class Caixa: Retorno.Retorno
    {
      
        public int CxCodigo { get; set; }
        public DateTime CxData { get; set; }
        public DateTime CxAbertura { get; set; }
        public decimal CxValorInicial { get; set; }
        public DateTime CxFecho { get; set; }
        public decimal CxValorFinal { get; set; }
        public string CxUtilizadorOpen { get; set; }
        public string CxUtilizadorClose { get; set; }
        public String CxStatus { get; set; }

        public Caixa()
        {

        }

        public Caixa(int pCodigo, string pDesignacao)
        {
            CxCodigo = pCodigo;
            Descricao = pDesignacao;
        }
    }
}
