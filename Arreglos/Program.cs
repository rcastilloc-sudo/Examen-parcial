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
                Console.WriteLine( "1. NombreProducto: " + nombreProducto[i] + "  1.Precio: " + precioProductos[i] + "1.Cantidad Vendida: " + cantidadVendida[i]);
            }

            break;

        case '3':
            break;

        case '4':
            break;

        case '5':
            break;

        case '6':
            Console.WriteLine("Gracias por preferirnos!");
            break;
    }

} while (menuIndex != '6');
