using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Convenio : Retorno.TabelaGeral
    {
        public int Instituicao { get; set; }
        public string NomeInstituicao { get; set; }
        public string Tipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

    }
}
