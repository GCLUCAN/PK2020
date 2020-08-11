using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class FormacaoCurso : Retorno.TabelaGeral
    {
        public Tuple<int, string> GrauAcademico { get; set; }
        public Tuple<int, bool> Curricular { get; set; }
        public Tuple<int, bool> CurtaDuracao { get; set; }

        public FormacaoCurso()
        {

        }

        public FormacaoCurso(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public FormacaoCurso(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            GrauAcademico = new Tuple<int, string>(-1, "");
        }

        public FormacaoCurso(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public FormacaoCurso(int pCodigo, string pDescricao, string pSigla, int pEstado, Tuple<int, string> pGrau, Tuple<int, bool> pFormacaoCurricular, Tuple<int, bool> pDuracao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            GrauAcademico = pGrau;
            Curricular = pFormacaoCurricular;
            CurtaDuracao = pDuracao;
        }

        public FormacaoCurso(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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
