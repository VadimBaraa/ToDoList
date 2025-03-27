using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;

namespace ToDoList
{
    public static class TaskLoader
    {
        public static void LoadTasks(List<TaskItem> tasks)
        {
            if (File.Exists(Program.FilePath))
            {
                try
                {
                    string json = File.ReadAllText(Program.FilePath);
                    List<TaskItem> loadedTasks = JsonSerializer.Deserialize<List<TaskItem>>(json);
                    if (loadedTasks != null)
                    {
                        tasks.Clear(); 
                        tasks.AddRange(loadedTasks); 
                        Console.WriteLine($"Загружено {tasks.Count} задач.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
                }
            }
        }
    }
}

