using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Prova : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Avaliacao { get; set; }
        public string Periodo { get; set; }
        public string Turma { get; set; }
        public string Disciplina { get; set; }
        public string Docente { get; set; }
        public DateTime DataProva { get; set; }
        

    }
}
