using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Estagio: Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Designacao { get; set; }
        public Docente Docente { get; set; }
        public AnoCurricular Ano { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public bool IsPago { get; set; }
    }
}
