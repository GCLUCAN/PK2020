using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Retorno
{
    public class TabelaGeral: Retorno
    {
        public int Codigo { get; set; }
        public string Sigla { get; set; }
        public int Estado { get; set; }
        public int IndicePagina { get; set; }
        public int RegistosPorPagina { get; set; }
        public string Operacao { get; set; }
    }
}
