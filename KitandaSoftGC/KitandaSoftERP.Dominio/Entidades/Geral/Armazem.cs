using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Armazem : Retorno.TabelaGeral
    {
        public bool AlertaStockMinimo { get; set; }
        public bool PermiteStockNegativo { get; set; }
        public bool AlertaStockNegativo { get; set; }
        public string Tipo { get; set; }
        public int AllowInsert { get; set; }
        public int AllowUpdate { get; set; }
        public int AllowDelete { get; set; }
        public int AllowPrint { get; set; }
        public int AllowSelect { get; set; }
        public int UtilizadoID { get; set; }
        public int PerfilID { get; set; }
        public bool EnablePOS { get; set; }
        public bool AllowOutcome { get; set; }
        public bool AllowIncome { get; set; }
        public double Quantidade { get; set; }

        public Armazem()
        {

        }

        public Armazem(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public Armazem(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }
        public Armazem(int pCodigo, string pDescricao, double pQuantidade)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Quantidade = pQuantidade;
        }
        public Armazem(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }
        public Armazem(int pCodigo, string pDescricao, string pSigla, int pEstado, string pFilial)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Filial = pFilial;
        }

        public Armazem(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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

