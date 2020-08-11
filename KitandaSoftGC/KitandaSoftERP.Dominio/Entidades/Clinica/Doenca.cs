using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Doenca : Retorno.TabelaGeral
    {
        public Doenca()
        {

        }

        public Doenca(int pCodigo)
        {
            this.Codigo = pCodigo;
        }


        public Doenca(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public Doenca(string pDescricao, string pSigla, int pIndice, int pNroRegistos)
        {
            this.Codigo = 0;
            this.Descricao = pDescricao;
            IndicePagina = pIndice;
            this.Sigla = pSigla;
            RegistosPorPagina = pNroRegistos;
        }

        public Doenca(int pCodigo, string pDescricao, string pSigla)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
        }

        public Doenca(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
        }

        public Doenca(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            this.MensagemErro = pMensagem;
            this.Sucesso = pSucesso;
        }
    }
}
