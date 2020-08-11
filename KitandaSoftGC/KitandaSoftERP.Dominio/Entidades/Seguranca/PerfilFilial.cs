using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class PerfilFilial: Retorno.Retorno
    {
        public Filial Sucursal { get; set; }
        private Perfil _perfil;

        public Perfil Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public PerfilFilial()
        {

        }

        public PerfilFilial(int pPerifl, int pSucursal)
        {
            Perfil = new Perfil(pPerifl);
            Sucursal = new Filial(pSucursal);
        }
    }
}
