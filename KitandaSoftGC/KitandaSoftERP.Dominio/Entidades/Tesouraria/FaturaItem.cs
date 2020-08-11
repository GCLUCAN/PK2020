using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class FaturaItem : Retorno.Retorno
    {
        public int ProductID { get; set; }
        public int Fatura { get; set; }
        public int Item { get; set; }
        public string DsItem { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal SubTotal { get; set; }
        public string Responsavel { get; set; }
        public string Tipo { get; set; }
        public decimal Pago { get; set; }
        public decimal Troco { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorMulta { get; set; }
        public string Referencia { get; set; }
        public int CodigoMulta { get; set; }
        public string Disciplina { get; set; }
    }
}
