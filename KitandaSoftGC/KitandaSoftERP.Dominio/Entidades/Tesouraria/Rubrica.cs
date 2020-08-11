using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Rubrica
    {
        public int Codigo { get; set; }
        public int RubricaID { get; set; }
        public string Classificacao { get; set; }
        public string Designacao { get; set; }
        public string Natureza { get; set; }
        public int PlanGeralContaID { get; set; }
        public string Movimento { get; set; } // D - Despesas: R-Receitas
        public int Agrupamento { get; set; }
        public bool IncideDRE { get; set; }
        public string Destino { get; set; }
        public bool IsFixa { get; set; }
        public decimal LookupNumericField12 { get; set; }

        public Rubrica()
        {
            Designacao = string.Empty;
        }

        public Rubrica(int pCodigo, string pDesignation)
        {
            Codigo = pCodigo;
            Designacao = pDesignation;
        }

    }
    public class MovimentoPlanoContaDTO : Retorno.Retorno 
    {
        public int FluxoCaixaID { get; set; }
        public int PlanoContaID { get; set; }
        public PlanoConta PlanoConta { get; set; }
    }
}
