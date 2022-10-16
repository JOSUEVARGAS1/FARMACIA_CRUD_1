using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Sesion_Inicio
    {
        CapaDatos.D_Sesion_Inicio objd = new CapaDatos.D_Sesion_Inicio();

        public DataTable N_Login(CapaEntidad.E_Sesion_Inicio obje)

        {
            return objd.D_Login(obje);
        }


    }
}
