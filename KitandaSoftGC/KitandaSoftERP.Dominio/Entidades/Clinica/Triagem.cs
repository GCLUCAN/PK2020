using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Triagem
    {
       
        public int Codigo { get; set; }
        public int Atendimento { get; set; }
        public string Pulso { get; set; }
        public string Tensao { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Temperatura { get; set; }
        public string Saturacao { get; set; }
        public string Respiracao { get; set; }
        public string GrupoSanguineo { get; set; }
        public string FrequenciaCardiaca { get; set; }
        public string PerimetroCefalico { get; set; }
        public string Glicemia { get; set; }
        public string Colheita { get; set; }
        public DateTime Data { get; set; }
        


        public Triagem(int pAtendimento)
        {
            Atendimento = pAtendimento;
        }

        public Triagem()
        {
            // TODO: Complete member initialization
        }

        
    }
}
