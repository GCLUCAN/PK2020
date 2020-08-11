using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Serie : Retorno.TabelaGeral
    {
        public int Ano { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int Documento { get; set; }
        public int Numeracao { get; set; }
        public int Copias { get; set; }
        public bool AllowFreeDocument { get; set; }
        public bool Activo { get; set; }
       

        public Serie()
        {

        }

        public Serie(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Serie(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Serie(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public Serie(int pCodigo, string pDescricao, string pSigla, int pEstado, string pFilial, int pAno, int pDocumento)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            CompanyID = pFilial;
            Ano = pAno;
            Documento = pDocumento;
        }

        public Serie(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

        public Serie(int pDocumentID, int pAno, string pDescricao, string pFilial)
        {
            Documento = pDocumentID;
            Descricao = pDescricao;
            Ano = pAno;
            CompanyID = pFilial;
        }

    }
}
