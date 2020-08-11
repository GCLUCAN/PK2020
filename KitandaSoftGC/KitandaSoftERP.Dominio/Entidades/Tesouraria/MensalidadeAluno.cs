using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class MensalidadeAluno : Retorno.Retorno
    {
        public MensalidadeAluno(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public MensalidadeAluno()
        {

        }

        public MensalidadeAluno(MatriculaDTO pMatricula)
        {
            Matricula = pMatricula;
        }
        public int Codigo { get; set; }

        public MatriculaDTO Matricula { get; set; }

        public ParcelaMensalidade Parcela { get; set; }

        public string Situacao { get; set; }

        public int Fatura { get; set; }

        public DateTime DataCobranca { get; set; }

        public String Multa { get; set; }

        public String CalularMulta { get; set; }

        public decimal Valor { get; set; }

        public string OrigemMulta { get; set; }

        public int Quantidade { get; set; }

        public string Classe { get; set; }

        public decimal ValorLiquidado { get; set; }
        public decimal ValorDebito { get; set; }
        public decimal ValorMulta { get; set; }
        public decimal ValorDesconto { get; set; }
        public object Filtro { get; set; }
        public bool IsFirstMonth { get; set; }
        public bool IsLastMonth { get; set; }
        public string ReferenciaContabil { get; set; }
        public decimal PercentagemMulta { get; set; }
        public decimal PercentagemDesconto { get; set; }
        public string MotivoMulta { get; set; }
        public string MotivoDesconto { get; set; }
        public string MotivoNegociacao { get; set; }
        public int BolsaID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public decimal ComercialDiscount { get; set; }
        public decimal PercentualComercialDiscount { get; set; }

    }
}
