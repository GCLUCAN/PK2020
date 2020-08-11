using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class GrauAcademico : Retorno.TabelaGeral
    {
        public GrauAcademico()
        {

        }
        public GrauAcademico(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public GrauAcademico(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public GrauAcademico(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public GrauAcademico(int pCodigo, string pDescricao, string pSigla, int pEstado, string pNivelEnsino)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            NivelEnsino = pNivelEnsino;
        }

        public GrauAcademico(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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
