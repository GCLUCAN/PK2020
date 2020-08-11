using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Recibo : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Referencia { get; set; }
        public int Numeracao { get; set; }
        public int Documento { get; set; }
        public decimal ValorDocumento { get; set; }
        public string CustomerName { get; set; }
        public string CustomerVAT { get; set; }
        public decimal ValorPago { get; set; }
        public decimal DescontoComercial { get; set; }
        public short DocumentStatus { get; set; }
        public string Moeda { get; set; }
        public decimal Cambio { get; set; }
        public int Serie { get; set; }
        public DateTime Emissao { get; set; }
        public string Observacoes { get; set; }


        public List<ReciboDocumentosDTO> DocumentosLiquidados { get; set; }

        public DateTime EmissaoIni { get; set; }

        public DateTime EmissaoTerm { get; set; }

        public string MotivoAnulacao { get; set; }

        public List<Fatura> FaturasLiquidadas { get; set; }
        public int DocFromType { get; set; }
        public int DocFromNumber { get; set; }
        public int SessionID { get; set; }
      
    }

    public class ReciboDocumentosDTO : Fatura
    {
        public int Ordem { get; set; }
        public int ReciboID { get; set; }
        public int DocumentID { get; set; }
    }
}

