using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public  class ContaPagarReceber
    {
        public int Codigo { get; set; }
        public int Documento { get; set; }
        public string Referencia { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public int Parcela { get; set; }
        public string Natureza { get; set; }
        public int RubricaID { get; set; }
        public decimal Valor { get; set; }
        public decimal Pendente { get; set; }
        public int Moeda { get; set; }
        public decimal Cambio { get; set; }
        public int Periodicidade { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public decimal Saldo { get; set; }
    }
}
