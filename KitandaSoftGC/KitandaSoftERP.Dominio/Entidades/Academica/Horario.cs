using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Horario : Retorno.Retorno
    {
        public int HorCodigo { get; set; }
        public Docente HorDocente { get; set; }
        public int HorDiaSemana { get; set; }
        public int HorInicio { get; set; }
        public int HorTermino { get; set; }
        public string HorSala { get; set; }
        public string HorRegime { get; set; }
        public Turma HorTurma { get; set; }
        public UnidadeCurricular HorDisiciplina { get; set; }

        public AnoLectivo HorAnoLectivo { get; set; }


        public decimal Duracao { get; set; }
        public string Turno { get; set; }

        public string SegundaFeira { get; set; }

        public string TercaFeira { get; set; }

        public string QuartaFeira { get; set; }

        public string QuintaFeira { get; set; }

        public string SextaFeira { get; set; }

        public string Sabado { get; set; }

        public DateTime Validade { get; set; }

        public string Curso { get; set; }

        public string Departamento { get; set; }

        public string HorPeriodo { get; set; }

        public string Horarios { get; set; }

        public DateTime PeriodoFrom { get; set; }

        public DateTime PeriodoTerm { get; set; }
    }
}
