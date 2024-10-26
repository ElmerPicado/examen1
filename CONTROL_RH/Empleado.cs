using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace CONTROL_RH
{
    public static class Empleado
    {
        static int n = 10;
        public static int[] id = new int[n];
        public static string[] cedula = new string[n];
        public static string[] nombre = new string[n];
        public static string[] direccion = new string[n];
        public static string[] telefono = new string[n];
        public static float[] salario = new float[n];

        public static void listaNombres()
        
        {
            Console.Clear();
            for (int i = 0; i < id.Length; i++) 
            
            {
                Console.WriteLine($"nombre : {Empleado.nombre[i]}");
                

            }
        
         
        
        }
        public static void calculo() 
        {
            float sumaSalarios = 0;
            int contadorEmpleados = 0;

            for (int i = 0; i < Empleado.salario.Length; i++)
            {
                if (Empleado.salario[i] > 0)
                {
                    sumaSalarios += Empleado.salario[i];
                    contadorEmpleados++;
                }
            }

            if (contadorEmpleados > 0)
            {
                float promedio = sumaSalarios / contadorEmpleados;
                Console.WriteLine($"El promedio de los salarios es: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados con salario.");
            }

        }
        
        
        
        
        
        
        public static void agregar() {

            int indice = 0;
            int num = 1;

            while (indice < Empleado.id.Length)
            {

                Console.Clear();
                Console.WriteLine($"***REGISTRO empleados {num}***");
                Console.Write($"Digite su ID: ");
                Empleado.cedula[indice] = Console.ReadLine();

                Console.Write(" nombre del Empleado: ");
                Empleado.nombre[indice] = (Console.ReadLine());

                Console.Write($"Direccion: ");
                Empleado.direccion[indice] = Console.ReadLine();

                Console.Write($"telefono: ");
                Empleado.telefono[indice] = Console.ReadLine();

                Console.Write($"Salario : ");
                Empleado.salario[indice] = int.Parse(Console.ReadLine());

                num++;
                indice++;
                Console.Clear();
            }
            Console.WriteLine("Los empleados han sido agregados \n");
        }

        public static void modificarEmpleado()
        {
            Console.Clear();
            Console.Write("Digite la cedula del empleado:");

            string NewName = Console.ReadLine();

            for (int i = 0; i < Empleado.id.Length; i++)
            {
                if (Empleado.cedula[i] == NewName)
                {
                    Console.Clear();
                    Console.Write("*****Datos del  Empleado:****\n");
                    Console.WriteLine($"Cedula: {Empleado.cedula[i]} Nombre Art.: {Empleado.nombre[i]} ");

                    Console.WriteLine($"Digite  un nuevo nombre ");
                    Empleado.nombre[i] = Console.ReadLine();

                    Console.WriteLine($"Digite  una nueva direccion ");
                    Empleado.direccion[i] = Console.ReadLine();

                    Console.WriteLine($"Digite  un nuevo telefono ");
                    Empleado.telefono[i] = Console.ReadLine();

                    Console.WriteLine($"Digite  Salario ");
                    Empleado.salario[i] = float.Parse(Console.ReadLine());



                    break;
                }
            }
        }
        public static void consultar()
        {

            string entrada = "";
            Console.Clear();
            Console.WriteLine("***Buscador de Empleados***\n");
            Console.Write("ingrese el Nombre o cedula del Empleado: ");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int result))
            {
                for (int i = 0; i < Empleado.id.Length; i++)
                {

                    if (entrada == Empleado.nombre[i] || entrada == Empleado.cedula[i])
                    {
                        Menu.Impresion_datos(i);

                    }
                }
            }


        }  
        public static void BorrarEmpleado()
        {
            char sino = ' ';
            Console.Clear();
            Console.Write("Digite el nombre del empleado:");
           string Code = Console.ReadLine();

            for (int i = 0; i < Empleado.id.Length; i++)
            {
                if (Empleado.nombre[i] == Code)
                {
                    Console.Clear();
                    Console.Write("*****Datos del  articulo:****\n");
                    Menu.Impresion_datos(i);
                    Console.WriteLine($"esta seguro que lo quiere borrar ? \nDigite 'S' para si o 'N'para no");
                    sino = char.Parse(Console.ReadLine().ToLower());
                    if (sino == 's')
                    {
                        Empleado.nombre[i] = " ";
                        Empleado.cedula[i] = "";
                        Empleado.salario[i] = 0;
                        Empleado.telefono[i] = "";
                        Empleado.direccion[i] = "";
                        Console.WriteLine("***El empleado a sido Borrado***\n");

                    }
                    else { break; }
                }
            }
        }
        public static void inicializar()
        {
            for (int i = 0; i < Empleado.id.Length; i++)
            {
                Empleado.nombre[i] = " ";
                Empleado.cedula[i] = "";
                Empleado.salario[i] = 0;
                Empleado.telefono[i] = "";
                Empleado.direccion[i] = "";
            }

            Console.Clear();
            Console.WriteLine("***El sistema ha sido inicializados**\n");
        }
        public  static void reportes()

        {
            int op = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("** subMenu reporte empleados **\n");
                Console.WriteLine("1- Listar todos los empleados");
                Console.WriteLine("2- Calcular promedio salarios");
                Console.WriteLine("3- Volver a Menu principal");
                
                op =int.Parse (Console.ReadLine());
                switch (op)

                {
                    case 1:
                        listaNombres(); break;

                    case 2:
                        calculo(); break;
                   default: break;

                    






                }



            } while (op!=3);



        }
    }
}
