using System.Diagnostics;
using System.Xml.XPath;

String[] nombreProducto = new string[10];
int[] precioProductos = new int[10];
int[] cantidadVendida = new int[10];

int productosTotales = 0;

char menuIndex;

do
{
    Console.WriteLine(@"
======= MENU ======
1. Registrar Productos
2. Mostrar Productos
3. Calcular total vendido
4. Mostrar producto mas vendido
5. Mostrar promedio de ventas
6. Salir
");

    menuIndex = Convert.ToChar(Console.ReadLine());

    switch (menuIndex)
    {
        case '1':

            Console.WriteLine("Total de productos a registrar");
            productosTotales = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < productosTotales; i++)
            {
                Console.Write($"Ingrese el nombre del producto #{i + 1}: ");
                nombreProducto[i] = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                precioProductos[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese cantidad vendida: ");
                cantidadVendida[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            break;

        case '2':

            for (int i = 0; i < productosTotales; i++)
            {
                Console.WriteLine( "1. Nombre Producto: " + nombreProducto[i] + " 2. Precio: " + precioProductos[i] + " 3. Cantidad Vendida: " + cantidadVendida[i]);
            }

            break;

        case '3':

        int totalVendido = 0;

        for (int i = 0; i < productosTotales; i++)
         {
            totalVendido += precioProductos[i] * cantidadVendida[i];
         }

    Console.WriteLine("Total vendido: $" + totalVendido);

            break;

        case '4':

        int mayorCantidad = cantidadVendida[0];
        int posicion = 0;

        for (int i = 1; i < productosTotales; i++)
        {
            if (cantidadVendida[i] > mayorCantidad)
            {
            mayorCantidad = cantidadVendida[i];
            posicion = i;
            }
        }

        Console.WriteLine("Producto mas vendido:");
        Console.WriteLine("Nombre: " + nombreProducto[posicion]);
        Console.WriteLine("Cantidad vendida: " + cantidadVendida[posicion]);

            break;

        case '5':
        int sumaVentas = 0;

        for (int i = 0; i < productosTotales; i++)
        {
            sumaVentas += precioProductos[i] * cantidadVendida[i];
        }

        double promedio = 0;

        if (productosTotales > 0)
        {
            promedio = (double)sumaVentas / productosTotales;
        }

        Console.WriteLine("Promedio de ventas: $" + promedio);

            break;

        case '6':
            Console.WriteLine("Gracias por preferirnos!");
            break;
    }

} while (menuIndex != '6');

