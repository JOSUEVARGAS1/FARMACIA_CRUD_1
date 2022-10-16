using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_Sesion_Inicio
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
 
        public DataTable D_Login(CapaEntidad . E_Sesion_Inicio obje)
        {
            SqlCommand cmd = new SqlCommand("sp_login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.Usuario);
            cmd.Parameters.AddWithValue("@contraseña", obje.Contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
