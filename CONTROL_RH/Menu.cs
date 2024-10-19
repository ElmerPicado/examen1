using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_RH
{
    internal class Menu
    {
        public static void Impresion_datos(int i)
        {
            Console.WriteLine($"== cedula: {Empleado.cedula[i]}/\n");
            Console.WriteLine($"nombre : {Empleado.nombre[i]} / direccion : {Empleado.direccion[i]} / telefono: {Empleado.telefono[i]} " +
                $"/ salario: {Empleado.salario[i]} ");
            Console.WriteLine("-------------------------------------------------------------------\n");

        }
        public static  void principalmenu() { 
            
        int opcion = 0;

            do
            {
                Console.WriteLine("**Menu principal RH **\n");
                Console.WriteLine("1- Agrgar empleados");
                Console.WriteLine("2- Consultar Empleados");
                Console.WriteLine("3- Modificar Empleados");
                Console.WriteLine("4- Borrar Empleados");
                Console.WriteLine("5- Inicializar Arreglos");
                Console.WriteLine("6-reportes");
                Console.WriteLine("7- Salir\n");
                Console.WriteLine("Digite una opcion:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Empleado.agregar(); break;
                    case 2: Empleado.consultar(); break;
                    case 3: Empleado.modificarEmpleado(); break;
                    case 4: Empleado.BorrarEmpleado(); break;
                    case 5: Empleado.inicializar(); break;
                    case 6: Empleado.reportes(); break;
                    case 7: Console.WriteLine("Saliendo del Sistema"); break;
                    default: Console.WriteLine("***Opcion Incorrecta***"); break;


                }



            } while (opcion != 7); 



        }

      

           


        
      

        
        
        

        

        

    }
}
