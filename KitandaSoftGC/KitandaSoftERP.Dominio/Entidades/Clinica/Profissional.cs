using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Profissional : Pessoa
    {
        public int Especialidade { get; set; }
        public string CedulaProfissional { get; set; }
        public string AreaProfissional { get; set; }
        public string Registo { get; set; }
        public int ProfissionalID { get; set; }
        public int UserID { get; set; }
        public string Tratamento { get; set; }
    }
}
