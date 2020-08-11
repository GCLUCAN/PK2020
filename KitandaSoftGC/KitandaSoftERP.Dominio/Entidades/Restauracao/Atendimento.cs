using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class Atendimento : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Funcionario { get; set; }
        public string Cliente { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int Destino { get; set; }
        public decimal Conta { get; set; }
        public int Fatura { get; set; }
        public string Mesa { get; set; }
        public string StatusEncomenda { get; set; }
        public string LocalEntrega { get; set; }
        public string Contacto { get; set; }
        public string Entregador { get; set; }
        public string Observacao { get; set; }
        public string TipoEncomenda { get; set; }
        public DateTime DataEntrega { get; set; }
        public object PedidoID { get; set; }

        public Atendimento()
        {
            Codigo = -1;
            Funcionario = string.Empty;
            Cliente = string.Empty;
            Inicio = DateTime.MinValue;
            Termino = DateTime.MinValue;
            Filial = string.Empty;
            Destino = int.MinValue;

        }

        public Atendimento(int pCodigo)
        {
            Codigo = pCodigo;
            Funcionario = string.Empty;
            Cliente = string.Empty;
            Inicio = DateTime.MinValue;
            Termino = DateTime.MinValue;
            Filial = string.Empty;
            Destino = int.MinValue;
        }

        public Atendimento(int pCodigo, string pAtendente, string pCliente, DateTime pInicio, DateTime pTermino, string pFilial, int pDestino)
        {
            Codigo = pCodigo;
            Funcionario = pAtendente;
            Cliente = pCliente;
            Inicio = pInicio;
            Termino = pTermino;
            Filial = pFilial;
            Destino = pDestino;
        }

    }
}
