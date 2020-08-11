using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Lavandaria
{
    public class Vestuario : Retorno.TabelaGeral
    {
        public int GeneroID { get; set; }
        public int NroItems { get; set; }
        public string Unidade { get; set; }
        public string ImagePath { get; set; }
        public string ImageBlob { get; set; }



        public Vestuario()
        {

        }

        public Vestuario(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Vestuario(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Vestuario(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;

        }

        public Vestuario(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public Vestuario(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Sucesso = pSucesso;
            MensagemErro = pMensagem;
        }

    }
}
