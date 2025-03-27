using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace ToDoList
{
    class Program
    {
        
        static List<TaskItem> tasks = new List<TaskItem>(); // Список для хранения задач
        public const string FilePath = "tasks.json";

        static void Main()
        {
            TaskLoader.LoadTasks(tasks);
            
            while (true)
            {
                Console.Clear();
                Console.Write
                ("=== To-Do List ===\n"  +
                "1. Добавить задачу\n" +
                "2. Показать все задачи\n" +
                "3. Удалить задачу\n" +
                "4. Отметить как выполненную\n" +
                "5. Выйти из программы\n" +
                "Выберите действие: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        TaskAdder.Add(tasks);;
                        break;

                    case "2":
                        TaskShower.ShowAll(tasks);
                        Console.ReadKey();
                        break;

                    case "3":
                        TaskDeleter.Delete(tasks);
                        break;

                    case "4":
                        TaskMarker.MarkTask(tasks);
                        break;

                    case "5":
                        TaskSaver.SaveTasks(tasks);
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        Console.ReadKey();
                        break;
                }
            }
        }


    }
}