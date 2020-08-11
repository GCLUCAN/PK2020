using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class UnidadeCurricular : Retorno.Retorno
    {
        public UnidadeCurricular(int codigo, AnoCurricular plano, PeriodoLectivo periodo, Disciplina disciplina,
       string tipo, string classificacao, int cargaHoraria, string conteudo, int status)
        {

            CargaHoraria = cargaHoraria;
            Classificacao = classificacao;
            Codigo = codigo;
            Conteudo = conteudo;
            Disciplina = disciplina;
            PeriodoLectivo = periodo;
            PlanoCurricular = plano;
            Tipo = tipo;
            Status = status;

        }

        public UnidadeCurricular()
        {

        }

        public UnidadeCurricular(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public UnidadeCurricular(int pPlano, int pStatus)
        {
            this.PlanoCurricular = new AnoCurricular(pPlano);
            this.Status = pStatus;
        }

        public UnidadeCurricular(string pDisciplina)
        {
            this.NomeDisciplina = pDisciplina;
        }

        public UnidadeCurricular(int pCodigo, string pDisciplina)
        {
            this.Codigo = pCodigo;
            this.NomeDisciplina = pDisciplina;
        }
        public int Codigo { get; set; }
        public AnoCurricular PlanoCurricular { get; set; }
        public PeriodoLectivo PeriodoLectivo { get; set; }
        public Disciplina Disciplina { get; set; }
        public string Tipo { get; set; }
        public string Classificacao { get; set; }
        public int CargaHoraria { get; set; }
        public string Conteudo { get; set; }
        public string NomeDisciplina { get; set; }
        public string Turma { get; set; }

        public string Creditos { get; set; }
        public int Ordem { get; set; }
        public string DocumentDesignation { get; set; }
        public bool AllowPG { get; set; }
        public bool AllowEX { get; set; }
        public bool AllowRC { get; set; }
        public int CargaTeorica { get; set; }
        public int CargaTeoriaPratica { get; set; }
        public int CargaHorariaPeriodo { get; set; }
        public int PraticaLaboratorial { get; set; }
        public int PrecedenteID { get; set; }
        public string Nivel { get; set; }
    }
}
