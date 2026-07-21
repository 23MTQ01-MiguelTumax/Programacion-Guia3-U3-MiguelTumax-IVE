namespace Problema1
{
    class Program
    {
        static string[,] productos = new string[10, 3];
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("======MENÚ======");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Actualizar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Registrar producto");
                        Registrar();
                        Pausa();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Mostrar productos");
                        Mostrar();
                        Pausa();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Actualizar producto");
                        Actualizar();
                        Pausa();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Elimar producto");
                        Eliminar();
                        Pausa();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }while (opcion != 5);
        }

        //Método Registrar

        static void Registrar()
        {
            bool registrado = false;
            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrEmpty(productos[i, 0]))
                {
                    Console.Write("Código: ");
                    productos[i, 0] = Console.ReadLine();
                    Console.Write("Nombre: ");
                    productos[i, 1] = Console.ReadLine();
                    Console.Write("Cantidad: ");
                    productos[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nProducto registrado.");
                    registrado = true;
                    break;
                }
            }

            if (!registrado)
            {
                Console.WriteLine("\nLa matriz está llena");
            }
        }

        //Método Mostrar

        static void Mostrar()
        {
            Console.WriteLine("\nCÓDIGO\tNOMBRE\t\tCANTIDAD");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(productos[i, 0]))
                {
                    Console.WriteLine(productos[i, 0] + "\t" + productos[i, 1] + "\t\t" + productos[i, 2]);
                }
            }
        }

        //Método Actualizar

        static void Actualizar()
        {
            string codigo;
            bool encontrado = false;

            Console.Write("Código a buscar: ");
            codigo = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (productos[i, 0] == codigo)
                {
                    Console.Write("Nuevo nombre: ");
                    productos[i, 1] = Console.ReadLine();
                    Console.Write("Nueva cantidad: ");
                    productos[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nRegistro actualizado.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado");
            }
        }

        //Método Eliminar

        static void Eliminar()
        {
            string codigo;
            bool encontrado = false;

            Console.Write("Código a eliminar: ");
            codigo = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (productos[i, 0] == codigo)
                {
                    productos[i, 0] = "";
                    productos[i, 1] = "";
                    productos[i, 2] = "";

                    Console.WriteLine("\nRegistro eliminado");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado");
            }
        }

        //Método Pausa

        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
            Console.Clear();
        }
    }
}