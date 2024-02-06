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

            // *******************************************
            // Trabajo con la tabla Productos
            // *******************************************
            // Console.WriteLine(ProductoData.ObtenerProductoPorId(366));

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
            Producto productoAActualizar = new Producto("Laptop Alienware M18", 80000,90000,4,2);
            if (ProductoData.ActualizaProductoPorId(5, productoAActualizar));
            {
                Console.WriteLine("Se elimino usuario");
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }



    }

}