using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Matricula
    {
        public int Codigo { get; set; }
        public int Turma { get; set; }
        public DateTime Data { get; set; }
        public int Estado { get; set; }
        public string DescricaoEstado { get; set; }
        public string Situacao { get; set; }               //Repetente Dependecia Adaptacao Novato Matriculado por Transferencia
        public Aluno Aluno { get; set; }
        public string NomeTurma { get; set; }
        public string DescricaoAno { get; set; }
        public string NomeAluno { get; set; }
        public string Inscricao { get; set; }
        public int Movimento { get; set; }
        public string DataIni { get; set; }
        public string DataTerm { get; set; }
        public int Classe { get; set; }
        public int Curso { get; set; }
        public int Ramo { get; set; }
        public string Turno { get; set; }
        public string SituacaoFinal { get; set; }           //Aprovado, Reprovado, Desistente, Reprovado Por Faltas
        public AnoCurricular Plano { get; set; }

        public DateTime TerminoMatricula { get; set; }

        public string Identificacao { get; set; }

        public string NomeDocumento { get; set; }



        public Matricula()
        {

        }

        public Matricula(int pMatricula)
        {
            this.Codigo = pMatricula;
        }

        public Matricula(string pInscricao)
        {
            this.Aluno = new Aluno(Convert.ToInt32(pInscricao));
        }

        public Matricula(int pMatricula, int pAno, int pMovimentacao, Aluno pAluno, int pClasse, int pEstado, string pInicio, string pTermino, int pTurma, string pSituacaoInicial, string pSituacaoFinal, string pTurno)
        {
            this.Codigo = pMatricula;
            this.AnoLectivo = pAno;
            this.Aluno = pAluno;
            this.Classe = pClasse;
            this.DataIni = pInicio;
            this.DataTerm = pTermino;
            this.Estado = pEstado;
            this.Situacao = pSituacaoInicial;
            this.SituacaoFinal = pSituacaoFinal;
            this.Turno = pTurno;
            this.Turma = pTurma;
            this.Curso = pMovimentacao;
        }

        public Matricula(int pMatricula, int pAno, DateTime pData, int pMovimentacao, Aluno pAluno, int pClasse, int pEstado, int pTurma, string pSituacaoInicial, string pSituacaoFinal)
        {
            this.Codigo = pMatricula;
            this.AnoLectivo = pAno;
            this.Data = pData;
            this.Aluno = pAluno;
            this.Classe = pClasse;
            this.Estado = pEstado;
            this.Situacao = pSituacaoInicial;
            this.Turma = pTurma;
            this.SituacaoFinal = pSituacaoFinal;
        }

        public Matricula(string pAluno, int pALectivo)
        {
            // TODO: Complete member initialization
            Aluno = new Aluno(Convert.ToInt32(pAluno));
            AnoLectivo = pALectivo;
        }

        public Matricula(Aluno pAluno)
        {
            // TODO: Complete member initialization
            Aluno = pAluno;
        }

        public Matricula(int pID, int pAno)
        {
            Codigo = pID;
            AnoLectivo = pAno;
            Aluno = new Aluno(pID);
        }



        public string Departamento { get; set; }

        public string Origem { get; set; }

        public string AnoCurricular { get; set; }

        public bool TemIsencaoPropina { get; set; }
        public bool TemMatricula { get; set; }
        public DateTime DataPagto { get; set; }
        public int FaturaMatricula { get; set; }
        public bool TemIsencaoMatricula { get; set; }
        public string TurmaTemporaria { get; set; }
    }
}
