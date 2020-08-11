using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class DadosExternos : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public Decimal Divida { get; set; }
        public Decimal Pago { get; set; }
        public Decimal Saldo { get; set; }
        public int MyProperty { get; set; }
        public string DescricaoPagamento { get; set; }
        public string Data { get; set; }
        public string NumeroRecibo { get; set; }
        public int Ano { get; set; }
        public string ModoPagamento { get; set; }
        public string Conta { get; set; }
        public string Banco { get; set; }
        public string TalaoBanco { get; set; }
        public Decimal Valor { get; set; }

        public string Mes { get; set; }

        public string Turma { get; set; }

        public string Turno { get; set; }
    }
}
