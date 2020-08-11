using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Lavandaria
{
    public class RoupaDefeito : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Defeito_Codigo { get; set; }
        public RoupaDefeito()
        {

        }
        public RoupaDefeito(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public RoupaDefeito(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public RoupaDefeito(int pCodigo, int pDefeitoCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Defeito_Codigo = pDefeitoCodigo;
            Descricao = pDescricao;

        }
    }
}
