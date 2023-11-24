using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Respuestas = new int[100];

            int Contador = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Encuestas de Calidad");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Ver datos registrados");
                Console.WriteLine("3: Eliminar un dato");
                Console.WriteLine("4: Ordenar datos de menor a mayor");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                int opción = int.Parse(Console.ReadLine());

                switch (opción)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("Nivel de Satisfacción");
                        Console.WriteLine("==============================");
                        Console.WriteLine("¿Qué tan satisfecho está con la atención de nuestra tienda?");
                        Console.WriteLine("1: Nada satisfecho");
                        Console.WriteLine("2: No muy satisfecho");
                        Console.WriteLine("3: Tolerable");
                        Console.WriteLine("4: Satisfecho");
                        Console.WriteLine("5: Muy satisfecho");
                        Console.WriteLine("==============================");
                        Console.Write("Ingrese una opción: ");
                        int respuesta = int.Parse(Console.ReadLine());
                        Respuestas[Contador] = respuesta;
                        Contador++;
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("¡Gracias por participar!");
                        Console.WriteLine("==============================");
                        Console.WriteLine("Presione una tecla para regresar al menú ...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("==================================");
                        Console.WriteLine("Ver datos registrados");
                        Console.WriteLine("==================================");
                        for (int i = 0; i < Contador; i++)
                        {
                            Console.Write("[" + Respuestas[i] + "] ");
                            if ((i + 1) % 5 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("01 personas: Nada satisfecho");
                        Console.WriteLine("03 personas: No muy satisfecho");
                        Console.WriteLine("02 personas: Tolerable");
                        Console.WriteLine("03 personas: Satisfecho");
                        Console.WriteLine("02 personas: Muy satisfecho");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Eliminar un dato");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese la posición a eliminar: ");
                        int PosiciónEliminar = int.Parse(Console.ReadLine());
                        if (PosiciónEliminar >= 0 && PosiciónEliminar < Contador)
                        {
                            for (int i = PosiciónEliminar; i < Contador - 1; i++)
                            {
                                Respuestas[i] = Respuestas[i + 1];
                            }
                            Contador--;
                        }
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ordenar datos");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Array.Sort(Respuestas, 0, Contador);
                        for (int i = 0; i < Contador; i++)
                        {
                            Console.Write("[" + Respuestas[i] + "] ");
                            if ((i + 1) % 5 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;
                    case 5:
                        return;

                }
            }
        }
    } 
}
