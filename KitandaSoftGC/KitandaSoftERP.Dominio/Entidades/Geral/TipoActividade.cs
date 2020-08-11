using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class TipoActividade : Retorno.TabelaGeral
    {
        public TipoActividade()
        {

        }

        public TipoActividade(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public TipoActividade(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public TipoActividade(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public TipoActividade(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public TipoActividade(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

        enum TaskType
        {
            Telefonema,
            ApresentacaoProposta,
            Compromisso,
            EnvioCarta,
            EnvioEmail,
            EnvioProposta,
            Reuniao,
            Tarefa,
            Cobranca,
            ActoMedico,
            OrdemServiço
        }
    }
}
