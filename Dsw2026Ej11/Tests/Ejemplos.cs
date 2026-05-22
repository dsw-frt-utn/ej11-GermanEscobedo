using System;
using System.Collections.Generic;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
 
    public static void EjemploList()
    {
        Console.WriteLine("=== PRUEBAS CON LIST<T> ===\n");
        CasoList miLista = new CasoList();

        // Agregar 3 alumnos a la lista
        Alumno a1 = new Alumno(1, "Juan Perez", 8.5);
        Alumno a2 = new Alumno(2, "Maria Gomez", 9.1);
        Alumno a3 = new Alumno(3, "Carlos Lopez", 6.8);
        miLista.AgregarAlumno(a1);
        miLista.AgregarAlumno(a2);
        miLista.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("--- Lista Inicial ---");
        foreach (var alumno in miLista.ObtenerLista()) { Console.WriteLine(alumno); } // Se ejecuta el .ToString() de Alumno

        // Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\n--- Buscando a 'Maria Gomez' ---");
        Alumno encontrado = miLista.BuscarPorNombre("Maria Gomez");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscando a 'Ana Silva' ---");
        Alumno noEncontrado = miLista.BuscarPorNombre("Ana Silva");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminando a Carlos Lopez (por objeto) ---");
        miLista.EliminarAlumno(a3);
        foreach (var alumno in miLista.ObtenerLista()) { Console.WriteLine(alumno); }

        // Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminando el primer elemento (Posición 0) ---");
        miLista.EliminarPorPosicion(0);
        foreach (var alumno in miLista.ObtenerLista()) { Console.WriteLine(alumno); }
    }
    

    
    public static void EjemploDictionary()
    {
        Console.WriteLine("=== PRUEBAS CON DICTIONARY<TKey, TValue> ===\n");
        CasoDictionary miDiccionario = new CasoDictionary();

        // Agregar 3 alumnos al diccionario
        Alumno a1 = new Alumno(100, "Lucia Fernandez", 7.5);
        Alumno a2 = new Alumno(101, "Pedro Martinez", 8.2);
        Alumno a3 = new Alumno(102, "Sofia Diaz", 9.8);
        miDiccionario.AgregarAlumno(a1);
        miDiccionario.AgregarAlumno(a2);
        miDiccionario.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("--- Diccionario Inicial ---");
        foreach (var par in miDiccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave: {par.Key} | Valor: {par.Value}");
        }

        // Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\n--- Buscando alumno con Clave 101 ---");
        Alumno encontrado = miDiccionario.BuscarPorClave(101);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscando alumno con Clave 999 ---");
        Alumno noEncontrado = miDiccionario.BuscarPorClave(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminando alumno con Clave 100 ---");
        miDiccionario.EliminarPorClave(100);
        foreach (var par in miDiccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave: {par.Key} | Valor: {par.Value}");
        }


    }

  
    public static void EjemploLinq()
    {
        Console.WriteLine("=== PRUEBAS CON LINQ ===\n");
        CasoLinq miLinq = new CasoLinq();

        // Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda

        Console.WriteLine("1. Primer libro:");
        Console.WriteLine(miLinq.GetPrimero().Titulo);

        Console.WriteLine("\n2. Último libro:");
        Console.WriteLine(miLinq.GetUltimo().Titulo);

        Console.WriteLine("\n3. Suma de precios:");
        Console.WriteLine(miLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n4. Promedio de precios:");
        Console.WriteLine(miLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n5. Libros con Id mayor a 15:");
        foreach (var libro in miLinq.GetListById()) { Console.WriteLine($"{libro.Id} - {libro.Titulo}"); }

        Console.WriteLine("\n6. Lista de libros (String formateado):");
        foreach (var texto in miLinq.GetLibros()) { Console.WriteLine(texto); }

        Console.WriteLine("\n7. Libro con el precio más alto:");
        Console.WriteLine($"{miLinq.GetMayorPrecio().Titulo} ({miLinq.GetMayorPrecio().Precio:C})");

        Console.WriteLine("\n8. Libro con el precio más bajo:");
        Console.WriteLine($"{miLinq.GetMenorPrecio().Titulo} ({miLinq.GetMenorPrecio().Precio:C})");

        Console.WriteLine("\n9. Libros cuyo precio es mayor al promedio:");
        foreach (var libro in miLinq.GetMayorPromedio()) { Console.WriteLine($"{libro.Titulo} ({libro.Precio:C})"); }

        Console.WriteLine("\n10. Libros ordenados por título (Descendente):");
        foreach (var libro in miLinq.GetLibrosOrdenadosPorTituloDesc()) { Console.WriteLine(libro.Titulo); }
    }
}

