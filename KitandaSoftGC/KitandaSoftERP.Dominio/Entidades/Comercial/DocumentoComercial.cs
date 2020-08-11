using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class DocumentoComercial : Retorno.TabelaGeral
    {
        public string ComentarioRodape { get; set; }
        public string Tipo { get; set; }
        public string Stock { get; set; }
        public string ContaCorrente { get; set; }
        public string Caixa { get; set; }
        public string Formato { get; set; }
        public string Categoria { get; set; }
        public int AllowInsert { get; set; }
        public int AllowDelete { get; set; }
        public int AllowSelect { get; set; }
        public int AllowUpdate { get; set; }
        public DocumentoComercial()
        {

        }

        public DocumentoComercial(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public DocumentoComercial(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public DocumentoComercial(int pCodigo, string pDescricao, string pSigla, string pCategoria)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Categoria = pCategoria;
        }

        public DocumentoComercial(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public DocumentoComercial(int pCodigo, string pDescricao, string pSigla, int pEstado, string pStock, string pCC, string pCaixa, string pFormato)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Stock = pStock;
            ContaCorrente = pCC;
            Caixa = pCaixa;
            Formato = pFormato;
        }

        public Nullable<int> ParentID { get; set; }

        public string Link { get; set; }

        public string Template { get; set; }
    }
}
