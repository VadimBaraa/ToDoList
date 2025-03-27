using System;
using System.Collections.Generic;

namespace ToDoList
{
    public static class TaskShower
    {
        public static void ShowAll(List<TaskItem> tasks)
        {
            Console.Clear();
            Console.WriteLine("=== Список задач ===");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    string status = tasks[i].IsCompleted ? "[X]" : "[ ]";

                    if (tasks[i].IsCompleted)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                    }

                    Console.Write($"{i + 1}. {status} {tasks[i].Title}\t");
                    Console.WriteLine($"{tasks[i].DueDate.ToString("dd.MM.yyyy HH:mm")}");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("=====================");
            
        }
    }
}
