using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.RecursosHumanos
{
    public class Beneficios : Retorno.TabelaGeral
    {
        public bool isCalculado { get; set; }

        public double Valor { get; set; }

        public string Categoria { get; set; }

        public Beneficios()
        {

        }

        public Beneficios(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Beneficios(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Beneficios(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public Beneficios(int pCodigo, string pDescricao, string pSigla, int pEstado, string pCategoria, bool pCalculado, double pValor)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            isCalculado = pCalculado;
            Valor = pValor;
            Categoria = pCategoria;
        }



        public Beneficios(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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
