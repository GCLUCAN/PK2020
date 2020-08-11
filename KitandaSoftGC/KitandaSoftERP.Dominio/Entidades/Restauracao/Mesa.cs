using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class Mesa : Retorno.TabelaGeral
    {
        public string Localizacao { get; set; }
        public int Lugares { get; set; }
        public int CustomerID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Observacao { get; set; }
        public int BookingID { get; set; }

        public Mesa()
        {

        }

        public Mesa(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Mesa(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Mesa(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public Mesa(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public Mesa(int pCodigo, string pDescricao, string pSigla, int pEstado, string pLocalizacao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Localizacao = pLocalizacao;
        }

        public Mesa(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

       

    }
}
