using ProyectoTarea.Models;

namespace ProyectoTarea.Services;

public class GestorService() {

  /// <summary>
  /// Esta es una lista de libros. Simula una base de datos.
  /// </summary>
  private readonly List<Tarea> _Tareas = [
    new Tarea{
      Id = 1,
      Title = "La fiesta del chivo",
      Gender = "Novela política",
      Author = "Mario Vargas Llosa"
    },

    new Tarea{
      Id = 2,
      Title = "El mundo de Sofía",
      Gender = "Novela filosófica",
      Author = "Jostein Gaarder"
    }
  ];

  /// <summary>
  /// Obtiene la lista de libros almacenados.
  /// </summary>
  /// <returns>Una lista de libros.</returns>
  public List<Tarea> FindAll() {
    return _Tareas;
  }
}