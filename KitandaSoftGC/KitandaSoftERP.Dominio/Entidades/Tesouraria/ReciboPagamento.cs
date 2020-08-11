using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class ReciboPagamento : Retorno.Retorno
    {
        public int Fatura { get; set; }
        public string Numero { get; set; }
        public string DataEmissao { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
        public string ValorExtenso { get; set; }
        public string Inscricao { get; set; }
        public string Nome { get; set; }
        public decimal Unitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Multa { get ; set; }
        public decimal Descontos { get; set; }
        public decimal Troco { get; set; }
        public decimal Credito { get; set; }
        public decimal Saldo { get; set; }
        public string MeioPagamento { get; set; }
        public string Curso { get; set; }
        public string Plano { get; set; }

        public ReciboPagamento()
        {

        }

        public ReciboPagamento(string codigo)
        {
            this.Fatura = Convert.ToInt32(codigo);
        }


        public decimal DeducaoFatura { get; set; }

        public int CategoriaItem { get; set; }

        public decimal DescontoLinha { get; set; }

        public int Item { get; set; }

        public decimal ValorTotal { get; set; }

        public string Classe { get; set; }

        public string Turma { get; set; }

        public string DescricaoCategoria { get; set; }
        public string Mensalidade { get; set; }
        public string HashTAG { get; set; }
        public string Documento { get; set; }
        public int TaxID { get; set; }
        public decimal TaxValue { get; set; }
        public decimal TotalTaxLine { get; set; }
        public string OriginalDocumentReference { get; set; }
        public string MotivoAnulacao { get; set; }
    }
}
