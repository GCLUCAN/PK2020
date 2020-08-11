using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Prioridade : Retorno.TabelaGeral
    {
        public int TempoEspera { get; set; }
        public Prioridade()
        {

        }

        public Prioridade(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Prioridade(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public Prioridade(int pCodigo, string pDescricao, string pSigla, int pEspera)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            TempoEspera = pEspera;
        }

        public Prioridade(int pCodigo, string pDescricao, string pSigla, int pEspera, int pEstado)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            TempoEspera = pEspera;
        }

        public Prioridade(int pCodigo, string pDescricao, string pSigla, int pEspera, int pEstado, bool pSucesso, string pMensagem)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            this.MensagemErro = pMensagem;
            this.Sucesso = pSucesso;
            TempoEspera = pEspera;
        }
    }
}
