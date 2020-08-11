using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Pessoa : Entidade
    {
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Habilitacoes { get; set; }
        public int PaiID { get; set; }
        public int MaeID { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int GrupoSanguineo { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Idade { get; set; }


    }
}
