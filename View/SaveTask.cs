using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;

namespace ToDoList
{
    public static class TaskSaver
    {
        public static void SaveTasks(List<TaskItem> tasks)
        {
            try
            {
                string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(Program.FilePath, json);
                Console.WriteLine("Задачи сохранены!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении: {ex.Message}");
            }
        }
    }
}

