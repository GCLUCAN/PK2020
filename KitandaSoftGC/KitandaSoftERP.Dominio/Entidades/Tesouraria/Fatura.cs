using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Fatura : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Numero { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public String EmissaoIni { get; set; }
        public String EmissaoTerm { get; set; }
        public String NomeCliente { get; set; }
        public String Cliente { get; set; }
        public String Recibo { get; set; }
        public decimal Multa { get; set; }
        public decimal Credito { get; set; }
        public string Estado { get; set; }
        public decimal Desconto { get; set; }
        public decimal FatDeducao { get; set; }
        public int Parcela { get; set; }
        public int Dias { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalDescontos { get; set; }
        public decimal TotalRetencao { get; set; }
        public decimal TotalImpostos { get; set; }
        public decimal TotalIliquido { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPedente { get; set; }
        public int Documento { get; set; }
        public int Numeracao { get; set; }
        public string Referencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal DescontoCliente { get; set; }
        public decimal DescontoComercial { get; set; }
        public bool Activo { get; set; }
        public bool Aborted { get; set; }
        public bool Rectified { get; set; }
        public int ComercialDiscountID { get; set; }
        public decimal MonthlyDisCountTax { get; set; }
        public decimal DescontoMensalidade { get; set; }
        public bool ForImpostoSelo { get; set; }

        public Fatura()
        {

        }

        public Fatura(int codigo, string numero, DateTime dataEmissao, DateTime dataPagamento, decimal valor, string pUtilizador, decimal pDeducao)
        {
            Codigo = codigo;
            Numero = numero;
            DataEmissao = dataEmissao;
            DataPagamento = dataPagamento;
            Valor = valor;
            Utilizador = pUtilizador;
            FatDeducao = pDeducao;
        }

        public Fatura(int pFatura)
        {
            // TODO: Complete member initialization
            this.Codigo = pFatura;
        }

        public Fatura(int pFaturaID, int pAcademicYear)
        {
            this.Codigo = pFaturaID;
            AnoLectivo = pAcademicYear;
        }


        public string DocumentoBco { get; set; }
        public string MetodoPagamento { get; set; }
        public string MotivoAnulacao { get; set; }
        public object Curso { get; set; }
        public object AnoCurricular { get; set; }
        public object Turma { get; set; }
        public bool CreditarSaldo { get; set; }
        public decimal SaldoCorrente { get; set; }
        public string IntegracaoContabil { get; set; }
        public int ItemCategory { get; set; }
        public string MonthlyItem { get; set; }
        public string Hash { get; set; }
        public string HashTAG { get; set; }
        public int SerieID { get; set; }
        public decimal TotalWithoutTaxes { get; set; }
        public string DescricaoDocumento { get; set; }
        public int StatusDocumento { get; set; }
        public string StatusPagamento { get; set; }
        public int OriginDocumentID { get; set; }
        public string CustomerNIF { get; set; }
        public string CustomerAddress { get; set; }
        public string ComercialNotes { get; set; }
        public string PriorHash { get; set; }
        public decimal ValorRetificacao { get; set; }
        public int RectifierDocumentID { get; set; }
        public string RectifierDocumentReference { get; set; }
        public decimal ValorIncidencia { get; set; }
    }
}
