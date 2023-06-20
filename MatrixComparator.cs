using System;
using System.ComponentModel;

namespace MatrixComparator
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1) Se pide el número de filas y de columnas que deberá tener la 1ª matriz: 

            int numfilas_1, numcolumnas_1;

            Console.WriteLine("Introduce el número de filas para la 1ª matriz: ");
            numfilas_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de columnas para la 1ª matriz: ");
            numcolumnas_1 = int.Parse(Console.ReadLine());

            int[,] matriz_1 = new int[numfilas_1, numcolumnas_1];   


            //  2) Se pide el número de filas y de columnas que deberá tener la 2ª matriz: 

            int numfilas_2, numcolumnas_2;

            Console.WriteLine("Introduce el número de filas para la 2ª matriz: ");
            numfilas_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de columnas para la 2ª matriz: ");
            numcolumnas_2 = int.Parse(Console.ReadLine());

            int[,] matriz_2 = new int[numfilas_2, numcolumnas_2];   


            //  3) El usuario introducirá los elementos de la 1ª matriz:

            for (int i = 0; i < numfilas_1; i++) 
            {
                for (int j = 0; j < numcolumnas_1; j++)
                {
                    Console.WriteLine("Introduce el elemento ({0}, {1}) de la lª matriz: ", (i + 1), (j + 1));
                    matriz_1[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //  4) El usuario introducirá los elementos de la 2ª matriz:

            for (int i = 0; i < numfilas_2; i++)
            {
                for (int j = 0; j < numcolumnas_2; j++)
                {
                    Console.WriteLine("Introduce el elemento ({0}, {1}) de la 2ª matriz: ", (i + 1), (j + 1));
                    matriz_2[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //  5) Se mostrará por pantalla el contenido de la 1ª matriz 
           
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("A continuación se muestra tu 1ª matriz: ");

            for (int i = 0; i < numfilas_1; i++)
            {
                for (int j = 0; j < numcolumnas_1; j++)
                {
                    Console.WriteLine("     Elemento (" + (i + 1) + ", " + (j + 1) + "): " + matriz_1[i, j]);
                }
            }


            //  6) Se mostrará por pantalla el contenido de la 2ª matriz 

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("A continuación se muestra tu 2ª matriz: ");

            for (int i = 0; i < numfilas_2; i++)
            {
                for (int j = 0; j < numcolumnas_2; j++)
                {
                    Console.WriteLine("     Elemento (" + (i + 1) + ", " + (j + 1) + "): " + matriz_2[i, j]);
                }
            }

            /*
            7) El programa deberá comprobar si las matrices se pueden comparar o no con la siguiente salida por pantalla:        
                7.1) "Las matrices no pueden ser comparadas"  
                7.2) "Las matrices pueden ser comparadas"
                7.3) Si las matrices pueden ser comparadas, deberán salir los siguientes mensajes por pantalla: 
                    - "Las matrices son iguales"
                    - "Las matrices no son iguales"
             */
            
            Console.WriteLine("---------------------------------------------------");

            bool mibooleano = true;

            if (numfilas_1 == numfilas_2 && numcolumnas_1 == numcolumnas_2) 
            {
                Console.WriteLine("Las matrices pueden ser comparadas.");

                for (int i = 0; i < numfilas_1; i++)   
                {
                    for (int j = 0; j < numcolumnas_1; j++)
                    {
                        if (matriz_1[i, j] != matriz_2[i, j])
                        {
                            mibooleano = false;

                        }
                    }
                }

                if (mibooleano)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales");
                }
            }
            else
            {
                Console.WriteLine("Las matrices no pueden ser comparadas.");
            }

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
