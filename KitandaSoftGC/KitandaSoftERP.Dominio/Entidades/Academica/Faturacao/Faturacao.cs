using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica.Faturacao
{
    public class Faturacao
    {
        public int MeioPagamento { get; set; }
        public int Fatura { get; set; }
        public string ContaCorrente { get; set; }
        public decimal Valor { get; set; }
        public string Documento { get; set; }

        public Faturacao()
        {

        }

        public Faturacao(string pFatura, string pMeioPagamento, string pContaCorrente, string pDocumento, decimal pValor, string pFilial)
        {
            if (string.IsNullOrEmpty(pFatura))
            {
                Fatura = -1;
            }
            else
            {
                Fatura = Convert.ToInt32(pFatura);
            }
            MeioPagamento = Convert.ToInt32(pMeioPagamento);
            ContaCorrente = pContaCorrente;
            Valor = pValor;
            CompanyID = pFilial;
            Documento = pDocumento;
        }
    }
}
