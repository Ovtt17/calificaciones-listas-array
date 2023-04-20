// Escriba un programa en C# que almacene en un arreglo n calificaciones de la asignatura de
// Programación Orientada a Objetos. El programa debe imprimir la cantidad de aprobados y
// reprobados de dicha asignatura.
// Realice dos versiones: una utilizando arreglos y otra utilizando el tipo List<>.

using System;
using System.Collections.Generic;


namespace Calificacaiones
{
  class Program
  {
    static void Main (string [] args)
    {
      //empezamos realizando el ejercicio con listas
      Console.WriteLine("Ejercicio con lista\n\n");

      //declaramos la lista de tipo entero
      List<int> ListaCalificaciones = new List<int>();
      
      //pedimos la cantidad de calificaciones a registrar;
      Console.WriteLine("Ingrese la cantidad de calificaciones de los alumnos: ");
      int n = int.Parse(Console.ReadLine());
      
      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"ingrese la calificacion {i+1}:");
        //utilizamos una variable aux para luego agregar la calificacion a la lista
        var aux = int.Parse(Console.ReadLine());
        ListaCalificaciones.Add(aux);
      }
      
      int aprobado = 60;
      Console.WriteLine(ListaCalificaciones.Count);
      for (int i = 0; i < ListaCalificaciones.Count; i++)
      {
        string mensaje = (ListaCalificaciones[i] >= aprobado) ? $"estudiante {i+1} aprobo con {ListaCalificaciones[i]}" : $"estudiante {i+1} reprobo con {ListaCalificaciones[i]}";
        Console.WriteLine(mensaje);
      }

      Console.ReadKey();
      //limpiamos la pantalla
      Console.Clear();
      Console.WriteLine("Ejercicio con arreglo\n\n");

      int [] arrayCalificaciones;

      //pedimos la cantidad de calificaciones a registrar;
      Console.WriteLine("Ingrese la cantidad de calificaciones de los alumnos: ");
      int nArray = int.Parse(Console.ReadLine());
      arrayCalificaciones = new int [nArray];

      for (int i = 0; i < nArray; i++)
      {
        Console.WriteLine($"ingrese la calificacion {i+1}:");
        arrayCalificaciones[i] = int.Parse(Console.ReadLine());
      }
      
      int aprobadoArray = 60;
      for (int i = 0; i < nArray; i++)
      {
        string mensaje = (arrayCalificaciones[i] >= aprobadoArray) ? $"estudiante {i+1} aprobo con {arrayCalificaciones[i]}" : $"estudiante {i+1} reprobo con {arrayCalificaciones[i]}";
        Console.WriteLine(mensaje);
      }
    }
  }
}
