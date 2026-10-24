﻿using ProyectoTarea.Models;
using ProyectoTarea.Services;
using Spectre.Console;

class Program {
  public static bool running = true;
  public static string[] choices = [
    "1. Ver tarea",
    "2. Eliminar tarea",
    "3. Agregar un tarea",
    "4. Salir"
  ];
  public static GestorService gestorService = new();
  public static void Main() {
    // Bucle
    while (running) {

      var selections = new SelectionPrompt<string>()
        .Title("[PaleGreen1]Indica la acción a realizar:[/]")
        .HighlightStyle("DarkViolet_1")
        .AddChoices(choices);

      var option = AnsiConsole.Prompt(selections);

      List<Tarea> tareas = gestorService.FindAll();

      // Estructura para evaluar la opción seleccionada
      switch (option) {
        case "1. Mostrar libros":
          AnsiConsole.Clear();

          var table = new Table();
          table.AddColumn("Id");
          table.AddColumn("Título");
          table.AddColumn("Género");
          table.AddColumn("Autor");

          // Inyecto valores a las filas de la tabla
          foreach (Tarea tarea in tareas) {
            table.AddRow(
              tarea.Id.ToString(),
              tarea.Title,
              tarea.Gender,
              tarea.Author
            );
          }

          // Muestro la tabla
          AnsiConsole.Write(table);

          break;
        case "2. Eliminar una tarea":
          Console.WriteLine("Opción 2");
          break;
        case "3. Agregar una tarea":
          Console.WriteLine("Opción 3");
          break;
        case "4. Salir":
          AnsiConsole.Clear();
          AnsiConsole.MarkupLine("[DarkViolet_1]¡Fin del programa![/]");
          running = false;
          break;
      }
    }

  }
}