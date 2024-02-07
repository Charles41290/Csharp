using PrimerEntrega;

internal class Program
{
    static void Main(string[] args)
    {
        // UsuarioData gestor = new UsuarioData();

        try
        {
            //Usuario usuario = gestor.ObtenerUsuarioPorId(1);
            //Console.WriteLine(UsuarioData.ObtenerUsuarioPorId(3));

            // Usuario usuarioNuevo = new Usuario(3,"Charles", "Rom", "crom412", "tukituki","lolo@gmail.com");
            // creo un usario sin parsarle el Id ya que el método constructor admite sobre-carga
            //Usuario usuarioNuevo2 = new Usuario("Lalo", "Palo", "lalo748", "lalitolito", "lalo@gmail.com");

            //if (UsuarioData.AgregarUsuario(usuarioNuevo2))
            //{
            //    Console.WriteLine("Se agrego un usuario");

            //}

            //if (UsuarioData.BorrarUsuarioPorId(5))
            //{
            //    Console.WriteLine("Usuario eliminado");

            //}

            //Usuario usuarioAModificar = new Usuario("Charles X", "Romero", "crom412", "elbolo", "bolololo@gmail.com");
            ////Console.WriteLine(usuarioAModificar.ToString());
            //if (UsuarioData.ActualizarUsuarioPorId(6, usuarioAModificar))
            //{
            //    Console.WriteLine("Usuario actualizado");

            //}

            //List<Usuario> usuarios = UsuarioData.ListarUsuarios();
            //foreach (var item in usuarios)
            //{
            //    Console.WriteLine(item);
            //}

            // *******************************************
            // Trabajo con la tabla Productos
            // *******************************************
            //Console.WriteLine(ProductoData.ObtenerProductoPorId(1));

            // Agregar producto
            //Producto productoAAgregar = new Producto("Latop Alienware M17", 76000, 85000, 5, 2);
            //if (ProductoData.AgregarProducto(productoAAgregar))
            //{
            //    Console.WriteLine("Se agrego un usuario");

            //}

            // Eliminar producto
            //if (ProductoData.BorrarUsuarioPorId(6))
            //{
            //    Console.WriteLine("Se elimino usuario");
            //}
            //Actualizacion de producto
            //Producto productoAActualizar = new Producto("Laptop Alienware M18", 80000,90000,4,2);
            //if (ProductoData.ActualizaProductoPorId(5, productoAActualizar));
            //{
            //    Console.WriteLine("Se elimino usuario");
            //}

            //List<Producto> productos = ProductoData.ListarProductos();
            //foreach (Producto producto in productos)
            //{
            //    Console.WriteLine(producto.ToString());
            //}

            // *******************************************
            // Trabajo con la tabla Ventas
            // *******************************************
            //List<Venta> ventas = VentaData.ListarVentas();
            //foreach (var item in ventas)
            //{
            //    Console.WriteLine(item.ToString());   
            //}

            //Venta venta = VentaData.ObtenerVentaPorId(3);
            //Console.WriteLine(venta.ToString());

            //if (VentaData.BorrarVentaPorId(3)) ;
            //{
            //    Console.WriteLine("Se elimino usuario");
            //}

            //Venta ventaAActualizar = new Venta("No devuelvan lo robado",1);
            //if (VentaData.ActualizarVentaPorId(98, ventaAActualizar))
            //{
            //    Console.WriteLine("Se actualizó usuario");
            //}

            // *******************************************
            // Trabajo con la tabla ProductosVendidos
            // *******************************************
            //List<ProductoVendido> ventas = ProductoVendidoData.ListarProductosVendidos();
            //foreach (var v in ventas)
            //{
            //    Console.WriteLine(v);
            //}
            //ProductoVendido venta = ProductoVendidoData.ObtenerProductoVendidoPorId(1);
            //Console.WriteLine(venta.ToString());

            //if (ProductoVendidoData.BorrarProductoVendidoPorId(3))
            //{
            //    Console.WriteLine("ProductoVendido Eliminado");
            //}

            ProductoVendido productoVendidoAModificar = new ProductoVendido(1,15,1);
            if (ProductoVendidoData.ActualizarProductoVendidoPorId(1, productoVendidoAModificar))
            {
                Console.WriteLine("Producto Modificado");
            }




        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }



    }

}