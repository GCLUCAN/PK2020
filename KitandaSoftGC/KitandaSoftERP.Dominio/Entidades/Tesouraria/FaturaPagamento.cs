using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class FaturaPagamento : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public Fatura Fatura { get; set; }
        public ContaBancariaDTO ContaBancaria { get; set; }
        public Decimal Valor { get; set; }
        public String Documento { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public DateTime DataDocumento { get; set; }
        public int PaymentMethodCode { get; set; }
        public string AccountNumber { get; set; }
        public string PaymentDescription { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentType { get; set; }
        public int AccountOwner { get; set; }
        public int StudentID { get; set; }
        public decimal BalanceID { get; set; }


        public FaturaPagamento()
        {

        }
       

        public FaturaPagamento(Int32 pCodigo, Fatura pFatura, ContaBancariaDTO pContaBancaria, Decimal pValor, String pDocumento, MeioPagamento pMeio)
        {
            this.Codigo = pCodigo;
            this.Fatura = pFatura;
            this.ContaBancaria = pContaBancaria;
            this.Documento = pDocumento;
            this.Valor = pValor;
            this.MeioPagamento = pMeio;
        }

        public FaturaPagamento(string pFatura, string pContaCorrente, int pMeioPagto, string pFilial)
        {
            Fatura = new Fatura(Convert.ToInt32(pFatura));
            ContaBancaria = new ContaBancariaDTO(pContaCorrente);
            MeioPagamento = new MeioPagamento(pMeioPagto);
            CompanyID = pFilial;
        }

        
    }
}
