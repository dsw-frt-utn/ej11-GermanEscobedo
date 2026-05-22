using System.Collections.Generic;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        // Usamos ContainsKey para verificar que el Id no esté registrado previamente. 
        // Si intentamos agregar una clave duplicada en un diccionario, el programa lanzará una excepción.
        if (!_alumnos.ContainsKey(alumno.Id))
        {
            _alumnos.Add(alumno.Id, alumno);
        }
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno BuscarPorClave(int legajo)
    {
        // en la variable 'alumnoEncontrado'. Si no existe, simplemente retorna null sin romper el programa.
        _alumnos.TryGetValue(legajo, out Alumno alumnoEncontrado);
        return alumnoEncontrado;
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarPorClave(int legajo)
    {
        // Remove busca directamente la clave. Si existe, la elimina junto con su valor y  si no existe la elimina 
        
        _alumnos.Remove(legajo);
    }
}