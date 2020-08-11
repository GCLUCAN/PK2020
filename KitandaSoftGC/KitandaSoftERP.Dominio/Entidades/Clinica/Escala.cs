using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Escala : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Dia { get; set; }
        public string DescricaoDia { get; set; }
        public Profissiona Profissional { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        public Escala()
        {

        }

        public Escala(int pDia, Profissiona pMedico, DateTime pInicio, DateTime pTermino)
        {
            this.Dia = pDia;
            this.Profissional = pMedico;
            this.Inicio = pInicio;
            this.Termino = pTermino;
        }
    }
}
