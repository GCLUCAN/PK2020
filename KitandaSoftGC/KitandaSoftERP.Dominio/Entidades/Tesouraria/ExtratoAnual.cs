using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class ExtratoAnual
    {
        public int Ano { get; set; }
        public Decimal Janeiro { get; set; }
        public Decimal Fevereiro { get; set; }
        public Decimal Marco { get; set; }
        public Decimal Abril { get; set; }
        public Decimal Maio { get; set; }
        public Decimal Junho { get; set; }
        public Decimal Julho { get; set; }
        public Decimal Agosto { get; set; }
        public Decimal Setembro { get; set; }
        public Decimal Outubro { get; set; }
        public Decimal Novembro { get; set; }
        public Decimal Dezembro { get; set; }
        public Decimal Valor { get; set; }
        public string Descricao { get; set; }

        public Decimal Anterior { get; set; }


        public Decimal Global { get; set; }

        public string Aluno { get; set; }

        public string Turma { get; set; }

        public int CursoID { get; set; }

        public string Classe { get; set; }

        public int AnoCurricular { get; set; }

        public decimal Multas { get; set; }

        public Decimal PagtoAtrasados { get; set; }

        public Decimal PagtosAbertos { get; set; }

        public string Designacao { get; set; }

        public decimal Liquidado { get; set; }
    }
}
