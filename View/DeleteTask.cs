using System;
using System.Collections.Generic;
using System.Globalization;

namespace ToDoList
{
    public static class TaskDeleter
    {
        public static void Delete(List<TaskItem> tasks)
        {
            TaskShower.ShowAll(tasks); 
            Console.Write("Введите номер задачи для удаления: ");
                        
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Задача удалена!");
            }
            else
            {
                Console.WriteLine("Неверный номер.");
            }
            Console.ReadKey();
        }
    }
}
