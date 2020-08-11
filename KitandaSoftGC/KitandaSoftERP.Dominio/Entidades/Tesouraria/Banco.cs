using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Banco :  Entidades.Geral.Empresa
    {
        public Banco()
        {

        }

        public Banco(int pCodigo, string pDescricao, string pSigla)
        {
            this.Codigo = pCodigo;
            this.RazaoSocial = pDescricao;
            this.NomeFantasia = pSigla;

        }

        public Banco(int pCodigo, string pDescricao, string pSigla, string pDestino, int pStatus)
        {
            this.Codigo = pCodigo;
            this.RazaoSocial = pDescricao;
            this.NomeFantasia = pSigla;

        }
    }
}
