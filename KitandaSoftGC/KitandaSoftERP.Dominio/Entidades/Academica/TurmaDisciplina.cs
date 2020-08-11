﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class TurmaDisciplina : Retorno.Retorno
    {

        public int TurmaID { get; set; }
        public int DisciplinaID { get; set; }
        public int DocenteID { get; set; }
        public Turma Turma { get; set; }
        public Disciplina Disciplina { get; set; }
        public Docente Docente { get; set; }
        public int MatriculadosMasculinos { get; set; }
        public int MatriculadosFemininos { get; set; }
        public int TotalMatriculados { get; set; }
        public int DesistentesMasculinos { get; set; }
        public int DesistentesFemininos { get; set; }
        public int TotalDesistentes { get; set; }
        public int AvaliadosMasculinos { get; set; }
        public int AvaliadosFemininos { get; set; }
        public int TotalAvaliados { get; set; }
        public int PositivasMasculinos { get; set; }
        public int PositivasFemininos { get; set; }
        public int TotalPositivas { get; set; }
        public int NegativasMasculinos { get; set; }
        public int NegativasFemininos { get; set; }
        public int TotalNegativas { get; set; }
        public decimal PercentagemPositivasMasculinos { get; set; }
        public decimal PercentagemPositivasFemeninos { get; set; }
        public decimal TotalPercentagemPositivas { get; set; }
        public string AreaFormacao { get; set; }
        public string Curso { get; set; }
        public string AnoCurricular { get; set; }
        public decimal CargaHoraria { get; set; }
       
        public int PercentagemNegativas { get; set; }

        public TurmaDisciplina()
        {

        }

        public TurmaDisciplina(Turma pTurma, Disciplina pDisciplina, Docente pDocente)
        {
            Docente = pDocente;
            Turma = pTurma;
            Disciplina = pDisciplina;

        }

        public TurmaDisciplina(int pTurma, int pDisciplina, int pDocente)
        {
            DocenteID = pDocente;
            TurmaID = pTurma;
            DisciplinaID = pDisciplina;

        }
    }
}
