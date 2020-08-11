using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Contabilidade
{
    public class PlanoConta : Retorno.TabelaGeral
    {
        public string Numero { get; set; }

        public int ContaPai { get; set; }

        public string Classe { get; set; }

        public string Nivel { get; set; }

        public string RubricaPai { get; set; }
        public bool IsIncome { get; set; }
        public bool IsOutCome { get; set; }

    }
}
