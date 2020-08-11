using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class ItensFatura : Retorno.Retorno
    {
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public string ItemDesignation { get; set; }
        public decimal Quantidade { get; set; }
        public decimal TaxValue { get; set; }
        public DateTime DataLimite { get; set; }
        public decimal ValorDocumento { get; set; }
        public decimal ValorMultas { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorImpostoLinha { get; set; }
        public decimal ValorTotal { get; set; }
        public int MultaID { get; set; }
        public int DisciplinaID { get; set; }
        public int DocumentID { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Troco { get; set; }
        public string Responsavel { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int CategoryID { get; set; }
        public MensalidadeAluno Propina { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public bool MovimentStock { get; set; }
        public decimal Existencia { get; set; }
        public bool IsFaturacaoExterna { get; set; }
        public int StudentID { get; set; }
        public string StudentDetails { get; set; }
        public List<ItensFatura> StudentBilledItemList { get; set; }
        public string ReferenciaContabil { get; set; }
        public AlunoDTO Student { get; set; }
        public decimal DiscountHidden { get; set; }
        public int TaxID { get; set; }
        public decimal PercentDiscountLine { get; set; }
        public decimal PercentComercialDiscount { get; set; }
        public decimal PercentCustomerDiscount { get; set; }
        public decimal PercentualMonthlyDiscount { get; set; }
        public decimal DiscountLine { get; set; }
        public decimal ComercialDiscount { get; set; }
        public decimal CustomerDiscount { get; set; }
        public decimal MonthlyDiscountValue { get; set; }
        public int MonthlyDiscountID { get; set; }
        public decimal TotalSIVA { get; set; }
        public string Unidade { get; set; }
        public int MensalidadeID { get; set; }
        public int ItemCustomerDiscountTarget { get; set; }

    }
}
