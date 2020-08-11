using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Disciplina : Retorno.TabelaGeral
    {
        public Disciplina()
        {

        }

        public Disciplina(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Disciplina(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao ?? string.Empty;
        }

        public Disciplina(int pCodigo, string pDescricao, string pSigla)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
        }

        public Disciplina(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
        }

        public Disciplina(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            this.MensagemErro = pMensagem;
            this.Sucesso = pSucesso;
        }

        public Disciplina(string pPeriodo, string pAnoLectivo)
        {
            // TODO: Complete member initialization
            this.Periodo = Convert.ToInt32(pPeriodo);
            this.AnoLectivo = Convert.ToInt32(pAnoLectivo);
        }


        public int Classe { get; set; }

        public int Periodo { get; set; }

        public int Plano { get; set; }
    }
}
