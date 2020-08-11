using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class DetalhesFaturaItem
    {
        public Fatura ItemFatFatura { get; set; }
        public PrecoItemCobranca ItemFatPrecoProduto { get; set; }
        public Decimal ItemFatQuantidade { get; set; }
        public Decimal ItemFatDesconto { get; set; }
        public Decimal ItemFatMulta { get; set; }
        public Decimal ItemFatValor { get; set; }
        public AlunoDTO ItemAluno { get; set; }
        public string ItemReferencia { get; set; }
        public int ItemAnoLectivo { get; set; }
        public int ItemDisciplina { get; set; }
        public object Documento { get; set; }
        public MensalidadeAluno PlanoMensal { get; set; }
        public bool MovimentaStock { get; set; }
    }
}
