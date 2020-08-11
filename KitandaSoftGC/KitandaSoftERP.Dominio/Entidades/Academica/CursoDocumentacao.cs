using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class CursoDocumentacao : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Curso { get; set; }
        public int Documento { get; set; }
        public int Quantidade { get; set; }
        public string Versao { get; set; }
        public string Documentacao { get; set; }
        public string DescricaoDocumento { get; set; }

    }
}
