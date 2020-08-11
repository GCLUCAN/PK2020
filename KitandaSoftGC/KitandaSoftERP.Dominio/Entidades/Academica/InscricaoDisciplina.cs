using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class InscricaoDisciplina : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Aluno { get; set; }
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public string Regime { get; set; }
        public string Exame { get; set; }
    }
}
