using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class DocumentosRelacionados
    {
        public int MainDocumentID { get; set; }
        public int MainDocumnetTypeID { get; set; }
        public int RelatedDocumentID { get; set; }
        public int RelatedDocumentTypeID { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ValorDescontos { get; set; }
        public decimal ValorImpostos { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal ValorPendente { get; set; }
    }
}
