using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class RelatorioAluno : Retorno.Retorno
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Data { get; set; }

        public string Turma { get; set; }

        public string Ramo { get; set; }

        public string Curso { get; set; }

        public string Classe { get; set; }

        public int Estado { get; set; }

        public int CodigoTurma { get; set; }

        public string Inscricao { get; set; }

        public string FiltroStatus { get; set; }

        public string Turno { get; set; }

        public string Sala { get; set; }

        

        public decimal Mensalidade { get; set; }

        public decimal Multa { get; set; }

        public decimal ValorGlobal { get; set; }

        public string Periodo { get; set; }

        public RelatorioAluno()
        {

        }

        public RelatorioAluno(string pCodigo, string pCurso, string pClasse, string pTurma)
        {
            this.Codigo = Convert.ToInt32(pCodigo);
            this.Curso = pCurso;
            this.Classe = pClasse;
            this.Turma = pTurma;
        }


        public RelatorioAluno(string pCodigo, string pNome, string pData, string pTurma, string pClasse, string pRamo, string pCurso, int pAno, int pEstado, int pCodigoTurma)
        {
            if (pCodigo.Contains('/'))
            {
                string[] codigo = pCodigo.Split('/');
                pCodigo = codigo[0];
            }
            this.Codigo = Convert.ToInt32(pCodigo);
            this.Curso = pCurso;
            this.Data = pData;
            this.Nome = pNome;
            this.Ramo = pRamo;
            this.Turma = pTurma;
            this.AnoLectivo = pAno;
            this.Classe = pClasse;
            this.Estado = pEstado;
            this.CodigoTurma = pCodigoTurma;

        }

        public object Relatorio { get; set; }

        public decimal Janeiro { get; set; }
        public decimal Fevereiro { get; set; }
        public decimal Março { get; set; }
        public decimal Abril { get; set; }
        public decimal Maio { get; set; }
        public decimal Junho { get; set; }
        public decimal Julho { get; set; }
        public decimal Agosto { get; set; }
        public decimal Setembro { get; set; }
        public decimal Outubro { get; set; }
        public decimal Novembro { get; set; }
        public decimal Dezembro { get; set; }

        public string Inscritos { get; set; }

        public string Masculino { get; set; }

        public string Feminino { get; set; }

        public string Matriculados { get; set; }

        public string Matricula { get; set; }

        public string Aluno { get; set; }

        public string Processo { get; set; }

        public string Sexo { get; set; }

        public string TotalGeral { get; set; }

        public int AnoCurricular { get; set; }

        public string Desistentes { get; set; }

        public string NovasInscricoes { get; set; }
        public string ItemDesignation { get; set; }
        public int ItemCategory { get; set; }
        public int ItemID { get; set; }
        public string MontlyCategoryItem { get; set; }
    }
}
