using System.Runtime.Intrinsics.X86;
using System;

namespace PrimerEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Traer Usuario(recibe un int) ok 
            //Usuario usuario = ManejadorUsuario.ObtenerUsuario(1);
            //Console.WriteLine(usuario.Nombre);

            ////Traer Productos(recibe un id de usuario y, devuelve una lista con todos los productos cargado por ese usuario)
            //List<Producto> productos = ManejadorProductos.ObtenerProductos(1);//1 si trae 
            //foreach (var item in productos)
            //{
            //    Console.WriteLine(item.Descripciones);
            //}

            //Traer ProductosVendidos(recibe el id del usuario y devuelve una lista de productos vendidos por ese usuario)
            List<Producto> productosVendidos = ManejadorProdVendidos.ObtenerProductosVendidos(2);
            foreach (var item in productosVendidos)
            {
                Console.WriteLine(item.Descripciones);
            }

            //Traer Ventas(recibe el id del usuario y devuelve un a lista de Ventas realizadas por ese usuario)

            //Inicio de sesión(recibe un usuario y contraseña y devuelve un objeto Usuario)

        }
    }
}