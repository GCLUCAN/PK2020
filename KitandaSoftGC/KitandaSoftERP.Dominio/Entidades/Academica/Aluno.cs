using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Aluno : Geral.Pessoa
    {
        public string Inscricao { get; set; }
        public int Convenio { get; set; }
        public string DescricaoConvenio { get; set; }
        public int Estado { get; set; }
        public string DescricaoEstado { get; set; }
        public DateTime DataInscricao { get; set; }
        public DateTime InscricaoIni { get; set; }
        public DateTime InscricaoTerm { get; set; }
        public string Curso { get; set; }
        public int Classe { get; set; }
        public int Turma { get; set; }
        public int StatusMatricula { get; set; }
        public string SituacaoInicial { get; set; }
        public string SituacaoFinal { get; set; }
        public string Encarregado { get; set; }
        public string TelEncarregado { get; set; }
        public string EncEmail { get; set; }
        public string EncTelAlternativo { get; set; }
        public string Parentesco { get; set; }
        public int Matricula { get; set; }
        public string Turno { get; set; }


        public Aluno()
        {

        }

        public Aluno(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Aluno(int pCodigo, int pAnoLectivo)
        {
            // TODO: Complete member initialization
            Codigo = pCodigo;
            AnoLectivo = pAnoLectivo;
        }


        public Aluno(int pCodigo, string pFiltro)
        {
            Codigo = pCodigo;
            DescricaoConvenio = pFiltro;
        }

        public Aluno(string pNome)
        {
            NomeCompleto = pNome;
        }

        public Aluno(string pCodigo, string pNome)
        {
            Codigo = int.Parse(pCodigo);
            NomeCompleto = pNome;
        }
        public Aluno(int pCodigo, int pAnoLectivo, string pFiltro)
        {
            Codigo = pCodigo;
            AnoLectivo = pAnoLectivo;
            DescricaoConvenio = pFiltro;
        }


        public Aluno(int pCodigo, decimal pSaldo)
        {
            this.Codigo = pCodigo;
            SaldoCorrente = pSaldo;
        }

        public Aluno(string pCodigo, string pInscricao, string pNome)
        {
            Codigo = int.Parse(pCodigo);
            NomeCompleto = pNome;
            Inscricao = pInscricao;
        }

        public decimal SaldoCorrente { get; set; }

        public int Total { get; set; }

        public int Indice { get; set; }

        public string Disciplina { get; set; }

        public string SituacaoAcademica { get; set; }

        public string CursoID { get; set; }

        public string Naturalidade { get; set; }

        public string OpcaoLingua { get; set; }

        public string EscolaProveniencia { get; set; }

        public string SaidaProveniencia { get; set; }

        public string SituacaoProveniencia { get; set; }

        public string CursoProveniencia { get; set; }

        public string ClasseProveniencia { get; set; }

        public string NroExterno { get; set; }

        public string SiglaTurma { get; set; }
        public bool AcessoPortal { get; set; }
        public bool IsExterno { get; set; }

        public new Idade Idade { get; set; }
        public string NomeProvinciaMorada { get; set; }
    }
}
