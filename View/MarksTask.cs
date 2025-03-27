using System;
using System.Collections.Generic;

namespace ToDoList
{
    public static class TaskMarker
    {
        public static void MarkTask(List<TaskItem> tasks)
        {
            TaskShower.ShowAll(tasks); 
            Console.Write("Введите номер выполненной задачи: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                tasks[index - 1].IsCompleted = true;
                Console.WriteLine("Задача отмечена как выполненная!");
            }
            else
            {
                Console.WriteLine("Неверный номер.");
            }
            Console.ReadKey();
        }
    }
}
