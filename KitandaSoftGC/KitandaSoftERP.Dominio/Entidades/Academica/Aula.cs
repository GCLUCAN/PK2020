using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Aula : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int TurmaID { get; set; }
        public int DisciplinaID { get; set; }
        public int DocenteID { get; set; }
        public DateTime Data { get; set; }
        public string Sumario { get; set; }
        public string Tipo { get; set; }
        public string TarefaExtra { get; set; }
        public int PeriodoID { get; set; }
        public int AvaliacaoID { get; set; }
        public int DiaSemana { get; set; }
        public string Hora { get; set; }
        public string Observacoes { get; set; }
        public string Sala { get; set; }
        public int NroAula { get; set; }
        public UnidadeCurricular Disciplina { get; set; }
        public Turma Turma { get; set; }
        public Docente Docente { get; set; }
        

        public Aula()
        {

        }

        public Aula(UnidadeCurricular pUnidade, Turma pTurma)
        {
            Disciplina = pUnidade;
            Turma = pTurma;
        }
    }
}
