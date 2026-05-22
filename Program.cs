// CASE 4 - MOSTRAR PRODUCTO MAS VENDIDO

case 4:

    Console.WriteLine("\n===== PRODUCTO MAS VENDIDO =====");

    int mayor = cantidades[0];
    int posicion = 0;

    for (int i = 0; i < cantidades.Length; i++)
    {
        if (cantidades[i] > mayor)
        {
            mayor = cantidades[i];
            posicion = i;
        }
    }

    Console.WriteLine("\nEl producto mas vendido es:");

    Console.WriteLine("Nombre del producto: " + productos[posicion]);
    Console.WriteLine("Precio del producto: " + precios[posicion]);
    Console.WriteLine("Cantidad vendida: " + cantidades[posicion]);

    Console.WriteLine("\nReporte generado correctamente.");

    break;