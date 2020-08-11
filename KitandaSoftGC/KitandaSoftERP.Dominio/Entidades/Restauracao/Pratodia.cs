using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class Pratodia: Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Artigo { get; set; }
        public string DescricaoPrato { get; set; }
        public int Familia { get; set; }
        public int Segunda { get; set; }
        public int Terca { get; set; }

        public int Quarta { get; set; }

        public int Quinta { get; set; }

        public int Sexta { get; set; }

        public int Sabado { get; set; }

        public int Domingo { get; set; }

        public Pratodia()
        {
            Codigo = 0;
            Artigo = 0;
            Segunda = 0;
        }

        public Pratodia(int pCodigo, int pArtigo, int pDia)
        {
            Codigo = pCodigo;
            Artigo = pArtigo;
            Segunda = pDia;
        }


      
    }
}
