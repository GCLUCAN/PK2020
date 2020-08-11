using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Acomodacao : Retorno.TabelaGeral
    {
        public string Extensao { get; set; }
        public int Tipo { get; set; }
        public string DescricaoTipo { get; set; }

        public Acomodacao()
        {

        }

        public Acomodacao(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Acomodacao(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public Acomodacao(int pCodigo, string pDescricao, string pSigla)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
        }

        public Acomodacao(string pDescricao, int pTipo)
        {
            this.Codigo = 0;
            this.Descricao = pDescricao;
            this.Tipo = pTipo;
            this.Sigla = "";
        }

        public Acomodacao(int pCodigo, string pDescricao, string pSigla, int pEstado, string pExtensao, int pTipo)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            this.Extensao = pExtensao;
            this.Tipo = pTipo;
        }

        public Acomodacao(int pCodigo, string pDescricao, string pSigla, int pEstado, string pExtensao, int pTipo, bool pSucesso, string pMensagem)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            this.MensagemErro = pMensagem;
            this.Sucesso = pSucesso;
            this.Extensao = pExtensao;
            this.Tipo = pTipo;
        }
    }
}
