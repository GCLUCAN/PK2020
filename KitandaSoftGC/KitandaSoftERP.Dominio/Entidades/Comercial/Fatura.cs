﻿using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class Fatura : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Armazem { get; set; }
        public int Documento { get; set; }
        public int? Serie { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Validade { get; set; }
        public int Moeda { get; set; }
        public decimal Cambio { get; set; }
        public int? PrazoPagto { get; set; }
        public int? Expedicao { get; set; }
        public decimal Desconto { get; set; }
        public int StatusDocumento { get; set; }
        public string Referencia { get; set; }
        public int? Numeracao { get; set; }
        public decimal TotalIliquido { get; set; }
        public decimal TotalDescontos { get; set; }
        public decimal TotalLiquido { get; set; }
        public decimal TotalImpostos { get; set; }
        public decimal ValorTotal { get; set; }
        public string NomeEntidade { get; set; }
        public string DescricaoDocumento { get; set; }
        public string StatusPagamento { get; set; }
        public string Observacoes { get; set; }
        public int DocumentoOrigem { get; set; }
        public string NumeroDocOrigem { get; set; }
        public decimal Saldo { get; set; }
        public decimal ValorIncidencia { get; set; }
        public List<ItemFaturacao> ListaArtigos { get; set; }
        public string NotasComerciais { get; set; }

        public Fatura()
        {
            ListaArtigos = new List<ItemFaturacao>();
        }

        public Fatura(int pID)
        {
            Codigo = pID;
        }
        public decimal ValorPago { get; set; }

        public decimal Troco { get; set; }

        public decimal ValorFaturado { get; set; }

        public decimal Lucro { get; set; }

        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

        public bool IsAtendimento { get; set; }

        public string NIF { get; set; }

        public decimal DescontoFinanceiro { get; set; }

        public decimal DescontoCliente { get; set; }

        public DateTime DataCarga { get; set; }

        public string EnderecoCarga { get; set; }

        public string LocalCarga { get; set; }

        public DateTime DataDescarga { get; set; }

        public string EnderecoDescarga { get; set; }

        public string LocalDescarga { get; set; }

        public string NotasInternas { get; set; }

        public string MotivoAnulacao { get; set; }

        public bool Activo { get; set; }

        public DateTime EmissaoIni { get; set; }

        public DateTime EmissaoTerm { get; set; }

        public DateTime ValidadeIni { get; set; }

        public DateTime ValidadeTerm { get; set; }

        public int DiasAtrasado { get; set; }

        public int Parcela { get; set; }

        public int VendedorID { get; set; }

        public decimal Comissao { get; set; }

        public string DeliveryMan { get; set; }

        public string DeliveryManContact { get; set; }

        public string Destinatario { get; set; }

        public string ContactoDestinatario { get; set; }

        public List<Fatura> Parcelas { get; set; }

        public int ParcelaID { get; set; }

        public int EntityBillingID { get; set; }

        public string EntityBillingName { get; set; }
        public decimal ValorRetencao { get; set; }
        public string ReceptorCarga { get; set; }
        public string DocumentBarcode { get; set; }
        public object PrevisaoEntrega { get; set; }
        public object DataLiquidacao { get; set; }
        public string ResponsavelCarregamento { get; set; }
        public string Matricula { get; set; }
        public int FiscalYear { get; set; }
        public string Hash { get; set; }
        public string PriorHash { get; set; }
        public string HasFields { get; set; }
        public string FooterDocumentNotes { get; set; }
        public string HeaderNotes { get; set; }
        public string TipoDocumento { get; set; }
        public int TotalItems { get; set; }
        public int TotalDelivered { get; set; }
        public int TotalReady { get; set; }
        public int UnderProcess { get; set; }
        public decimal TotalValorUtente { get; set; }
        public decimal TotalValorEntidade { get; set; }
        public int AcordoID { get; set; }
        public string AcordoReferenciaAprovacao { get; set; }
        public string Apolice { get; set; }
        public string NumeroBeneficiario { get; set; }
        public DateTime DataAprovacao { get; set; }
        public string HostName { get; set; }
        public Morada CustomerAddress { get; set; }
    }
}
