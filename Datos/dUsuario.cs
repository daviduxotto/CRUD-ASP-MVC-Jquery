using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class dUsuario : conexionBD
   {
      public List<eUsuario> getAllUser()
      {
         List<eUsuario> listUsuario = new List<eUsuario>();
         DataTable dtUsuario = new DataTable();
         try
         {
            open();
            SqlDataAdapter adaptador = new SqlDataAdapter("get_all_users", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.Fill(dtUsuario);
            foreach (DataRow fila in dtUsuario.Rows)
            {
               eUsuario usuario = new eUsuario();
               usuario.codUsuario = fila["cod_usuario"].ToString();
               usuario.clave = fila["clave"].ToString();
               usuario.nombre = fila["nombre"].ToString();
               usuario.apellidos = fila["apellidos"].ToString();
               usuario.telefono = fila["telefono"].ToString();
               usuario.edad = Convert.ToInt32(fila["edad"].ToString());
               listUsuario.Add(usuario);
            }

         }
         catch (Exception ex)
         {
            Console.WriteLine("Conexion a Base de datos: " + ex.Message);
         }
         finally
         {
            close();
         }

         return listUsuario;
      }
      public eUsuario getOneUser(eUsuario parUsuario)
      {
         eUsuario usuario = new eUsuario();
         DataTable dtUsuario = new DataTable();
         try
         {
            open();
            SqlDataAdapter adaptador = new SqlDataAdapter("get_one_user", conexion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter prmUsuario = adaptador.SelectCommand.Parameters.Add("parusuario", SqlDbType.VarChar, 15);
            prmUsuario.Value = parUsuario.codUsuario;
            adaptador.Fill(dtUsuario);
            foreach (DataRow fila in dtUsuario.Rows)
            {

               usuario.codUsuario = fila["cod_usuario"].ToString();
               usuario.clave = fila["clave"].ToString();
               usuario.nombre = fila["nombre"].ToString();
               usuario.apellidos = fila["apellidos"].ToString();
               usuario.telefono = fila["telefono"].ToString();
               usuario.edad = Convert.ToInt32(fila["edad"].ToString());
            }

         }
         catch (Exception ex)
         {
            Console.WriteLine("Conexion a Base de datos: " + ex.Message);
         }
         finally
         {
            close();
         }

         return usuario;
      }
   }
}
