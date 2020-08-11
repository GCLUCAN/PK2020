using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class PedidoCozinha
    {
        public int Codigo { get; set; }
        public int Ordem { get; set; }
        public int Numeracao { get; set; }
        public int Atendimento { get; set; }

        public string Referencia { get; set; }
        public DateTime Data { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Responsavel { get; set; }
        public string Obs { get; set; }
        public object Artigo { get; set; }
        public object PedidoDia { get; set; }
    }
}
