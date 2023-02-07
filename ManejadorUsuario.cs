using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntrega
{
    internal class ManejadorUsuario
    {
        public static string cadenaConexion = "Data Source=ZUREO-NF\\SQLEXPRESS01;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection conn=new SqlConnection(cadenaConexion))
            {
                conn.Open();    
                SqlCommand comando = new SqlCommand("Select * from Usuario where id=@id", conn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    {

                        usuario.Id = (int)reader.GetInt64(0); //reader.GetInt64(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Apellido = reader.GetString(2);
                        usuario.NombreUsuario = reader.GetString(3);
                        usuario.Contrasena = reader.GetString(4);
                        usuario.Mail = reader.GetString(5);



                    }
                }
                
                return usuario;
            }
            
        }
    }
}
