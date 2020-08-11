using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Pauta : Retorno.Retorno
    {
        public int Codigo { get; set; }

        public int Periodo { get; set; }

        public string DsPeriodo { get; set; }
        public int Turma { get; set; }

        public string DsTurma { get; set; }

        public int Disciplina { get; set; }

        public string DsDisciplina { get; set; }

        public int Prova { get; set; }

        public DateTime DataProva { get; set; }

        public string DsAnoLectivo { get; set; }

        public string PauDsAvaliacao { get; set; }

        public int Aluno { get; set; }

        public string InscricaoAluno { get; set; }

        public string NomeAluno { get; set; }

        public decimal PrimeiraNota { get; set; }

        public decimal SegundaNota { get; set; }

        public decimal TerceiraNota { get; set; }

        public decimal QuartaNota { get; set; }

        public decimal Frequencia { get; set; }

        public decimal PauMedia { get; set; }

        public decimal PauExame { get; set; }

        public decimal PauRecurso { get; set; }

        public decimal PauExameOral { get; set; }

        public decimal PauRecursoOral { get; set; }

        public decimal PauExaEspecial { get; set; }

        public decimal PauExaEspecialOral { get; set; }

        public decimal PauNotaFinal { get; set; }

        public string PauNotaExtenso { get; set; }

        public decimal PauMelhoria { get; set; }

        public string PauSituacao { get; set; }

        public string PauCurso { get; set; }

        public string PauDsRamo { get; set; }

        public string PauClasse { get; set; }

        public string Nivel { get; set; }

        public string Docente { get; set; }

        public string PauPeriodo { get; set; }

        public bool isValidada { get; set; }

        public Pauta()
        {

        }

        public Pauta(int pTurma, int pDisciplina)
        {
            Turma = pTurma;
            Disciplina = pDisciplina;
            AnoLectivo = -1;
            Aluno = -1;
            NomeAluno = "";
            Prova = -1;
        }

        public Pauta(int pAluno)
        {
            Turma = -1;
            Disciplina = -1;
            AnoLectivo = -1;
            Aluno = pAluno;
            NomeAluno = "";
            Prova = -1;
        }

        public Pauta(string pTurma, string pDisciplina, string pAnoLectivo, int pAluno, string pNomeAluno, int pProva)
        {
            // TODO: Complete member initialization
            Turma = Convert.ToInt32(pTurma);
            Disciplina = Convert.ToInt32(pDisciplina);
            AnoLectivo = Convert.ToInt32(pAnoLectivo);
            Aluno = pAluno;
            NomeAluno = pNomeAluno;
            Prova = pProva;

        }

        public string UserValidador { get; set; }

        public int Ano { get; set; }

        public decimal NotaAvaliacaoContinua { get; set; }
    }
}
