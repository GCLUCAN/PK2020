using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Formulario
    {
      
        public int FormCodigo { get; set; }
        public Modulo FormModulo { get; set; }
        public string FormTitulo { get; set; }
        public string FormNome { get; set; }
        public string FormLink { get; set; }
        public int FormTAG { get; set; }
        public int FormIndice { get; set; }
        public string FormImagem { get; set; }


        public Formulario()
        {

        }

        public Formulario(int pCodigo, string pTitulo, string pLink)
        {
            FormCodigo = pCodigo;
            FormTitulo = pTitulo;
            FormLink = pLink;
        }
    }
}
