using System;

namespace Proyecto_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Ingreso de notas");

        
          float[] numeros;
          int cantidad;
          float suma=0;
          float mayor,menor;

          Console.WriteLine("ingrese la cantidad de notas");
          cantidad=int.Parse(Console.ReadLine());
          numeros=new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                   Console.WriteLine("Ingrese la nota numero "+(i+1)+":");
                float NumeroVerificar=float.Parse(Console.ReadLine());

               if (NumeroVerificar>=0 && NumeroVerificar<=7 )
                {
                numeros[i] = NumeroVerificar;
                suma += numeros[i];
                }else
                {
                   Console.WriteLine("Ingrese una Nota con un rango del 0 al 7");
                i--;
                }
                
                
               
            }
            mayor=numeros[0];
            menor=numeros[0];
            for (int i = 0; i < cantidad; i++)
            {
                if (numeros[i]>mayor)
                {
                    mayor=numeros[i];
                }else if (numeros[i]<menor)
                {
                    menor=numeros[i];
                }
            }
            float promedio= suma/cantidad;
              Console.WriteLine("Tus estadisticas son");
              Console.WriteLine("La Clasificacion mayor es : "+mayor);
              Console.WriteLine("La Clasificacion menor es : "+menor);

              
              if (promedio<4)
              {
                  Console.WriteLine("El promedio es : "+promedio+" y has reprobado la asisnatura");
              }

              if (promedio>=4)
              {
                  Console.WriteLine("El promedio es : "+promedio+" y has aprobado la asisnatura");
              }

             

        }
    }
}
