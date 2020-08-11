using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class CategoriaItemCobranca : Retorno.Retorno
    {

        public int Codigo { get; set; }
        public string Modo { get; set; }


        public CategoriaItemCobranca()
        {

        }

        public CategoriaItemCobranca(int pCodigo, string pDescricao, string pModo)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Modo = pModo;
        }

      

        public enum Categoria
        {
            Outra,
            Produto,
            Servico,
            Mensalidade,
            TaxaMatricula,
            TaxaConfirmacao,
            Documento,
            TaxaExame,
            TaxaAnulacao,
            TaxaInscricao,
            TaxaEstagio
        }

    }
}
