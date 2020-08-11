using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica.ExtraCurricular
{
    public class InscricaoTransporte
    {
        public int Codigo { get; set; }

        public string Utente { get; set; }

        public string Rota { get; set; }

        public string DataInscricao { get; set; }

        public string Situacao { get; set; }

        public decimal Preco { get; set; }

        public string NecessidadeFisica { get; set; }

        public string EquipamentoEspecial { get; set; }

        public string LocalRecolha { get; set; }
    }
}
