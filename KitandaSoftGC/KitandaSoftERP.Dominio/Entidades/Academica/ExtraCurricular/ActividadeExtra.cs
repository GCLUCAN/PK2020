using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica.ExtraCurricular
{
    public class ActividadeExtra
    {
        public int Codigo { get; set; }
        public string Actividade { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Prolector { get; set; }
        public string Horario { get; set; }
        public string Situacao { get; set; } // F - Finalizado; A - Agendado; C- Cancelado; E-Em Curso; D - Excluído

    }
    public class ActidadeInscricaoDTO
    {
        public int Actividade { get; set; }
        public string Participante { get; set; }
        public int DataAdesao { get; set; }
        public string Situacao { get; set; }
    }
}
