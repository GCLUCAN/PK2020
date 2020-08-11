using System;
using System.Collections.Generic;
using System.Text;


namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class ContaCorrente : Retorno.Retorno
    {
        public ContaCorrente()
        {

        }


        public ContaCorrente(int pAluno)
        {
            CredAluno = new AlunoDTO(pAluno);
        }

        public ContaCorrente(int pAluno, DateTime pData)
        {
            CredAluno = new AlunoDTO(pAluno);
            Data = pData.ToShortDateString();
        }
        public ContaCorrente(AlunoDTO pAluno, decimal pValor, DateTime pMaxDate)
        {
            CredAluno = pAluno;
            CredCredito = (decimal)pValor;
            Data = pMaxDate.ToString();
        }

        public AlunoDTO CredAluno { get; set; }
        public decimal CredCredito { get; set; }
        public int Fatura { get; set; }
        public string Data { get; set; }
        public int Codigo { get; set; }
        public int Destino { get; set; }
        public int Origem { get; set; }
        public int DocumentID { get; set; }
        public int isAdiantamento { get; set; }
        public string Movimento { get; set; }
    }
}
