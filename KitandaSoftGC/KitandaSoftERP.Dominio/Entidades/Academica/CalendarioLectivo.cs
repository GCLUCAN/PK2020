using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class CalendarioLectivo
    {
        public int Codigo { get; set; }
        
        public int Periodo { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        public string NomePeriodo { get; set; }

        public string Descricao { get; set; }

        public bool IsPausa { get; set; }

        public int Avaliacao { get; set; }

        public DateTime InicioPeriodo { get; set; }
        public DateTime TerminoPeriodo { get; set; }
        public PeriodoLectivo ObjPeriodo { get; set; }




        public CalendarioLectivo()
        {

        }

        public CalendarioLectivo(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public CalendarioLectivo(int pPeriodo, string pEvento)
        {
            Periodo = pPeriodo;
            Descricao = pEvento;
        }

    }
}
