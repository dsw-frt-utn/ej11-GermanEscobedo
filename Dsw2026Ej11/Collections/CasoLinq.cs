using System.Collections.Generic;
using System.Linq;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoLinq
{
    // Campo privado con la lista de libros cargada mediante el método estático de la clase Libro
    private List<Libro> _libros = Libro.CrearLista();

    // 1. Obtener el primer libro (GetPrimero)
    public Libro GetPrimero()
    {
        // First() retorna el primer elemento de la colección.
        return _libros.First();
    }

    // 2. Obtener el último libro (GetUltimo)
    public Libro GetUltimo()
    {
        // Last() retorna el último elemento de la colección.
        return _libros.Last();
    }

    // 3. Obtener la suma de precios (GetTotalPrecios)
    public decimal GetTotalPrecios()
    {
        // Sum() recorre toda la lista y suma la propiedad especificada.
        return _libros.Sum(libro => libro.Precio);
    }

    // 4. Obtener el promedio de precios (GetPromedioPrecios)
    public decimal GetPromedioPrecios()
    {
        // Average() calcula el promedio de la propiedad especificada.
        return _libros.Average(libro => libro.Precio);
    }

    // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro> GetListById()
    {
        // Where() filtra la lista en base a una condición (Id > 15) y ToList() materializa el resultado en una nueva lista.
        return _libros.Where(libro => libro.Id > 15).ToList();
    }

    // 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) 
   
    public List<string> GetLibros()
    {
        // Select() transforma (proyecta) cada elemento en algo nuevo. Aquí creamos un string para cada libro.
       
        return _libros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}").ToList();
    }

    // 7. Obtener el libro con el precio más alto (GetMayorPrecio)
    public Libro GetMayorPrecio()
    {
        // OrderByDescending() ordena de mayor a menor y First() toma el primero (el más alto).
        return _libros.OrderByDescending(libro => libro.Precio).First();
    }

    // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
    public Libro GetMenorPrecio()
    {
        // OrderBy() ordena de menor a mayor y First() toma el primero (el más bajo).
        return _libros.OrderBy(libro => libro.Precio).First();
    }

    // 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio()
    {
        // Primero calculamos el promedio y luego lo usamos para filtrar.
        decimal promedio = _libros.Average(libro => libro.Precio);
        return _libros.Where(libro => libro.Precio > promedio).ToList();
    }

    // 10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> GetLibrosOrdenadosPorTituloDesc()
    {
        return _libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}