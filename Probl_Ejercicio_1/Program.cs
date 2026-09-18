Console.WriteLine("==================================================================");
Console.WriteLine("EJERCICIO 1: Cálculo de potencia de un motor CD (P = V * I)");
Console.WriteLine("Clasificación:");
Console.WriteLine(" - Potencia <= 120 W: CONSUMO NORMAL");
Console.WriteLine(" - Potencia > 120 W: ADVERTENCIA: CONSUMO ELEVADO");
Console.WriteLine("==================================================================\n");

double voltaje, corriente, potencia;

Console.Write("Ingrese el voltaje (V): ");
voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (I): ");
corriente = Convert.ToDouble(Console.ReadLine());

      
potencia = voltaje * corriente;

Console.WriteLine($"\nPotencia calculada: {potencia:F2} W");

            if (potencia <= 120)
            {
                Console.WriteLine("Resultado: CONSUMO NORMAL");
            }
            else
            {
                Console.WriteLine("Resultado: ADVERTENCIA: CONSUMO ELEVADO");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        