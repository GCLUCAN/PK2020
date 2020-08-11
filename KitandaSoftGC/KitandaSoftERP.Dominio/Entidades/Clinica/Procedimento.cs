using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Procedimento : Retorno.Retorno
    {
        public int Codigo { get; set; }

        public string Atendimento { get; set; }

        public string Tipo { get; set; }
    }
}
