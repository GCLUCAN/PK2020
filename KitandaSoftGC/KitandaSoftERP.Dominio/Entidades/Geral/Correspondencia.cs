using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Correspondencia
    {
        public int Codigo { get; set; }
        public string ReferenciaInterna { get; set; }
        public string Referencia { get; set; }
        public int RemetenteID { get; set; }
        public int DestinatarioID { get; set; }
        public int CategoryID { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataRegisto { get; set; }
        public string Recepcionista { get; set; }
        public string Assunto { get; set; }
        public string MyProperty { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; }
        public int DepartamentoID { get; set; }
        public string Barcode { get; set; }
        public string PathFile { get; set; }
        public string ImageByte { get; set; }
    }
}
