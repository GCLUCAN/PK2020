using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica.ExtraCurricular
{
    public class ATL : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Aluno { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Modalidade { get; set; }
        public string Situacao { get; set; }

    }
}
