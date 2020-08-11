using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica.Secretaria
{
    public class Agenda
    {
        public int CompromissoID { get; set; }
        public DateTime DataMarcacao { get; set; }
        public DateTime DataCompromisso { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
    }
}
