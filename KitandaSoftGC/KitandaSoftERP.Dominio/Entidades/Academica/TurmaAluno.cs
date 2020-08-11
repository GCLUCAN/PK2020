using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class TurmaAluno : Retorno.Retorno
    {
        public string Operacao { get; set; }
        public Turma Turma { get; set; }
        public Matricula Matricula { get; set; }

        public UnidadeCurricular Disciplina { get; set; }



        public TurmaAluno()
        {

        }

        public TurmaAluno(Turma pTurma, Matricula pMatricula)
        {
            this.Matricula = pMatricula;
            this.Turma = pTurma;

        }

        public TurmaAluno(Turma pTurma, Matricula pMatricula, string pOperacao, string pNivelEnsino)
        {
            this.Matricula = pMatricula;
            this.Turma = pTurma;
            Operacao = pOperacao;
            NivelEnsino = pNivelEnsino;


        }

        public TurmaAluno(Turma pTurma, Matricula pMatricula, UnidadeCurricular pDisciplina, int pAnoLectivo)
        {
            this.Matricula = pMatricula;
            this.Turma = pTurma;
            this.Disciplina = pDisciplina;
            this.AnoLectivo = pAnoLectivo;
        }
    }
}
