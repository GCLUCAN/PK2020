using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Agenda : Retorno.Retorno
    {
        public int Codigo { get; set; }

        public string Marcacao { get; set; }

        public DateTime DataMarcacao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        public DateTime DataRealizacao { get; set; }

        public string Profissional { get; set; }

        public string Especialidade { get; set; }

        public string Utente { get; set; }

        public string Observacao { get; set; }
    }
}
