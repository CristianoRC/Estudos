using System.Collections.Generic;
using System;

namespace Reflections
{
    public class Log
    {
        public static List<object> logs = new List<object>();

        public static void GravarLog(object log)
        {
            logs.Add(log);
        }

        public static void ApresentarLog()
        {
            foreach (var log in logs)
            {
                var type = log.GetType();
                Console.WriteLine($"Tipo: {type.Namespace}{type.Name}");
                foreach (var property in log.GetType().GetProperties())
                {
                    Console.Write($"{property.Name}: {property.GetValue(log)}, ");
                }
                
                Console.WriteLine("\n-----------------------------");
            }
        }
    }
}