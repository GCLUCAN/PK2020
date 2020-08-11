using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class SituacaoFinanceira : Retorno.Retorno
    {
        public Int32 FinFatura { get; set; }
        public String FinDescricao { get; set; }
        public String FinData { get; set; }
        public Decimal FinValor { get; set; }
        public String FinStatus { get; set; }
        public string Tipo { get; set; }

        public int Categoria { get; set; }

        public int Parcela { get; set; }

        public int Codigo { get; set; }

        public Decimal Total { get; set; }

        public string NumeroInscricao { get; set; }

        public string NomeAluno { get; set; }

        public string NroRecibo { get; set; }

        public string Turma { get; set; }

        public string Curso { get; set; }

        public string Classe { get; set; }
    }
}
