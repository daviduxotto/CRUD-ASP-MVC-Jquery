using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Datos
{
   public class conexionBD
   {
      public SqlConnection conexion = new SqlConnection();
      public bool open()
      {
         try
         {
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["cnx"].ToString();
            conexion.Open();
            return true;
         } catch (Exception ex)
         {
            Console.Write("error");
            return false;
         }
      }

      public bool close()
      {
         try
         {
            conexion.Close();
            return true;
         } catch (Exception ex)
         {
            return false;
         }
      }
    }
}
