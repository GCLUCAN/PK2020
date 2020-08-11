using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class PeriodoLancamento : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int PeriodoLectivoID { get; set; }
        public bool IsPeriodoExtra { get; set; }
        public bool IsDeleted { get; set; }
        public int ExameID { get; set; }
    }
}
