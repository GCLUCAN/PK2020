using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Departamento: Retorno.TabelaGeral
    {
        private string _seccao = "";
        public string Seccao
        {
            get { return _seccao; }
            set { _seccao = value; }
        }
        private string _classificacao = "";
        public string Classificacao
        {
            get { return _classificacao; }
            set { _classificacao = value; }
        }
        public Departamento()
        {
        }
        public Departamento(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public Departamento(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }
        public Departamento(int pCodigo, string pDescricao, string pSigla, string pSeccao, string pClassificacao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Seccao = pSeccao;
            Classificacao = pClassificacao;
        }
        public Departamento(int pCodigo, string pDescricao, string pSigla, int pEstado, string pSeccao, string pClassificacao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Seccao = pSeccao;
            Classificacao = pClassificacao;
        }

        public Departamento(int pCodigo, string pDescricao, string pSigla, int pEstado, string pSeccao, string pClassificacao, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Seccao = pSeccao;
            Classificacao = pClassificacao;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

        public string NomePai { get; set; }

    }
}
